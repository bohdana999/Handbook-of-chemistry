using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Chemestry.Models;
using Newtonsoft.Json;

namespace Chemestry
{
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();
            Tables = InitializeTables();
            Width = Constants.BASE_FORM_WIDTH;
            Height = Constants.BASE_FORM_HEIGHT;
            tablesLstBox.DataSource = Tables;
        }

        public List<TableModel> Tables { get; set; }

        private static List<TableModel> InitializeTables()
        {
            var list = new List<TableModel>();

            if (File.Exists(Constants.PATH_TABLES))
            {
                var data = File.ReadAllText(Constants.PATH_TABLES);
                try
                {
                    list = JsonConvert.DeserializeObject<List<TableModel>>(data);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Файл таблиць пошкодженно.", @"Помилка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            return list;
        }

        private void tablesLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesLstBox.SelectedItem is TableModel table)
            {
                tablePic.ImageLocation = table.PathToPicture;
                tablePic.SizeMode = table.SizeMode;
            }
        }
    }
}