namespace fizzbuzz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*FizzBuzz Ex
             If i is a multiple of both 3 and 5, print fizzbuzz
            If is a multiple of 3 but not 5, print fizz
            If is multiple of 5 but not 3 print buzz
            If is neither, just print the value*/
            int value;
            int mcm3y5 = 15;
            int mcm3 = 27;
            int mcm5 = 25;

            Console.WriteLine("Insert the Number");
            value =  int.Parse(Console.ReadLine());
           

            if (mcm3y5 % value == 0){
                Console.WriteLine("FizzBuzz");   
            }

            if (mcm3 % value == 0){
                Console.WriteLine("Fizz");
            }

            if (mcm5 % value == 0)
            {
                Console.WriteLine("Buzz");
            }


            if (mcm3y5 % value != 0){
                Console.WriteLine("Not FizzBuzz or anything");
            }
            
        }
    }
}