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
                outputLog("�Ώۃt�H���_�����݂��܂���B");
                return;
            }

            if(Directory.Exists(pathTo) == false)
            {
                outputLog("�o�̓t�H���_�����݂��܂���B");
                return;
            }


            outputLog("�Ώۃt�H���_�̏����擾���܂��B");

            DirectoryInfo infoFrom = new DirectoryInfo(pathFrom);
            IEnumerable<FileInfo> files = infoFrom.EnumerateFiles(" ");

            string[] patterns = InputTargetFiles.Text.Split(';');

            outputLog("�Ώۃt�@�C�� : ");
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
                outputLog("�Ώۃt�@�C�������݂��܂���ł����B");
                return;
            }

            outputLog("�Ώۃt�@�C���� : " + files.Count().ToString());


            List<int> years = new List<int>();

            foreach (FileInfo file in files)
            {
                int year = file.LastWriteTime.Year;

                if(years.Contains(year) == false)
                {
                    years.Add(year);
                }
            }

            outputLog("�Ώ۔N : ");
            foreach(int year in years)
            {
                outputLog(year.ToString() + "�N", false);

                if (year == years.Last()) break;

                outputLog(", ", false);
            }

            if (years.Count() > 1)
            {
                CheckCreateYearFolder.Checked = true;
                CheckCreateYearFolder.Enabled = false;
            }

            outputLog("����t�H���_���쐬 : " + (CheckCreateYearFolder.Checked ? "����" : "���Ȃ�"));

            BtnExec.Enabled = true;
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            outputLog();

            outputLog("�t�@�C���̐U�蕪�������s���܂��B");

            DialogResult drDoExec = MessageBox.Show(
                "���̑���͎��������Ƃ��ł��܂���B\n���s���܂����H",
                "�x��",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            if(drDoExec == DialogResult.Cancel)
            {
                outputLog("������������܂����B");
                return;
            }


            string pathFrom = InputFrom.Text;
            string pathTo = InputTo.Text;

            outputLog("�Ώۃt�H���_ : " + pathFrom);
            outputLog("�o�̓t�H���_ : " + pathTo);



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
                    if (Directory.Exists($"{pathTo}\\{year}�N") == false)
                    {
                        Directory.CreateDirectory($"{pathTo}\\{year}�N");
                    }
                }
            }


            outputLog("�U�蕪�����J�n���܂��B");

            int clear = 0, skip = 0;

            foreach(FileInfo file in files)
            {
                string to = CheckCreateYearFolder.Checked ?
                            $"{pathTo}\\{file.LastWriteTime.Year}�N\\{file.LastWriteTime.Month}��" :
                            $"{pathTo}\\{file.LastWriteTime.Month}��";

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
                    outputLog($"{to}\\{file.Name}�͊��ɑ��݂��Ă��܂��B");
                    skip++;
                }
                catch(Exception ex)
                {
                    outputLog("�\�����ʃG���[���������܂����B");
                    outputLog(ex.ToString());
                    outputLog($"�ړ��� : {file.FullName}");
                    outputLog($"�ړ��� : {to}\\{file.Name}");
                    outputLog("�����𒆒f���܂��B");
                }

                clear++;
            }

            outputLog("����     : " + clear.ToString());
            outputLog("�X�L�b�v : " + skip.ToString());

            outputLog("�U�蕪�����������܂����B");

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
                outputLog("�l�̕ύX�����m���܂����B�ēx�m�F���s���Ă��������B");
            }
        }
    }
}