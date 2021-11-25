using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataisbnn
{
	public class isbncheck
	{

		public static bool isValidISBN(string isbn)
		{


			int n = isbn.Length;

			if (n != 10)

				return false;

			// Computing weighted sum of
			// first 9 digits
			int sum = 0;
			for (int i = 0; i < 9; i++)
			{
				int digit = isbn[i] - '0';

				if (0 > digit || 9 < digit)
					return false;

				sum += (digit * (10 - i));

			}

			// Checking last digit.
			char last = isbn[9];
			if (last != 'X' && (last < '0'
							|| last > '9'))
				return false;

			// If last digit is 'X', add 10
			// to sum, else add its value.
			sum += ((last == 'X') ? 10 :
							(last - '0'));

			// Return true if weighted sum
			// of digits is divisible by 11.
			return (sum % 11 == 0);
		}

		// Driver code
		public static void Main()
		{
			string isbn;
			isbn = "0764526413";


			if (isValidISBN(isbn))
				Console.WriteLine("Valido");
			else
				Console.WriteLine("Invalido");
			Console.Read();
		}
	}
}