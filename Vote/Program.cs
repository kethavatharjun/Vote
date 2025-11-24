namespace Vote
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age<18)
            {
                throw new Exception("Not eligible for vote");
            }
            else
            {
                Console.WriteLine("Eligible for vote");
            }
        }
    }
}