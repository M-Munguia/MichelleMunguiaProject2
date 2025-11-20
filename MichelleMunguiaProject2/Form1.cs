namespace MichelleMunguiaProject2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Label> letterLabels;    // The 7 displayed letters
        string currentWord = "";

        private void label1_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;

            if (!lbl.Enabled) return; // already used

            currentWord += lbl.Text.ToLower();
            BoxInput.Text = currentWord;

            lbl.Enabled = false;      // visually shows it’s used
            lbl.BackColor = Color.LightGray;
        }
    }
}
