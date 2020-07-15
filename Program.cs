using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASupi
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count()== 3)
            {
                DateTime dt = Convert.ToDateTime(args[0]);
                int NodeNumber = Convert.ToInt16(args[1]);
                int Geraetetyp = Convert.ToInt16(args[2]);

                int pwSpecial = ((((dt.Day + NodeNumber)) * dt.Year) - (dt.Month * dt.Month)) * Geraetetyp;
                int pwNeutral = ((((dt.Day) * dt.Year) - (dt.Month * dt.Month)) * Geraetetyp) + 1000000000;

                Console.WriteLine("PWS: " +pwSpecial+" o "+pwNeutral);
                Console.WriteLine("PWH: 75910120");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Usage:Datum Wcn Typ(261)");
                Console.ReadKey();

            }
        }
    }
}
