﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Pattern
    {
        static string pattern = "^cen$";
        //^ it will indicate start of string.
        //$ it will indicate the end of string.

        public void MyRegex()
        {
            Regex regex = new Regex(pattern);
            if (regex.IsMatch("kiran"))
            {
                Console.WriteLine("String is match the pattern ");
            }
            else
            {
                Console.WriteLine("string does not match the pattern ");
            }
        }
        public void CheckName(string name)
        {
            string myName = "^[A-Z][a-z]{3,}?$";
            if (Regex.IsMatch(name, myName))
            {
                Console.WriteLine("String match the pattern");
            }
            else
            {
                Console.WriteLine("String doesnot match the pattern");
            }
        }
        public void CheckLastName(string lastname)
        {
            string myLastName = "^[A-Z][a-z]{3,}?$";
            if (Regex.IsMatch(lastname, myLastName))
            {
                Console.WriteLine("String match the pattern");
            }
            else
            {
                Console.WriteLine("String doesn't match the pattern");
            }
        }
    }
}
