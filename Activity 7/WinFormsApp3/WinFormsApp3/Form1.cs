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
            int userNum;

            // Try parsing string
            try
            {
                userNum = int.Parse(userInput);

                label1.Text = "Approximate value of pi after " + userInput + " terms";

                double pi = 4;
                //double denominator = 3;

                // For loop to approximate Pi to specified term (userNum)
                for (int count = 0; count <= userNum; count++)
                {
                    
                    // Calculate Denominator
                    double denominator = count * 2 + 3;

                    // Alternate Subtration and Addition
                    if (count%2 == 0)
                    {
                        pi -= (4 / denominator);
                    }
                    else
                    {
                        pi += (4 / denominator);
                    }

                    // Increment denominator
                    //denominator += 2;
                }

                // Convert result to String
                string endResult = pi.ToString();

                // Show the result to the user
                label5.Text = endResult;
            }
            catch (Exception ex)
            {
               
                // Print exception
                Console.WriteLine(ex);

                // Show user that their input was not valid.
                label5.Text = "Your input is not valid!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}