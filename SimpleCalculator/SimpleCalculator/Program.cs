namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose A Number:"); int Firstnumber = Console.Read();
            Console.WriteLine("Choose Another Number:"); int Secondnumber = Console.Read();
            Console.WriteLine("Choose one of the following operations:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Product");
            Console.WriteLine("3. Diffrence");
            Console.WriteLine("4. Qoutient");
            int ChosenOperation = Console.Read();
            
        }
    }
}