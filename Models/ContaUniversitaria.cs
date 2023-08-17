using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO___Aula_3.Models
{
    public class ContaUniversitaria : ContaCorrente
    {
        public int Cadastro { get; set; }
        public int Nota { get; set; }
        public void Aprovacao()
        {
            if (Nota < 5)
            {
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}