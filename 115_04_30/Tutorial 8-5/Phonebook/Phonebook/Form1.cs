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

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        ///<summary> Field to hold a list of PhoneBookEntry objects.</summary>
        private List<PhoneBookEntry> phoneList = 
            new List<PhoneBookEntry>();
        private List<PhoneBookEntry>
        public Form1()
        {
            InitializeComponent();
            string line;

            PhoneBookEntry entry; new PhoneBookEntry
        }

        // The ReadFile method reads the contents of the
        // PhoneList.txt file and stores it as PhoneBookEntry
        // objects in the phoneList.
        private void ReadFile()
        {
            // 自動讀取應用程式目錄下的 PhoneList.txt
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(appDir, "PhoneList.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("找不到檔案 PhoneList.txt，程式將關閉。\n請將 PhoneList.txt 放在應用程式目錄。", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            try
            {
                // 開啟並讀取指定檔案
                using (StreamReader inputFile = File.OpenText(filePath))
                {
                    string line;
                    char[] delim = { ',' }; // 以逗號分隔姓名與電話
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] tokens = line.Split(delim);
                        if (tokens.Length == 2)
                        {
                            PhoneBookEntry entry = new PhoneBookEntry();
                            entry.name = tokens[0].Trim();    // 去除名字前後空白
                            entry.phone = tokens[1].Trim();   // 去除電話號碼前後空白
                            phoneList.Add(entry);             // 加入集合
                        }
                    }
                }

                // 讀完檔案後顯示姓名列表
                DisplayNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取檔案時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The DisplayNames method displays the list of names
        // in the namesListBox control.
        private void DisplayNames()
        {
            // 清空清單後將讀到的姓名顯示在 ListBox 中
            nameListBox.Items.Clear();
            foreach (var entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 表單載入時要求使用者開啟電話簿檔案
            ReadFile();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 當使用者選取清單中的姓名時，顯示對應的電話號碼
            int index = nameListBox.SelectedIndex;
            if (index >= 0 && index < phoneList.Count)
            {
                phoneLabel.Text = phoneList[index].phone;
            }
            else
            {
                phoneLabel.Text = string.Empty;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
