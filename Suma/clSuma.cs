using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class clSuma
    {
        //Atributos
        private int num1;
        private int num2;

        //Constructor(Es el que dirige)
        public clSuma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Método
        public int suma()
        {
            return (num1 + num2);
        }
    }
}
