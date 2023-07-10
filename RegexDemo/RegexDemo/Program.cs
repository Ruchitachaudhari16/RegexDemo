using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
  public class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            pattern.MyRegex();
            pattern.CheckName("Ruchita");
            pattern.CheckLastName("Chaudhari");
            Console.ReadLine();
        }
    }
}
