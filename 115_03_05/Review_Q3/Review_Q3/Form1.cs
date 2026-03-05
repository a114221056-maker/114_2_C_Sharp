using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Review_Q3
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int[] currentNumbers = new int[6];
        private int[] selectedWinning = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            currentNumbers = GenerateNumbers();
            var labels = new System.Windows.Forms.Label[] { lblNumber1, lblNumber2, lblNumber3, lblNumber4, lblNumber5, lblNumber6 };
            for (int i = 0; i < 6; i++)
            {
                labels[i].Text = currentNumbers[i].ToString();
            }
            lblResult.Text = "已產生號碼";
        }

        private int[] GenerateNumbers()
        {
            var nums = Enumerable.Range(1, 49).OrderBy(x => rnd.Next()).Take(6).OrderBy(x => x).ToArray();
            return nums;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            var path = openFileDialog1.FileName;
            try
            {
                var lines = File.ReadAllLines(path)
                                .Where(l => !string.IsNullOrWhiteSpace(l))
                                .Select(l => l.Trim())
                                .ToArray();
                lstWinningNumbers.Items.Clear();
                foreach (var ln in lines)
                {
                    lstWinningNumbers.Items.Add(ln);
                }
                lblResult.Text = "已載入開獎號碼";
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取檔案失敗: " + ex.Message);
            }
        }

        private void lstWinningNumbers_DoubleClick(object sender, EventArgs e)
        {
            if (lstWinningNumbers.SelectedItem == null) return;
            var text = lstWinningNumbers.SelectedItem.ToString();
            var parts = text.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var nums = parts.Select(p => {
                int v;
                return int.TryParse(p, out v) ? (int?)v : null;
            }).Where(x => x.HasValue).Select(x => x.Value).ToArray();
            if (nums.Length >= 6)
            {
                selectedWinning = nums.Take(6).OrderBy(x => x).ToArray();
                lblResult.Text = "已選擇開獎號碼: " + string.Join(",", selectedWinning);
            }
            else
            {
                MessageBox.Show("選取的行沒有足夠的號碼 (至少6個)");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (currentNumbers == null || currentNumbers.Length < 6)
            {
                MessageBox.Show("請先產生號碼");
                return;
            }
            if (selectedWinning == null)
            {
                MessageBox.Show("請先從列表中選取開獎號碼行 (雙擊)");
                return;
            }
            var match = currentNumbers.Intersect(selectedWinning).Count();
            lblResult.Text = $"中獎比對結果\n您的號碼: {string.Join(",", currentNumbers)}\n開獎號碼: {string.Join(",", selectedWinning)}\n相同數量: {match} 個";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
