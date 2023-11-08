using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int n1, int n2); //EU POSSO APENAS REGISTRAR A ASSINATURA DA FUNÇÃO NA INTERFACE E DEIXAR A IMPLEMENTAÇÃO PARA A CLASSE QUE IMPLEMENTA A INTERFACE
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        int Dividir(int n1, int n2) //OU POSSO JÁ IMPLEMENTAR TODA A FUNÇÃO PARA APENAS SER REAPROVEITADA PELA CLASSE QUE IMPLEMENTA A INTERFACE    
        {
            return n1 / n2;
        }
    }
}