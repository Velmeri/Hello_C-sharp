using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hello_C_sharp
{
    static class Task
    {
        public static void Wright(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("Character at index " + i + " is: " + message[i]);
            }
        }
        public static void N1()
        {
            Console.WriteLine("It's easy to win forgiveness for being wrong; \nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
        }

        public static void N2()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            short i = 1;
            Console.WriteLine($"Enter number #{i++}:");
            string str = Console.ReadLine();
            Int32.TryParse(str, out a); // out используется для передачи аргумента в метод по ссылке, а не по значению.
            Console.WriteLine($"Enter number #{i++}:");
            str = Console.ReadLine();
            Int32.TryParse(str, out b);
            Console.WriteLine($"Enter number #{i++}:");
            str = Console.ReadLine();
            Int32.TryParse(str, out c);
            Console.WriteLine($"Enter number #{i++}:");
            str = Console.ReadLine();
            Int32.TryParse(str, out d);
            Console.WriteLine($"Enter number #{i++}:");
            str = Console.ReadLine();
            Int32.TryParse(str, out e);
            int sum = a + b + c + d + e;
            int product = a * b * c * d * e;
            int min = a, max = a;
            if (min > b) min = b;
            if (max < b) max = b;
            if (min > c) min = c;
            if (max < c) max = c;
            if (min > d) min = d;
            if (max < d) max = d;
            if (min > e) min = e;
            if (max < e) max = e;
            Console.WriteLine($"sum = {sum}, product = {product}, min = {min}, max = {max}");
        }
        public static void N3()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int number = 0;
            if (!Int32.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input. The number must be a valid integer.");
                return;
            }

            int flipped = 0;
            int place = 1;
            while (number > 0)
            {
                flipped = flipped * 10 + number % 10;
                number /= 10;
                place *= 10;
            }

            Console.WriteLine("The flipped number is: " + flipped);
        }
        public static void N4()
        {
            Console.Write("Enter a lower limit: ");
            int lowerLimit = Int32.Parse(Console.ReadLine());

            Console.Write("Enter an upper limit: ");
            int upperLimit = Int32.Parse(Console.ReadLine());

            int prev = 0;
            int current = 1;
            if (prev >= lowerLimit)
            {
                Console.Write(prev + ", ");
            }
            while (current <= upperLimit)
            {
                int next = prev + current;
                if (next >= lowerLimit)
                {
                    Console.Write(current + ", ");
                }
                prev = current;
                current = next;
            }
        }
        public static void N5()
        {
            Console.Write("Enter a starting number: ");
            int start = Int32.Parse(Console.ReadLine());

            Console.Write("Enter an ending number: ");
            int end = Int32.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        public static void N6()
        {
            Console.Write("Enter the length of the line: ");
            int length = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the fill character: ");
            char fill = Console.ReadLine()[0];

            Console.Write("Enter the direction of the line (horizontal or vertical): ");
            string direction = Console.ReadLine().ToLower();

            if (direction == "horizontal")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(fill);
                }
                Console.WriteLine();
            }
            else if (direction == "vertical")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(fill);
                }
            }
            else
            {
                Console.WriteLine("Invalid direction");
            }
        }
    }
    internal class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("N1:");
            Task.N1();
            Console.WriteLine("\n\nN2:");
            Task.N2();
            Console.WriteLine("\n\nN3:");
            Task.N3();
            Console.WriteLine("\n\nN4:");
            Task.N4();
            Console.WriteLine("\n\nN5:");
            Task.N5();
            Console.WriteLine("\n\nN6:");
            Task.N6();

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
