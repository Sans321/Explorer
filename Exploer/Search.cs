using System;
using System.Windows.Forms;
using System.IO;//для DirectoryInfo
using System.Diagnostics;//для Process

namespace Exploer
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public void FindInDir(DirectoryInfo dir, string pattern, bool recursive)
        {
            foreach (FileInfo file in dir.GetFiles(pattern))
            {
                this._lbAnser.Items.Add(file.FullName);
            }
            if (recursive)
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    this.FindInDir(subdir, pattern, recursive);
                }
            }
        }
        public void FindFiles(string dir, string pattern)
        {
            this.FindInDir(new DirectoryInfo(dir), pattern, true);
        }
        private void _lbAnser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process.Start(this._lbAnser.SelectedItem.ToString());//пытаемся открыть файл программой по умолчанию
        }

        private void _tbFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void _tbView_TextChanged(object sender, EventArgs e)
        {

        }

        private void _bView_Click(object sender, EventArgs e)
        {
            if (this._fBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this._tbView.Text = this._fBrowserDialog.SelectedPath;
            }
        }

        private void _bFind_Click(object sender, EventArgs e)
        {
            try
            {
                _bClear_Click(sender, e);//очищаем поле с предыдущими результатами
                DirectoryInfo dir = new DirectoryInfo(this._tbView.Text);
                string file = this._tbFile.Text;
                FindInDir(dir, file, this._cbRecurs.Checked);//если нажат чекбокс, то поиск будет идти только в заданной папке
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _bClear_Click(object sender, EventArgs e)
        {
            this._lbAnser.Items.Clear();
        }

        private void _bClearAll_Click(object sender, EventArgs e)
        {
            this._tbFile.Text = "";
            this._tbView.Text = "";
            this._lbAnser.Items.Clear();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void Search_Load_1(object sender, EventArgs e)
        {

        }
    }
}
