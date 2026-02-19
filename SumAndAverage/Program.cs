namespace SumAndAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number:");
            int z = Convert.ToInt32(Console.ReadLine());
            Math math = new Math();
            int sum = math.Sum(x, y, z);
            Console.WriteLine($"The Sum of 3 Number is :{sum}");
            float Avg = math.Average(x, y, z);
            Console.WriteLine($"The Average of the 3 Number are:{Avg}");
        }
    }
    public class Math
    {
        public int Sum(int x,int y,int z)
        {
            int sum = x + y + z;
            return sum;
        }

        public float Average(int x,int y,int z)
        {
            float Avg = (x + y + z) / 3.0f;
            return Avg;
        }
    }

}
