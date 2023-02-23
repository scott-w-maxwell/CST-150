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
            try
            {
                userNum = double.Parse(userInput);

                // number of kilometers in a mile
                double kmh = 1.609344;

                // Multiply 
                double result = userNum * kmh;

                // New! Round to three decimal places
                result = Math.Round(result, 3);

                // Convert result to String
                string endResult = result.ToString();

                // Show the result to the user
                label5.Text = endResult + " KM/h";
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
    }
}