using MichelleMunguiaProject2.Controller;

namespace MichelleMunguiaProject2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            controller = new WordController();
            LoadLettersToLabels();
        }
        private void LoadLettersToLabels()
        {
            var letters = controller.CurrentLetters;

            // Assign letters to labels
            label1.Text = letters[0].ToString();
            label2.Text = letters[1].ToString();
            label3.Text = letters[2].ToString();
            label4.Text = letters[3].ToString();
            label5.Text = letters[4].ToString();
            label6.Text = letters[5].ToString();
            label7.Text = letters[6].ToString();

            // Reset label states so they are enabled and visible
            //ResetLabelStates();
            BoxInput.Clear();
        }
        private HashSet<string> usedWords = new HashSet<string>();
        List<Label> letterLabels;    // The 7 displayed letters
        string currentWord = "";
        private WordController controller;

        private void Letter_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null && lbl.Enabled)
            {
                BoxInput.Text += lbl.Text;
                lbl.Enabled = false;             // cannot use again
                lbl.ForeColor = Color.Gray;      // visually used
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string word = BoxInput.Text.Trim();
            //var result = controller.SubmitWord(word);
            //MessageBox.Show(result.message);
            //ResetLabelStates();
            BoxInput.Clear();
        }
        

        //private void ResetLetterTiles()
        //{
          //  foreach (var lbl in new[] { label1, label2, label3, label4, label5, label6, label7 })
            //{
              //  lbl.Enabled = true;
                //lbl.ForeColor = Color.Black;
            //}

            //BoxInput.Clear();
        //}
    }
}

