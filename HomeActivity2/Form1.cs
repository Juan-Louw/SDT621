namespace HomeActivity2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckResults_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtGeuss1.Text);
                int num2 = Convert.ToInt32(txtGeuss2.Text);
                int num3 = Convert.ToInt32(txtGeuss3.Text);

                int winNum1 = random.Next(1, 11);
                int winNum2 = random.Next(1, 11);
                int winNum3 = random.Next(1, 11);

                listBox1.Items.Clear();
                listBox1.Items.Add($"Winning numbers: {winNum1}, {winNum2}, {winNum3}");

                int matches = 0;

                if (num1 == winNum1 || num1 == winNum2 || num1 == winNum3) matches++;
                if (num2 == winNum1 || num2 == winNum2 || num2 == winNum3) matches++;
                if (num3 == winNum1 || num3 == winNum2 || num3 == winNum3) matches++;

                if (matches == 3)
                {
                    MessageBox.Show("Jackpot Winner!");
                }
                else if (matches == 2)
                {
                    MessageBox.Show("Small Prize!");
                }
                else if (matches == 1) 
                { 
                    MessageBox.Show("Consolation Prize!");
                }
                else
                {
                    MessageBox.Show("No win");
                }

            }
            catch 
            { 
                MessageBox.Show("Please enter valid numbers between 1 and 10.");
            }
        }
    }
}
