using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
            {
                return 0;
            }

            if(x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }
            
            if (x.Agencia < y.Agencia)
            {
                return -1; // X fica na frente de Y
            }

            if (x.Agencia == y.Agencia)
            {
                return 0; // São equivalentes
            }

            return 1; // Y fica na frente de X


            // Nossas comparações de númeriso inteiros é equivalente
            // ao que já existe no tipo INT
            // return x.Agencia.CompareTo(y.Agencia);
        }
    }
}
