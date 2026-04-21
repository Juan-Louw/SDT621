namespace HomeActivity1
{
    public partial class Form1 : Form
    {
        readonly Random random = new Random();
        int winNumber;
        int attemptsLeft;
        const int MaxAttempts = 3;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame() 
        {
            winNumber = random.Next(1, 21);
            attemptsLeft = MaxAttempts;
            lblAttempts.Text = $"Attempts left: {attemptsLeft}";
            lblResults.Text = string.Empty;
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = int.Parse(txtNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number between 1 and 20.");
                return;
            }

            if (number < 1 || number > 20)
            {
                MessageBox.Show("Please enter a valid number between 1 and 20.");
                return;
            }

            if (number == winNumber)
            {
                lblResults.Text = "Jackpot Winner!";
                btnPlay.Enabled = false;
            }
            else
            {
                attemptsLeft--;
                if (attemptsLeft > 0)
                {
                    lblResults.Text = "Try Again!";
                    lblAttempts.Text = $"Attempts left: {attemptsLeft}";
                }
                else
                {
                    lblResults.Text = $"No attempts left. Winning number was {winNumber}.";
                    lblAttempts.Text = "Attempts left: 0";
                    btnPlay.Enabled = false;
                }
            }
        }
    }
}
