using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class TestASM
    {
       static void Main(string[] args)
        {
            Medicine objMedicne = new Medicine();
            Sale objSale = new Sale();
            objMedicne.Accept();
            objSale.Accpect();
            Console.WriteLine();
            objMedicne.Print();
            objSale.Display();
            Console.ReadKey();

        }
    }
}
