using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisteminhaCalculos.Calcs
{
    public class Calcs
    {
        public double Custo { get; private set; }
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }
        public double Receber { get; private set; }
        public double Margem { get; private set; }
        public double Adicional { get; private set; }

        public Calcs(double custo, int quantidade, double preco, double receber, double margem, double adicional)
        {
            Custo = custo;
            Quantidade = quantidade;
            Preco = preco;
            Receber = receber;
            Margem = margem;
            Adicional = adicional;
        }

        public double CalcularPreco(bool x) //Usado no botão Calcular Preço
        {
            if(x) //Premium
            {
                return ((Custo * Quantidade) + (Custo * Quantidade * (Margem / 100)) + Adicional)/0.84;
            }
            else //Clássico
            {
                return ((Custo * Quantidade) + (Custo * Quantidade * (Margem / 100)) + Adicional) / 0.89;
            }
        }

        





    }
}
