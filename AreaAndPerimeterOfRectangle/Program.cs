namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Console.WriteLine("Enter the Length of the Rectangle");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of the Rectangle");
            int w = Convert.ToInt32(Console.ReadLine());
            int area = rec.Area(l, w);
            Console.WriteLine($"The Area of The Rectangle is {area}");
            int peri = rec.Perimeter(l, w);
            Console.WriteLine($"The Perimeter of the Rectangle is {peri}");

        }
    }
    public class Rectangle
    {
        public int Area(int length, int width)
        {
            int area = length * width;
            return area;
        }
        public int Perimeter(int x, int y)
        {
            int peri = 2 * (x + y);
            return peri;
        }
   
    }
    }
    
    

