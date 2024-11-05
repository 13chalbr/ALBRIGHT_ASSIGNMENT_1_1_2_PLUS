namespace ALBRIGHT_ASSIGNMENT_1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MSSA CCAD16 (CHRIS ALBRIGHT)
            // 05NOV2024 -- DAY 2

            // 1.1.2. SOLUTION:

            Console.WriteLine("Please enter an interger:");
            double integer_Double = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nNow please enter a decimal (float/double):");
            double decimal_Double = Convert.ToDouble(Console.ReadLine());
            
            double min_Double = Math.Min(integer_Double, decimal_Double);
            double max_Double = Math.Max(integer_Double, decimal_Double);

            Console.WriteLine("\nThanks.");
            Console.WriteLine("\nThe MIN value is " + min_Double);
            Console.WriteLine("\nThe MAX value is " + max_Double);

            //--------------------------------------------------------------------------------------------------------------

            // 1.1.3 SOLUTION

            Console.WriteLine("\nThe sum of your two provided numbers is "+(integer_Double+decimal_Double));

            //--------------------------------------------------------------------------------------------------------------

            // 1.1.4 SOLUTION

            Console.WriteLine("\nThe quotient of dividing "+decimal_Double+" into "+integer_Double+" is the following: ");
            Console.WriteLine("\n"+integer_Double+" / "+decimal_Double+" == "+(integer_Double / decimal_Double));
            


        }

    }
}
