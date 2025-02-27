namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of small carpets:");
            int SmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Larg carpets:");
            int LargCarpets = Convert.ToInt32(Console.ReadLine());
            int cost = (SmallCarpets * 25) + (LargCarpets * 35);
            double tax = cost * 0.06;
            double total = cost + tax;
            Console.WriteLine("The Cost =" + cost + "$");
            Console.WriteLine("The Tax =" + tax + "$");
            Console.WriteLine("The Total =" + total + "$");
        }
    }
}
