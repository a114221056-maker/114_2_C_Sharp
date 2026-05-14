using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private decimal balance = 0m;
        private decimal lastWinnings = 0m;
        private readonly Random random = new Random();

        // 統計
        private int totalSpins = 0;
        private int totalWins = 0;
        private decimal totalDeposited = 0m;

        // 轉輪動畫用
        private Timer reelTimer1;
        private Timer reelTimer2;
        private Timer reelTimer3;
        private int tick1, tick2, tick3;
        private int stopAt1, stopAt2, stopAt3;
        private int final1, final2, final3;
        private decimal currentBet = 0m;
        private bool spinning = false;

        // 水果圖片集合
        private readonly List<Image> fruitImages = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            InitializeFruitImages();
            InitializeReelTimers();
            UpdateDisplay();
        }

        private void InitializeFruitImages()
        {
            // 從 Resources 載入 10 張水果圖（順序任意）
            try
            {
                fruitImages.Add(Properties.Resources.Apple);
                fruitImages.Add(Properties.Resources.Banana);
                fruitImages.Add(Properties.Resources.Cherries);
                fruitImages.Add(Properties.Resources.Grapes);
                fruitImages.Add(Properties.Resources.Lemon);
                fruitImages.Add(Properties.Resources.Lime);
                fruitImages.Add(Properties.Resources.Orange);
                fruitImages.Add(Properties.Resources.Pear);
                fruitImages.Add(Properties.Resources.Strawberry);
                fruitImages.Add(Properties.Resources.Watermelon);
            }
            catch
            {
                // 若 Resources 中缺圖，fruitImages 保持空，可由 imageList1 或背景色代替
            }
        }

        private void InitializeReelTimers()
        {
            reelTimer1 = new Timer { Interval = 80 };
            reelTimer2 = new Timer { Interval = 80 };
            reelTimer3 = new Timer { Interval = 80 };

            reelTimer1.Tick += ReelTimer1_Tick;
            reelTimer2.Tick += ReelTimer2_Tick;
            reelTimer3.Tick += ReelTimer3_Tick;
        }

        private void button_deposit_Click(object sender, EventArgs e)
        {
            if (spinning)
                return;

            if (int.TryParse(textBox_deposit.Text, out int depositInt) && depositInt > 0)
            {
                balance += depositInt;
                totalDeposited += depositInt;
                textBox_deposit.Clear();
                UpdateDisplay();
                MessageBox.Show($"存入 NT${depositInt:F2} 成功！", "存入確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("請輸入正整數金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (spinning)
                return;

            if (balance <= 0m)
            {
                MessageBox.Show("餘額不足，請先存入金額", "餘額不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string betText = comboBox_bet.SelectedItem?.ToString() ?? "$1";
            if (!decimal.TryParse(betText.TrimStart('$'), out decimal betAmount))
                betAmount = 1m;

            if (betAmount <= 0m)
            {
                MessageBox.Show("下注金額不正確", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (balance < betAmount)
            {
                MessageBox.Show("餘額不足，請選擇較小的下注金額", "餘額不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 扣款並開始動畫
            balance -= betAmount;
            currentBet = betAmount;
            lastWinnings = 0m;
            totalSpins++;
            spinning = true;
            button1.Enabled = false;
            button_deposit.Enabled = false;
            comboBox_bet.Enabled = false;

            // 決定每個轉輪的停止時間（Tick 次數）
            tick1 = tick2 = tick3 = 0;
            int base1 = random.Next(12, 20);
            stopAt1 = base1;
            stopAt2 = base1 + random.Next(8, 20);
            stopAt3 = stopAt2 + random.Next(8, 26);

            // 啟動所有計時器
            reelTimer1.Start();
            reelTimer2.Start();
            reelTimer3.Start();

            UpdateBalanceLabel(); // 先更新被扣除後的餘額顯示
        }

        private void ReelTimer1_Tick(object sender, EventArgs e)
        {
            tick1++;
            int idx = GetRandomIndex();
            DisplayIndexInPictureBox(idx, pictureBox1);

            if (tick1 >= stopAt1)
            {
                reelTimer1.Stop();
                final1 = idx;
                TryStopFinished();
            }
        }

        private void ReelTimer2_Tick(object sender, EventArgs e)
        {
            tick2++;
            int idx = GetRandomIndex();
            DisplayIndexInPictureBox(idx, pictureBox2);

            if (tick2 >= stopAt2)
            {
                reelTimer2.Stop();
                final2 = idx;
                TryStopFinished();
            }
        }

        private void ReelTimer3_Tick(object sender, EventArgs e)
        {
            tick3++;
            int idx = GetRandomIndex();
            DisplayIndexInPictureBox(idx, pictureBox3);

            if (tick3 >= stopAt3)
            {
                reelTimer3.Stop();
                final3 = idx;
                TryStopFinished();
            }
        }

        private void TryStopFinished()
        {
            if (reelTimer1.Enabled || reelTimer2.Enabled || reelTimer3.Enabled)
                return;

            // 計算獲勝
            bool win = false;
            if (final1 == final2 && final2 == final3)
            {
                lastWinnings = currentBet * 10m; // 三個相同 x10
                win = true;
            }
            else if (final1 == final2 || final2 == final3 || final1 == final3)
            {
                lastWinnings = currentBet * 3m; // 任二相同 x3
                win = true;
            }
            else
            {
                lastWinnings = 0m;
            }

            if (win)
                totalWins++;

            balance += lastWinnings;
            UpdateDisplay();

            // 恢復按鈕
            spinning = false;
            button1.Enabled = true;
            button_deposit.Enabled = true;
            comboBox_bet.Enabled = true;
        }

        private int GetMaxImageCount()
        {
            if (fruitImages != null && fruitImages.Count > 0)
                return fruitImages.Count;
            return (imageList1 != null && imageList1.Images.Count > 0) ? imageList1.Images.Count : 0;
        }

        private int GetRandomIndex()
        {
            int max = GetMaxImageCount();
            if (max == 0)
                return 0;
            return random.Next(0, max);
        }

        private void DisplayIndexInPictureBox(int index, PictureBox pictureBox)
        {
            if (fruitImages != null && index >= 0 && index < fruitImages.Count)
            {
                pictureBox.Image = fruitImages[index];
                pictureBox.BackColor = Color.Transparent;
            }
            else if (imageList1 != null && imageList1.Images.Count > index)
            {
                pictureBox.Image = imageList1.Images[index];
                pictureBox.BackColor = Color.Transparent;
            }
            else
            {
                pictureBox.Image = null;
                pictureBox.BackColor = Color.Khaki;
            }
            pictureBox.Refresh();
        }

        private void UpdateDisplay()
        {
            UpdateBalanceLabel();
            UpdateStatistics();
        }

        private void UpdateBalanceLabel()
        {
            label_balance.Text = $"餘額：NT${balance:F2}";
            label_lastWin.Text = $"本次獲得：NT${lastWinnings:F2}";
        }

        private void UpdateStatistics()
        {
            label_totalSpins.Text = $"累計旋轉：{totalSpins}次";
            label_winCount.Text = $"累計中獎：{totalWins}次";
            double winRate = totalSpins > 0 ? (double)totalWins / totalSpins * 100.0 : 0.0;
            label_winRate.Text = $"勝率：{winRate:F2}%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 顯示結算資訊後關閉主表單
            decimal netGain = balance - totalDeposited;
            string profitLine;
            if (netGain < 0m)
            {
                profitLine = $"虧損：${Math.Abs(netGain):N2}";
            }
            else
            {
                profitLine = $"獲利：${netGain:N2}";
            }

            string msg = string.Format(
                "累計存入：${0:N2}\r\n目前餘額：${1:N2}\r\n{2}\r\n\r\n旋轉次數：{3} 次\t中獎次數：{4} 次",
                totalDeposited,
                balance,
                profitLine,
                totalSpins,
                totalWins);

            MessageBox.Show(msg, "結算", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
