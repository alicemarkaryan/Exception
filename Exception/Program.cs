using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Fac(18);
        }
        public static int Fac(int a)
        {
            try
            {
                int b = a;
                if (a == -1)

                    return 0;
                else
                    return b / Fac(a - 1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 1; 
            
            
           
        }
    }
}
