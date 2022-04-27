using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalc
{
    class ModelCalculadora
    {
        public ModelCalculadora()
        {

        }//Fim do método construtor ModelCalculadora.
 public double Somar(double n1, double n2)
    {
        return n1 + n2;
    }//Fim Somar.
    public double Subtracao(double n1, double n2)
    {
        return n1 - n2;
    }//Fim Subtrair.
    public double Divisao(double n1, double n2)
    {
        if(n2 <= 0)
        {
            return -1;
        }
        else
        {
            return n1 / n2;
        }
    }//Fim Divisão.
    public double Multiplicacao(double n1, double n2)
    {
       return n1 * n2;
    }//Fim Multiplicação.
    public double Potencia(double bas, double expoente)
    {
        if(expoente == 1)
        {
            return bas;
        }else if(expoente == 0)
        {
            return 1;
        }
        else
        {
            return Math.Pow(bas, expoente);
        }
    }//Fim Potência.
    public double Raiz(double n1)
    {
        if (n1 <= 0)
        {
            return -1;
        }
        else
        {
            return Math.Sqrt(n1);
        }
    }// Fim Raiz.

    }//Fim da Classe.
}//Fim do Projeto
