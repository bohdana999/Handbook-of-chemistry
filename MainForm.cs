using System;
using System.Windows.Forms;

namespace Chemestry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tablesBtn_Click(object sender, EventArgs e)
        {
            var tablesForm = new TablesForm();
            tablesForm.Show();
        }

        private void reactionsBtn_Click(object sender, EventArgs e)
        {
            var reactionsForm = new ReactionsForm();
            reactionsForm.Show();
        }

        private void dictionaryBtn_Click(object sender, EventArgs e)
        {
            var dictionaryForm = new DictionaryForm();
            dictionaryForm.Show();
        }
    }
}
