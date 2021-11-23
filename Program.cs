using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata13ver1
{
   public class isbn13check
    {
        public static bool CheckISBN13(string code)
        {
            code = code.Replace("-", "").Replace(" ", "");
            if (code.Length != 13)
                return false;
            int sum = 0;
            foreach (var (index, digit) in code.Select((digit, index) => (index, digit))) 
            {
                if (char.IsDigit(digit)) sum += (digit - '0') * (index % 2 == 0 ? 1 : 3);
                else return false;
            }
            return sum % 10 == 0;
        }
        static void Main(string[] args)
        {
           
        }
    }
}
