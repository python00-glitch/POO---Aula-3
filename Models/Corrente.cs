using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO___Aula_3.Models
{
     public class Corrente : Conta
     {
         public override void Creditar(decimal valor)
         {
             saldo += valor;
         }
     }
}