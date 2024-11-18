using System.ComponentModel;
using System.Text;

namespace Assignment3._1._1
{
    internal class Program
    { //Return even numbers
      //Write a method that returns a string of even numbers greater than 0 and less than 100.
      //(Use StringBuilder class)
        static void Main(string[] args)
        {

            string evenNumber = ZeroToHundredEven();
            Console.WriteLine(evenNumber);

        }

        static string ZeroToHundredEven()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 100; i++)
            {

                if (i % 2 == 0)
                {

                    sb.Append(i);
                    if (i < 98)

                    {
                        sb.Append(' ');
                    }

                }

            }
            return sb.ToString();
        }

    }

}
