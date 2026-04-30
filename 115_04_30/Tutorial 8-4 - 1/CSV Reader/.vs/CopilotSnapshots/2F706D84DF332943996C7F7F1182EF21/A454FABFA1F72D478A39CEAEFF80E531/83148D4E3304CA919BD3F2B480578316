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
using System.Diagnostics;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 清除舊資料，準備顯示新的平均數
            this.averagesListBox.Items.Clear();

            // 嘗試讀取名為 "Grade.csv" 的 CSV 檔案，計算每位學生多科成績的平均並顯示於清單
            try
            {
                using (StreamReader inputFile = File.OpenText("Grade.csv"))
                {
                    char[] delim = { ',' };
                    string line;

                    double totalOfAverages = 0.0; // 用於計算全班平均（每位學生平均的總和）
                    int studentCount = 0;

                    while ((line = inputFile.ReadLine()) != null)
                    {
                        // 以逗號分割欄位
                        string[] fields = line.Split(delim);

                        // 嘗試找出學生姓名（如果格式為:系別,學號,姓名,分數1,分數2,...）則姓名為 fields[2]
                        string studentName = fields.Length >= 3 ? fields[2] : (fields.Length > 0 ? fields[0] : "(無名)");

                        // 從第 4 欄 (index 3) 開始視為成績欄位
                        List<double> scores = new List<double>();
                        for (int i = 3; i < fields.Length; i++)
                        {
                            double v;
                            if (double.TryParse(fields[i], out v))
                            {
                                scores.Add(v);
                            }
                        }

                        if (scores.Count > 0)
                        {
                            double average = scores.Average();
                            this.averagesListBox.Items.Add($"{studentName} 的平均分數為 {average:F2}");

                            totalOfAverages += average;
                            studentCount++;
                        }
                        else
                        {
                            // 若找不到任何可解析的成績欄位，顯示提示
                            this.averagesListBox.Items.Add($"{studentName} 無可計算的成績欄位");
                        }
                    }

                    // 在讀取完所有學生後，若有至少一位學生則計算並顯示全班平均
                    if (studentCount > 0)
                    {
                        double classAverage = totalOfAverages / studentCount;
                        this.averagesListBox.Items.Add("---------------------------");
                        this.averagesListBox.Items.Add($"全班平均分數為 {classAverage:F2}");
                    }
                    else
                    {
                        this.averagesListBox.Items.Add("沒有可計算平均值的學生成績。");
                    }
                }
            }
            catch (Exception ex)
            {
                // 顯示繁體中文錯誤訊息
                MessageBox.Show("發生錯誤：" + ex.Message);
            }
        }

        // 結束按鈕事件：關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
