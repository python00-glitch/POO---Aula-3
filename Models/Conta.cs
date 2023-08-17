using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO___Aula_3.Models
{
    public abstract class Conta
     // A palavra "abstract" serve para transformar a classe normal em classe abstrata;
     {
         protected decimal saldo;
         // A palavra "protected" protege a propriedade de alterações externas, com exceção das classes filhas;

         public abstract void Creditar(decimal valor);

         public void ExibirSaldo()
         {
             Console.WriteLine("Saldo: " + saldo);
         }
     }
}