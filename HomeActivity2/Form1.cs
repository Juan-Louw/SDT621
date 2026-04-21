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

                int win1 = random.Next(1, 11);
                int win2 = random.Next(1, 11);
                int win3 = random.Next(1, 11);

                listBox1.Items.Clear();
                listBox1.Items.Add($"Winning numbers: {win1}, {win2}, {win3}");

                int matches = 0;

                if (num1 == win1 || num1 == win2 || num1 == win3) matches++;
                if (num2 == win1 || num2 == win2 || num2 == win3) matches++;
                if (num3 == win1 || num3 == win2 || num3 == win3) matches++;

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
