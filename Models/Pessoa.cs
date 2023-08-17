using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO___Aula_3.Models
{
    public class Pessoa
    // Aqui, iremos criar a classe 'Pessoa', que é oque nós definiremos oque vai ser uma pessoa no nosso minimundo (código)
    {
        // Criandoo as propriedades/características para ABSTRAIR o que queremos para a nossa Pessoa
        public string Cadastro { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        // Criamos um Método (ação) para podermos apresentar as propriedades 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Meu ID é {Cadastro}");
        }
    }
}