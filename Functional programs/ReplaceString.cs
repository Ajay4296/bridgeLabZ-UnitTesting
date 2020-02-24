using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class ReplaceString
    {
        public static void Replaces()
        {
            string s = "Hello <<UserName>>, How are you?";
            Console.WriteLine("Enter name to replace");



            string name = Console.ReadLine();
            string replace = s.Replace("<<UserName>>", name);
            Console.WriteLine("" + replace);
        }
    }
    
}
