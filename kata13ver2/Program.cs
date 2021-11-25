using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata13ver2
{
   public class checkisbn13
    {
        public static bool isbnchecker(string store)
        {
            store = store.Replace("-", "").Replace(" ", "");
            if(store.Length!=13)
                {
                return false;
            }
            int total = 0;
            foreach (var (inicio, kata) in store.Select((kata, inicio) => (inicio, kata)))
                {
                if (char.IsDigit(kata)) total += (kata - '0') * (inicio % 2 == 0 ? 1 : 3);
            }
            return total % 10 == 0;
        }
        static void Main(string[] args)
        {
        
        }
    }
}
