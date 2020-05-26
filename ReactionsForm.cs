using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Chemestry.Models;
using Newtonsoft.Json;

namespace Chemestry
{
    public partial class ReactionsForm : Form
    {
        public ReactionsForm()
        {
            InitializeComponent();
            Reactions = InitializeReactions();
            Width = Constants.BASE_FORM_WIDTH;
            Height = Constants.BASE_FORM_HEIGHT;
            reactionLstBox.DataSource = Reactions;
        }

        public List<ReactionModel> Reactions { get; set; }

        private static List<ReactionModel> InitializeReactions()
        {
            var list = new List<ReactionModel>();

            if (File.Exists(Constants.PATH_REACT))
            {
                var data = File.ReadAllText(Constants.PATH_REACT);
                try
                {
                    list = JsonConvert.DeserializeObject<List<ReactionModel>>(data);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Файл реакцій пошкодженно.", @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return list;
        }

        private void reactionLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reactionLstBox.SelectedItem != null && reactionLstBox.SelectedItem.GetType() == typeof(ReactionModel))
            {
                var reaction = (ReactionModel)reactionLstBox.SelectedItem;
                reactionPic.ImageLocation = reaction.PathToPicture;
            }
        }
    }
}
