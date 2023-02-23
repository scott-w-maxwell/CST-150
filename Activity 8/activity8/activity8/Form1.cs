namespace activity8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create a calorie Object from class
            Calories calorieObject = new Calories();

            try
            {
                // Parse data from TextBoxes
                int fatGrams = int.Parse(textBox1.Text);

                // Call object's methods to make calculations
                int fatCalories = calorieObject.fatCalories(fatGrams);

                // Update label to represent calculation of fat calories
                label3.Text = "Number of calories in fat: " + fatCalories.ToString();

            }
            catch(Exception ex)
            {
                // User's input was not valid. Alert user
                label3.Text = "Number of calories in fat: " + "Input is not valid";

            }

            try
            {
                // Parse data from TextBoxes
                int carbGrams = int.Parse(textBox2.Text);

                // Call object's methods to make calculations
                int carbCalories = calorieObject.carbCalories(carbGrams);

                // Update label to represent calculation of carb calories
                label4.Text = "Number of calories in carbs: " + carbCalories.ToString();

            }
            catch (Exception ex)
            {
                // User's input was not valid. Alert user
                label4.Text = "Number of calories in carbs: " + "Input is not valid";

            }

        }
    }
}

// Defining a class
class Calories
{
    // Class method to be used to calculate calories in grams of fat
    public int fatCalories(int fat)
    {
        return fat * 9;
    }
    
    // Class ethod to be used to calculate calories in grams of carbs
    public int carbCalories(int carb)
    {
        return carb * 4;
    }
}