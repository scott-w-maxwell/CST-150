

class Dice{

    private int sides;

    public Dice(int sidesVal)
    {
        // Check if param is between 4 and 20 (inclusive)
        if(sidesVal >= 4 && sidesVal <= 20)
        {
            sides = sidesVal;
        }
        else
        {
            // Throw an error if param is not between 4 and 20
            throw new ArgumentOutOfRangeException("number", "Number must be between 4 and 20");
        }
    }

    public int rollDie()
    {
        // Create a new random object (from Random class in System namespace)
        Random random = new Random();

        // Generate a value between 1 and the set number of sides
        int randomVal = random.Next(1, sides + 1);

        return randomVal;
    }

    public static void Main(String[] args)
    {
        // Create two instances of Dice
        Dice die1 = new Dice(6);
        Dice die2 = new Dice(6);

        // Create variavles to save rolls
        int die1val = 0;
        int die2val = 0;

        // Roll Dice until snake eyes (1 and 1) are rolled
        int count = 0; // Used to count how many rolls are performed
        while(die1val != 1 || die2val != 1)
        {
            // Roll both dice
            die1val = die1.rollDie();
            die2val = die2.rollDie();

            // Report results
            Console.WriteLine("Die1: " + die1val + "\nDie2: " + die2val + "\n");

            // Increment counter
            count++;
        }

        // Once Snake Eyees are rolled
        if(die1val == 1 && die2val == 1)
        {
            Console.WriteLine("It took "+ count +" rolls to roll Snake Eyes");
        }
    }
}