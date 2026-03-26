using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 將搜尋按鈕的 Click 事件綁定到處理函式（介面在 Designer 已建立）
            this.searchButton.Click += new EventHandler(this.searchButton_Click);
        }

        

       

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // To hold the average score
            int numAboveAverage;    // Number of above average scores
            int numBelowAverage;    // Number of below average scores

            // Create a List to hold the scores.
            List<int> scoresList = new List<int>();

            // Read the scores from the file into the List.
            ReadScores(scoresList);

            // Display the scores.
            DisplayScores(scoresList);

            // Display the average score.
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // Display the number of above average scores.
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // Display the number of below average scores.
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        // 新增：搜尋按鈕的處理函式
        // 功能：從列表中搜尋使用者輸入的分數
        // 輸入：使用者在 searchScoreTextBox 中輸入的分數（文字）
        // 行為：若找到則在 searchResultLabel 顯示位置（以 1 為起始）；若找不到則顯示「分數不存在」
        // 註：此方法不會直接讀取檔案，而是搜尋已顯示在 testScoresListBox 中的項目，確保先按「取得分數」載入資料
        private void searchButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入並嘗試轉為整數
            string input = this.searchScoreTextBox.Text.Trim();
            if (!int.TryParse(input, out int targetScore))
            {
                // 輸入無效時顯示提示（繁體中文）
                this.searchResultLabel.Text = "請輸入有效整數分數";
                return;
            }

            // 在 ListBox 中搜尋（以文字比較為主），找到第一個符合項目即停止
            for (int i = 0; i < this.testScoresListBox.Items.Count; i++)
            {
                string itemText = this.testScoresListBox.Items[i].ToString();
                if (int.TryParse(itemText, out int itemScore) && itemScore == targetScore)
                {
                    // 找到後顯示位置（以 1 為起始）
                    this.searchResultLabel.Text = $"找到，位置：{i + 1}";
                    return;
                }
            }

            // 若迴圈結束表示未找到
            this.searchResultLabel.Text = "分數不存在";
        }

        // 讀取分數檔案並將數值加入傳入的 List
        // 檔案預設為執行目錄下的 TestScores.txt
        private void ReadScores(List<int> scoresList)
        {
            scoresList.Clear();
            string filePath = Path.Combine(Application.StartupPath, "TestScores.txt");
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("找不到分數檔案：" + filePath, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (int.TryParse(line.Trim(), out int score))
                    {
                        scoresList.Add(score);
                    }
                    // 無效行會被忽略
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取分數時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 將分數顯示到 ListBox
        private void DisplayScores(List<int> scoresList)
        {
            this.testScoresListBox.Items.Clear();
            foreach (int score in scoresList)
            {
                this.testScoresListBox.Items.Add(score.ToString());
            }
        }

        // 計算平均值並回傳（若無資料回傳 0）
        private double Average(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0.0;

            double sum = 0;
            foreach (int s in scoresList)
                sum += s;

            return sum / scoresList.Count;
        }

        // 計算高於指定平均值的人數
        private int AboveAverage(List<int> scoresList, double averageScore)
        {
            if (scoresList == null)
                return 0;

            int count = 0;
            foreach (int s in scoresList)
            {
                if (s > averageScore)
                    count++;
            }
            return count;
        }

        // 計算低於平均的人數（內部會呼叫 Average 計算平均）
        private int BelowAverage(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            double avg = Average(scoresList);
            int count = 0;
            foreach (int s in scoresList)
            {
                if (s < avg)
                    count++;
            }
            return count;
        }
    }
}
