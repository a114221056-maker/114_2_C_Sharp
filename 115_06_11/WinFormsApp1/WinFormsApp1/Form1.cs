using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // 主表單類別：提供摩斯密碼轉換的 UI 與邏輯
        // 功能：啟動時載入外部的 morse_code_table.md 檔案建立對照表，
        //       使用者在上方文字方塊輸入字串後按下「轉換」可在下方看到完整摩斯結果與逐字對照。
        // 注意：若摩斯表載入失敗，會禁用轉換按鈕並顯示錯誤訊息。

        // 每筆摩斯碼資料
        private struct MorseEntry
        {
            public char Symbol;
            public string Code;

            public MorseEntry(char symbol, string code)
            {
                Symbol = symbol;
                Code = code;
            }
        }

        // 使用 List 儲存完整摩斯密碼表（不可使用 Dictionary）
        // 每個項目為一筆 Symbol/Code 的對應資料
        private List<MorseEntry> morseTable = new List<MorseEntry>();
        // 表示是否成功載入摩斯碼表，若為 false 則禁止轉換按鈕
        private bool morseLoaded = false;

        public Form1()
        {
            InitializeComponent();
            // 建構子：初始化元件後立即嘗試載入摩斯碼表
            // 資料來源為 morse_code_table.md（會從輸出目錄讀取）
            // 若載入失敗，程式會顯示錯誤並禁用轉換功能
            LoadMorseTableFromFile("morse_code_table.md"); 
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // 使用者按下「轉換」按鈕時呼叫
            // 流程：
            // 1. 檢查輸入是否為空
            // 2. 檢查摩斯碼表是否已成功載入（morseLoaded）
            // 3. 呼叫 ConvertToMorse 取得完整摩斯字串，顯示於 textBoxMorse
            // 4. 逐字呼叫 GetMorseForChar，並在 listBox1 顯示每個字元與對應摩斯碼
            listBox1.Items.Clear();
            string input = textBoxInput.Text ?? string.Empty;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("請輸入要轉換的字串。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 檢查是否成功載入摩斯碼表，若未載入則禁止轉換
            if (!morseLoaded)
            {
                MessageBox.Show("摩斯碼表未載入，無法進行轉換。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 使用由檔案載入的對照表進行轉換
            var morse = ConvertToMorse(input);
            textBoxMorse.Text = morse;

            // 顯示每個字元與其對應的摩斯碼，單列顯示格式範例： "H → ...."
            foreach (var ch in input)
            {
                var code = GetMorseForChar(ch);
                // 若字元未定義於 morse_code_table.md 則忽略
                if (code == null)
                    continue;

                string label;
                if (char.IsWhiteSpace(ch))
                {
                    label = "空白";
                }
                else
                {
                    label = char.ToUpperInvariant(ch).ToString();
                }

                listBox1.Items.Add($"{label} → {code}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 使用者按下「清除」按鈕：清空所有顯示與輸入欄位
            textBoxInput.Clear();
            textBoxMorse.Clear();
            listBox1.Items.Clear();
        }

        // 將輸入文字轉換為摩斯碼，使用預先由檔案建立的 morseTable
        // 備註：ConvertToMorse 會忽略在摩斯表中找不到的字元
        private string ConvertToMorse(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            var parts = text.Select(ch => GetMorseForChar(ch)).Where(s => s != null);
            return string.Join(" ", parts);
        }

        // 取得單一字元的摩斯碼。
        // 規則：
        // - 英文字母不區分大小寫（會嘗試以大寫鍵查詢）。
        // - 空白字元若有定義則使用定義，否則回傳 "/" 作為字與字之間的分隔符號。
        // - 若字元未定義於 morse_code_table.md，則回傳 null（呼叫端會忽略該字元）。
        // 取得單一字元的摩斯碼：
        // - 空白會回傳表中定義或 '/' 作為單字分隔
        // - 文字大小寫不區分（會嘗試以大寫查找）
        // - 若未定義則回傳 null（呼叫端會忽略）
        private string GetMorseForChar(char ch)
        {
            // 空白字元處理
            if (char.IsWhiteSpace(ch))
            {
                var sp = morseTable.FirstOrDefault(e => e.Symbol == ' ');
                if (sp.Code != null)
                    return sp.Code;
                return "/";
            }

            // 先以原字元查找
            var found = morseTable.FirstOrDefault(e => e.Symbol == ch);
            if (found.Code != null)
                return found.Code;

            // 再以大寫查找（針對英文字母）
            var up = char.ToUpperInvariant(ch);
            found = morseTable.FirstOrDefault(e => e.Symbol == up);
            if (found.Code != null)
                return found.Code;

            // 未定義則回傳 null
            return null;
        }

        // 讀取 morse_code_table.md 並建立 morseTable
        // 要求：使用 StreamReader 並透過 File.OpenText 開啟檔案，並以 !inputFile.EndOfStream 迴圈讀取
        // 行為：若檔案不存在或格式錯誤則顯示訊息並禁用轉換按鈕
        private void LoadMorseTableFromFile(string relativePath)
        {
            try
            {
                // 以應用程式執行目錄為基準尋找檔案
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                var fullPath = Path.Combine(baseDir, relativePath);

                if (!File.Exists(fullPath))
                {
                    MessageBox.Show($"找不到摩斯碼表檔案：{fullPath}", "檔案遺失", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    morseLoaded = false;
                    btnConvert.Enabled = false;
                    return;
                }

                // 使用 File.OpenText 開啟並取得 StreamReader
                using (StreamReader inputFile = File.OpenText(fullPath))
                {
                    // 逐行讀取檔案直到檔案結尾
                    while (!inputFile.EndOfStream)
                    {
                        var line = inputFile.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        line = line.Trim();
                        // 忽略 Markdown 標題或表格分隔列
                        if (line.StartsWith("#") || line.StartsWith("---") || line.StartsWith("|---"))
                            continue;

                        string key = null;
                        string code = null;

                        // 處理 markdown 表格格式的行，表格可能在同一行包含多個 (Character, Code) 配對
                        if (line.Contains("|"))
                        {
                            var cols = line.Split('|').Select(s => s.Trim()).Where(s => !string.IsNullOrEmpty(s)).ToArray();
                            if (cols.Length >= 2)
                            {
                                // 逐一處理每對欄位 (key, code)
                                for (int i = 0; i + 1 < cols.Length; i += 2)
                                {
                                    var keyPart = cols[i];
                                    var codePart = cols[i + 1];

                                    // 清理 code 欄位，移除 Markdown 的反引號或星號等包裝
                                    var cleanedCode = codePart.Trim('`').Trim('*').Trim();

                                    // 解析 key 為對應字元
                                    char? parsedChar = ParseKeyToChar(keyPart);
                                    if (parsedChar == null)
                                    {
                                        // 若為表頭或無法解析則跳過
                                        continue;
                                    }

                                    var mapCharLocal = char.ToUpperInvariant(parsedChar.Value);
                                    // 新增或更新 List 中的對應項目
                                    var idxLocal = morseTable.FindIndex(e => e.Symbol == mapCharLocal);
                                    if (idxLocal >= 0)
                                    {
                                        morseTable[idxLocal] = new MorseEntry(mapCharLocal, cleanedCode);
                                    }
                                    else
                                    {
                                        morseTable.Add(new MorseEntry(mapCharLocal, cleanedCode));
                                    }
                                }

                                // 已處理整行表格資料，跳到下一行
                                continue;
                            }
                        }
                        else
                        {
                            // 其他可能為空白分隔，例如: A .-
                            var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length >= 2)
                            {
                                key = parts[0];
                                code = parts[1];
                            }
                        }

                        if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(code))
                        {
                            MessageBox.Show($"摩斯碼表格式錯誤：無法解析行 '{line}'。", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            morseLoaded = false;
                            btnConvert.Enabled = false;
                            return;
                        }

                        // 處理 key 為 "space" 或 " " 的情況
                        char mapChar;
                        if (key.Equals("space", StringComparison.OrdinalIgnoreCase) || key == " ")
                        {
                            mapChar = ' ';
                        }
                        else if (key.Length == 1)
                        {
                            mapChar = key[0];
                        }
                        else
                        {
                            // 若發現欄位為表頭（例如 "Symbol"/"Morse"），則略過該行
                            // 當 cols[0] 長度大於 1，且不是 "space"，視為表頭而跳過
                            // 但在空白分隔的格式中，若第一欄長度>1 則視為格式錯誤
                            if (line.Contains("|"))
                            {
                                // 已視為表頭，跳過
                                continue;
                            }
                            else
                            {
                                // 空白分隔格式中出現非單一字元 key，視為格式錯誤
                                MessageBox.Show($"摩斯碼表格式錯誤：無效的 key '{key}'。", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                morseLoaded = false;
                                btnConvert.Enabled = false;
                                return;
                            }
                        }

                        // 將 code 進行基本清理，移除多餘符號
                        code = code.Trim();

                        // 將字元統一為大寫以方便查找（英文字母）
                        mapChar = char.ToUpperInvariant(mapChar);

                        // 新增或更新 List 中的對應項目
                        var idx = morseTable.FindIndex(e => e.Symbol == mapChar);
                        if (idx >= 0)
                        {
                            morseTable[idx] = new MorseEntry(mapChar, code);
                        }
                        else
                        {
                            morseTable.Add(new MorseEntry(mapChar, code));
                        }
                    }
                }
                // 若執行到此處且沒有發生格式錯誤，表示載入成功
                morseLoaded = morseTable.Count > 0;
                btnConvert.Enabled = morseLoaded;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取摩斯碼表時發生錯誤：{ex.Message}", "讀檔錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                morseLoaded = false;
                btnConvert.Enabled = false;
            }
        }

        // 解析表格中的 key 欄位（文字）成對應的字元
        // 回傳 null 表示無法解析（例如表頭或不支援的多字元 key）
        private char? ParseKeyToChar(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return null;

            key = key.Trim();

            // 處理特殊文字表示
            if (key.Equals("space", StringComparison.OrdinalIgnoreCase) || key == "*space*")
                return ' ';
            if (key.Equals("comma", StringComparison.OrdinalIgnoreCase))
                return ',';
            if (key.Equals("period", StringComparison.OrdinalIgnoreCase) || key == ".")
                return '.';
            if (key == "?")
                return '?';

            // 如果是單一字元，直接回傳
            if (key.Length == 1)
                return key[0];

            // 若 key 為反引號包覆的字元（如 `-....`）或其他，嘗試移除包覆後再判斷
            var cleaned = key.Trim('`', '\'', '"').Trim();
            if (cleaned.Length == 1)
                return cleaned[0];

            return null;
        }
    }
}
