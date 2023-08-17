using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO___Aula_3.Models
{
    public class ContaCorrente
    {
        decimal Valor = 0;
        public void DefinirDados()
        {
            Console.Write("Digite o nome: ");
            NomeConta = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            Idade = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite a cidade que você mora: ");
            Endereço = Console.ReadLine();
        }
        public string NomeConta { get; set; }
        public int Idade { get; set; }
        public string Endereço { get; set; }
        public int NumeroConta { get => _numeroConta; set => _numeroConta = value; }
        public long Senha { get => _senha; set => _senha = value; }

        private decimal _saldo = 0;
        private int _numeroConta;
        private long _senha;

        public void Apresentar()
        {
            Console.WriteLine("Conta R.bank:");
            Console.WriteLine($"    Nome: {NomeConta} \n    Idade: {Idade}\n    Cidade: {Endereço} \n");
        }

        public void Sacar()
        {
            Console.Write($"Seu saldo atual é: {_saldo} \nDigite o quanto deseja sacar: ");
            Valor = Convert.ToDecimal(Console.ReadLine());

            if (Valor <= 0)
            {
                Console.WriteLine("Insira um valor válido.");
                Sacar();
            }
            else if (Valor > _saldo)
            {
                Console.WriteLine($"Valor de {Valor} é maior do que o saldo atual de {_saldo}");
                Sacar();
            }
            else
            {
                _saldo -= Valor;
                Console.WriteLine($"Saldo atual: {_saldo}");
            }
        }
        public void Depositar()
        {
            Console.Write($"Seu saldo atual é: {_saldo} \nDigitei o quanto deseja depositar: ");
            Valor = Convert.ToDecimal(Console.ReadLine());

            if (Valor <= 0)
            {
                throw new Exception("Insira um valor válido.");
            }
            else if (Valor > 3000)
            {
                throw new Exception($"Valor de {Valor} é maior do que o permitido. Favor, realizar pagamento no caixa.");
            }
            else
            {
                _saldo += Valor;
                Console.WriteLine($"Saldo atual: {_saldo}");
            }
        }
        public void MudarSenha()
        {
            Console.Write("Digite a sua nova senha: ");
            long novaSenha = Convert.ToInt64(Console.ReadLine());
            if (novaSenha == _senha)
            {
                Console.WriteLine("Digite uma senha diferente da antiga.");
                MudarSenha();
            }
            else
            {
                _senha = novaSenha;
                Console.WriteLine($"Sua nova senha é: {_senha}");
            }
        }
    }
}