using System.Diagnostics.CodeAnalysis;

namespace SeparateFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectFrom_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                InputFrom.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnSelectTo_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                InputTo.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void outputLog(string message = "", bool doNewLine = true)
        {
            if (doNewLine)
            {
                TextLog.AppendText("\r\n");
            }
            TextLog.AppendText(message);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            outputLog();

            string pathFrom = InputFrom.Text;
            string pathTo = InputTo.Text;

            if(Directory.Exists(pathFrom) == false) {
                outputLog("対象フォルダが存在しません。");
                return;
            }

            if(Directory.Exists(pathTo) == false)
            {
                outputLog("出力フォルダが存在しません。");
                return;
            }


            outputLog("対象フォルダの情報を取得します。");

            DirectoryInfo infoFrom = new DirectoryInfo(pathFrom);
            IEnumerable<FileInfo> files = infoFrom.EnumerateFiles(" ");

            string[] patterns = InputTargetFiles.Text.Split(';');

            outputLog("対象ファイル : ");
            foreach(string pattern in patterns)
            {
                outputLog(pattern, false);

                if (pattern == patterns.Last()) break;

                outputLog(", ", false);
            }

            foreach (string pattern in patterns)
            {
                files = files.Concat(infoFrom.EnumerateFiles(pattern));
            }

            if(files.Count() == 0)
            {
                outputLog("対象ファイルが存在しませんでした。");
                return;
            }

            outputLog("対象ファイル数 : " + files.Count().ToString());


            List<int> years = new List<int>();

            foreach (FileInfo file in files)
            {
                int year = file.LastWriteTime.Year;

                if(years.Contains(year) == false)
                {
                    years.Add(year);
                }
            }

            outputLog("対象年 : ");
            foreach(int year in years)
            {
                outputLog(year.ToString() + "年", false);

                if (year == years.Last()) break;

                outputLog(", ", false);
            }

            if (years.Count() > 1)
            {
                CheckCreateYearFolder.Checked = true;
                CheckCreateYearFolder.Enabled = false;
            }

            outputLog("西暦フォルダを作成 : " + (CheckCreateYearFolder.Checked ? "する" : "しない"));

            BtnExec.Enabled = true;
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            outputLog();

            outputLog("ファイルの振り分けを実行します。");

            DialogResult drDoExec = MessageBox.Show(
                "この操作は取り消すことができません。\n実行しますか？",
                "警告",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            if(drDoExec == DialogResult.Cancel)
            {
                outputLog("操作を取り消しました。");
                return;
            }


            string pathFrom = InputFrom.Text;
            string pathTo = InputTo.Text;

            outputLog("対象フォルダ : " + pathFrom);
            outputLog("出力フォルダ : " + pathTo);



            DirectoryInfo infoFrom = new DirectoryInfo(pathFrom);
            IEnumerable<FileInfo> files = infoFrom.EnumerateFiles(" ");

            string[] patterns = InputTargetFiles.Text.Split(';');

            foreach (string pattern in patterns)
            {
                files = files.Concat(infoFrom.EnumerateFiles(pattern));
            }


            if(CheckCreateYearFolder.Checked == true)
            {
                List<int> years = new List<int>();

                foreach (FileInfo file in files)
                {
                    int year = file.LastWriteTime.Year;

                    if (years.Contains(year) == false)
                    {
                        years.Add(year);
                    }
                }

                foreach (int year in years)
                {
                    if (Directory.Exists($"{pathTo}\\{year}年") == false)
                    {
                        Directory.CreateDirectory($"{pathTo}\\{year}年");
                    }
                }
            }


            outputLog("振り分けを開始します。");

            int clear = 0, skip = 0;

            foreach(FileInfo file in files)
            {
                string to = CheckCreateYearFolder.Checked ?
                            $"{pathTo}\\{file.LastWriteTime.Year}年\\{file.LastWriteTime.Month}月" :
                            $"{pathTo}\\{file.LastWriteTime.Month}月";

                if(Directory.Exists(to) == false)
                {
                    Directory.CreateDirectory(to);
                }

                try
                {
                    file.MoveTo($"{to}\\{file.Name}");
                }
                catch(IOException)
                {
                    outputLog($"{to}\\{file.Name}は既に存在しています。");
                    skip++;
                }
                catch(Exception ex)
                {
                    outputLog("予期せぬエラーが発生しました。");
                    outputLog(ex.ToString());
                    outputLog($"移動元 : {file.FullName}");
                    outputLog($"移動先 : {to}\\{file.Name}");
                    outputLog("処理を中断します。");
                }

                clear++;
            }

            outputLog("正常     : " + clear.ToString());
            outputLog("スキップ : " + skip.ToString());

            outputLog("振り分けが完了しました。");

            BtnExec.Enabled = false;
            CheckCreateYearFolder.Enabled = true;

            return;
        }

        private void Reset(object sender, EventArgs e)
        {
            if(BtnExec.Enabled == true)
            {
                BtnExec.Enabled = false;
                CheckCreateYearFolder.Enabled = true;

                outputLog();
                outputLog("値の変更を検知しました。再度確認を行ってください。");
            }
        }
    }
}