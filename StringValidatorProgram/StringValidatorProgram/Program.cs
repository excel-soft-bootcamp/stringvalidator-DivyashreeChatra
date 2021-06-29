using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorProgram
{
    class Program
    {
      
            static void Main(string[] args)
            {
                LenghtofString length = new LenghtofString();
                StringExe stringex = new StringExe();
                StringEmpty empty = new StringEmpty();
                bool stringlenght = length.Validate("DivyashreeChatra");
                bool startvalueex = stringex.Validate("excel");
                bool emptystring = empty.Validate("");
                Console.WriteLine(stringlenght);
                Console.WriteLine(startvalueex);
                Console.WriteLine(emptystring);
                Console.ReadLine();
            }
        }
    }