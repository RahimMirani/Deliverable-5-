namespace Deliverable__5_
{
    internal class Program
    {

        static int[] Method1(int array_len)
        {
            Random random = new Random();   
            int[] Myarray = new int[array_len];
            for(int i = 0; i < array_len; i++)
            {
                Myarray[i] = random.Next(10, 50);
            }
            return Myarray;
        }

        static int sum(int[] array) 
        {
            int sum = 0;    
            foreach(int i in array) 
            {
                sum += i;   
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 & 15");
            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input >= 5 && input <= 15)
                {
                    int[] sample_array = Method1(input);

                    Console.WriteLine("The elements in the random array are:");
                    foreach (int i in sample_array)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("The sum is: " + sum(sample_array));
                }
                else
                {
                    Console.WriteLine("Please enter a value between 5 & 15");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an Integer Value");
            }
        }
    }
}