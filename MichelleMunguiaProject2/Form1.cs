using MichelleMunguiaProject2.Controller;
using MichelleMunguiaProject2.Model;

namespace MichelleMunguiaProject2;

/// <summary>
/// class for main form
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class MainForm : Form
{
    private readonly WordController _controller;
    private List<Label> _letterLabels;

    private int _remainingTime = 60;
    private HashSet<string> _usedWords = new();
    private string currentWord = "";

    /// <summary>
    ///     Initializes a new instance of the <see cref="MainForm" /> class.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();
        _controller = new WordController();
        _letterLabels = new List<Label> { label1, label2, label3, label4, label5, label6, label7 };
        LoadLettersToLabels();
        StartRound();
    }


    private void StartRound()
    {
        _remainingTime = 60;
        labelTime.Text = _remainingTime.ToString();
        gameTimer.Start();
    }

    private void LoadLettersToLabels()
    {
        var letters = _controller.CurrentLetters;

        label1.Text = letters[0].ToString();
        label2.Text = letters[1].ToString();
        label3.Text = letters[2].ToString();
        label4.Text = letters[3].ToString();
        label5.Text = letters[4].ToString();
        label6.Text = letters[5].ToString();
        label7.Text = letters[6].ToString();

        BoxInput.Clear();
    }

    private void Letter_Click(object sender, EventArgs e)
    {
        var lbl = sender as Label;

        if (lbl != null && lbl.Enabled)
        {
            BoxInput.Text += lbl.Text;
            lbl.Enabled = false;
            lbl.ForeColor = Color.Gray;
        }
    }

    private void buttonSubmit_Click(object sender, EventArgs e)
    {
        var word = BoxInput.Text.Trim();

        var elapsedTime = TimeSpan.FromSeconds(60 - _remainingTime);

        var result = _controller.SubmitWord(word, elapsedTime);

        MessageBox.Show(result.message, "Word Result",
            MessageBoxButtons.OK,
            result.isValid ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

        BoxInput.Clear();
        ResetLetterTiles();
    }


    private void ResetLetterTiles()
    {
        foreach (var lbl in new[] { label1, label2, label3, label4, label5, label6, label7 })
        {
            lbl.Enabled = true;
            lbl.ForeColor = Color.White;
        }

        BoxInput.Clear();
    }

    private void EndRound()
    {
        MessageBox.Show("Time's up!", "Round Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

        var totalPoints = 0;
        var summary = "Valid words:\n";

        foreach (var attempt in _controller.CurrentRound.Attempts.OfType<ValidAttempt>())
        {
            summary += $"{attempt.Word} - {attempt.Points} points\n";
            totalPoints += attempt.Points;
        }

        summary += $"\nTotal Score: {totalPoints}";

        MessageBox.Show(summary, "Round Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

        _controller.StartNewRound();
        LoadLettersToLabels();
        StartRound();
    }

    public void GameTimer(object sender, EventArgs e)
    {
        if (_remainingTime > 0)
        {
            _remainingTime--;
            labelTime.Text = _remainingTime.ToString();
        }
        else
        {
            gameTimer.Stop();
            EndRound();
        }
    }
}