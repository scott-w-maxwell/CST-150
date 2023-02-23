namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;

            // Declare variable to output from string
            double userNum;

            // Try parsing string
            if (double.TryParse(userInput, out userNum))
            {
                // number of kilometers in a mile
                double kmh = 1.609344;

                // Multiply 
                double result = userNum * kmh;

                // Convert result to String
                string endResult = result.ToString();

                // Show the result to the user
                label4.Text = endResult;
            }
            else
            {
                // Show user that their input was not valid.
                label4.Text = "Invalid Input: Not a number";
            }
        }
    }
}