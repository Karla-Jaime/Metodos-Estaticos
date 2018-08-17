using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Matematicas
    {
        //2elevado3 = 8
        public static int Potencia(int numeroBase, int exponente)//funcion estatica
        {
            int resultado = 1;
            for(int a = 0; a < exponente; a++)
            {
                resultado = resultado * numeroBase;
            }
            return resultado;
        }
    }
}
