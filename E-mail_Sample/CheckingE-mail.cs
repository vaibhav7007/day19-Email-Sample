using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression_Email_ID
{
    class CheckingEmail
    {
        public static void ID()
        {
            string pattern = "^[a-z0-9]{3,}?([-,.,+][a-z0-9]{1,})*@[a-z0-9]{1,}.(com|com.au|net|co.in|com.com)$";
            string[] Email_ID = {"abc@yahoo.com", "abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com",
                "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com","abc+100@gmail.com",
                "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com",
                "abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            foreach (string input in Email_ID)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is invalid", input);
                }
            }
        }
    }
}