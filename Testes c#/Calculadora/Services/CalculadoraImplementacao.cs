using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {

        private List<string> _historico;
        public CalculadoraImplementacao()
        {
            _historico = new List<string>();
        }

        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;
            _historico.Insert(0, "Res: " + res);

            return res;
        }

        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;
            _historico.Insert(0, "Res: " + res);

            return res;
        }

        public int Dividir(int n1, int n2)
        {
            int res = n1 / n2;
            _historico.Insert(0, "Res: " + res);

            return res;
        }

        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            _historico.Insert(0, "Res: " + res);

            return res;
        }

        public bool EhPar(int n)
        {
            return n % 2 == 0;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);


            return _historico;
        }
    }
}