using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Chemestry.Models;
using Newtonsoft.Json;

namespace Chemestry
{
    public partial class DictionaryForm : Form
    {
        private List<PhraseModel> _phrases;

        public DictionaryForm()
        {
            _phrases = new List<PhraseModel>();
            InitializeComponent();
            Width = Constants.BASE_FORM_WIDTH;
            Height = Constants.BASE_FORM_HEIGHT;
            Phrases = InitializePhrazes();
            phraseLstBox.DataSource = Phrases;
        }

        public string SearchTerm { get; set; }

        public List<PhraseModel> Phrases
        {
            get => !string.IsNullOrWhiteSpace(SearchTerm) && SearchTerm.Length > 3
                ? _phrases.Where(x => x.Title.ToLower().Contains(SearchTerm.ToLower())).ToList()
                : _phrases;
            set => _phrases = value;
        }

        private void phraseLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phraseLstBox.SelectedItem is PhraseModel phrase)
            {
                descriptionRTxtBox.Text = string.Empty;
                descriptionRTxtBox.DeselectAll();

                descriptionRTxtBox.Text = phrase.Title;
                descriptionRTxtBox.Select(0, phrase.Title.Length);
                descriptionRTxtBox.SelectionFont =
                    new Font(descriptionRTxtBox.SelectionFont.FontFamily, 18, FontStyle.Bold);
                descriptionRTxtBox.AppendText(Environment.NewLine + Environment.NewLine);
                descriptionRTxtBox.DeselectAll();

                descriptionRTxtBox.AppendText(phrase.Description);
                descriptionRTxtBox.Select(phrase.Title.Length + 2, phrase.Description.Length);
                descriptionRTxtBox.SelectionFont =
                    new Font(descriptionRTxtBox.SelectionFont.FontFamily, 12, FontStyle.Regular);
                descriptionRTxtBox.DeselectAll();
            }
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            SearchTerm = searchTxtBox.Text;
            phraseLstBox.BeginUpdate();
            phraseLstBox.DataSource = Phrases;
            phraseLstBox.EndUpdate();
        }

        private static List<PhraseModel> InitializePhrazes()
        {
            var phrases = new List<PhraseModel>();

            if (File.Exists(Constants.PATH_DICT))
            {
                var data = File.ReadAllText(Constants.PATH_DICT);
                try
                {
                    phrases = JsonConvert.DeserializeObject<List<PhraseModel>>(data);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Файл словника пошкодженно.", @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return phrases;
        }
    }
}