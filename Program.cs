/* Programação Orientada a Objetos
// O que é POO (Programação Orientada a Objetos)? POO nada mais é do que um PARADIGMA.
// Paradigmas são um conjunto de regras/técnicas que visam solucionar uym problema, uma maneira de programar, conhecidos como PARADIGMAS DE PROGRAMAÇÃO
// Os principais conceitos da POO são 'Classes' e 'Objetos'.
//  - Classe: Uma representação de um objeto da vida real, um molde;
//      + Ex.: Queremos montar um sistema de cadastro de clientes. Podemos ter uma classe 'Pessoa', e moldamos com as características/atributos/propriedades de uma pessoa;
//      + Ex. Propriedades para Classe Pessoa: Nome, Sobrenome, Idade, ID, Endereço, etc;
//      + Ex. Métodos para Classe Pessoa: Apresentar (a pessoa se apresentar com as suas propriedades);
//  - Objeto: É uma CLASSE CONCRETIZADA, com todas as propriedades criadas na classe que ela está submetida.;
//      + Ex.: Criamos um objeto da Classe Pessoa com nome de Bob Frentz, tem 21 anos, mora em Lisboa, com a identidade 00-000-..., etc;
//      + Um objeto é uma criação de algo feito com as características de uma classe, por isso é uma CLASSE CONCRETIZADA;
//      + É através do OBJETO que trazemos ao código propriedades da classe para manejarmos;
//
//  Vamos falar de alguns desses paradigmas:
//  1- Abstração: Abstração é o ato de abstrair um objeto do mundo real para um contexto específico, considerando apenas as propriedades importantes dela.
//     Ainda usando o exemplo do OBJETO DA CLASSE PESSOA, para criarmos um objeto Pessoa do mundo real, devemos abstrair (propriedades) oque precisamos dela
//     para nosso contexto (no caso, o softeware), como Nome, Idade, ID, Telefone, etc.
//  Ex. Classe: (Para ter um exemplo de como criar uma Classe, ir para página da classe 'Pessoa')
//  Ex. Objeto: Criando um objeto da Classe Pessoa que criamos

// using POO___Aula_3.Models;

// Pessoa cliente = new();
// // Criando um objeto Pessoa com a variável 'cliente', que irá ser invocada para abstrair oque queremos

// cliente.Cadastro = "123.456.789.12"; // *
// cliente.Nome = "Ramon Santos"; // *
// cliente.Idade = 32; // *
// // * = Abstraindo características com as propriedades

// cliente.Apresentar();
// // Método que tem o 'WriteLine' para apresentar o cliente
//
//  2- Encapsulamento: Encapsulamento serve para proteger uma classe, e definir limites de alterações externas para nosssas propriedades.
//     Também serve para ocultar o comportamento, e exibir apenas o necessário.
//  Ex.: Temos uma classe 'Conta Corrente' e precisamos deixar a propriedade 'Nome' e 'Sacar' de forma alterável para o usuário, mas 
//       o saldo da conta não pode ser alterado, a não ser pela classe 'Conta Corrente'

using POO___Aula_3.Models;

Console.WriteLine("R-bank, seu banco para coisas simples ;) [Conta Corrente]");

ContaCorrente c1 = new();

Console.Clear();

c1.DefinirDados();
c1.Apresentar();

c1.Depositar();
c1.Sacar();
c1.MudarSenha(); */

/* Herança: Este é um estilo de técnica usada na POO para reutilizar/duplicar códigos e não pesar tanto um software.
//          Centrada para as classes, as HERANÇAS são quando nós usamos as propriedades de uma CLASSE em OUTRAS CLASSE,
//          transferindo por meio do comando "classe : classe", onde passamos todas as prop's para a classe, sem precisar
//          escrever nenhuma propriedade na nova classe;

// Ex. Classe filha 'Alunos' tendo a herança da classe 'Professores':

//      public class Professores
//      {
//          public string Nome { get; set; }
//          public int Idade { get; set; }
//          private long _ID;
//      } 

//      public class Alunos : Professores
//      {
//          
//      } 

// Neste caso, usamos a Classe Professores para transferir as propriedades dela para a Classe Alunos, o invocando usando o ":" no comando
// "classe : classe";

// Também podemos adicionar propriedades específicas para esta classe, como no exemplo abaixo: 
// Ex.: public class Alunos : Professores
//      {
//          private float _notas;
//          private long _ID;
//          public DateTime Faltas { get; set; }
//      }

Console.WriteLine("R-bank, seu banco para coisas simples ;) [Conta Universitária]");

ContaUniversitaria c2 = new();

Console.Clear();

c2.DefinirDados();
c2.Apresentar();

c2.Cadastro = 123456;
c2.Nota = 10;
c2.Aprovacao(); */

/* Polimorfismo: Com o POLIMORFISMO, podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter
//               sua própria implementação.
// Ex.: A classe 'Pessoa' tem o método "Apresentar", com suas propriedades 'Nome' e 'Idade', escrito "Olá, meu nome é X, com idade Y";
//      As classes 'Professor' e 'Aluno' herdam a classe 'Pessoa', mas querem que a escrita apresente respectivamente a 'Nota' e 'Salário';
//
// Nesta forma, o polimorfismo tem dois modelos de processo:
//      1- Tempo de execução: Acontece dentre uma classe para outra, no método chamado "tempo de execução". Para conseguirmos fazer essa
//         mudança, precisa mudar o tipo de método, adicionando a palavra "virtual" no método original, que possibilita copiar o método 
//         para outra classe filha e alterarmos o mesmo método para nosso uso nesta classe em específico, colocando o nome "override".

// Ex. Usando o método 'Apresentar' da classe pessoa na classe 'Aluno', mas alterando com a palavra ": 

//      public class Pessoa
//      {
//          public string Cadastro { get; set; }
//          public string Nome { get; set; }
//          public int Idade { get; set; }

//          public virtual void Apresentar()
//          {
//              Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Meu ID é {Cadastro}");
//          }
//      }

//      public classe Alunos : Pessoa
//      {
//          public double Nota { get; set; }
//
//          public override void Apresentar()
//          {
//              Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Minha nota é {Nota}");
//          }
//      }

//      2- Tempo de compilação: Acontece sem depender de HERANÇAS, sendo mais simples (Overload/Early Binding).
//         Oque faz ele mudar e ocorrer o polimorfismo de um método para outro é a quantidade de argumentos.

//      public classe Pessoa
//      {
//          public int Somar ( int a, int b, int c )
//          {
//              return a + b + c;
//          }
//          public int Somar ( int a, int b )
//          {
//              return a + b;
//          } 
//      } */

// ---------------------------------------------------------------------------------------------------------------------------------- //

/* Classes Abstratas
// Oque são classes abstratas? Classes Abstratas são "CLASSES MODELOS", nas quais servem para serem molde para outras classes filhas,
// que herdarão suas propriedades e criarão outras para fins mais específicos. Classes Abstratas são objetos da vida real que são 
// "genéricos", como uma PESSOA, ou uma CONTA BANCÁRIA. Uma Conta Bancária nunca é apenas "uma conta", sempre tem um estilo de conta
// diferente, desde UNIVERSITÁRIA, á CORRENTE, ou POUPANÇA. Para este caso, dividiriamos as classes, sendo a 'Classe Conta' a abstrata,
// servindo apenas de modelo para criar outras classes, com propriedades diferentes.
// O maior diferencial da Classe Abstrata é que, como ela é uma classe-modelo, ela não pode ser instânciada no código. Não podemos traba-
// lhar com ela no software, ela serve apenas para ser a Classe Pai para ter suas propriedades abstraídas.

// Ex. Classe abstrata 'Conta' sendo classe pai para a Classe filha 'Corrente':

// Classe Conta (Abstrata):
//      public abstract class Conta
//      // A palavra "abstract" serve para transformar a classe normal em classe abstrata;
//      {
//          protected decimal saldo;
//          // A palavra "protected" protege a propriedade de alterações externas, com exceção das classes filhas;
//
//          public abstract void Creditar(decimal valor);
//
//          public void ExibirSaldo()
//          {
//              Console.WriteLine("Saldo: " + saldo);
//          }
//      }

// Classe Corrente:
//      public class Corrente : Conta
//      {
//          public override void Creditar(decimal valor)
//          {
//              saldo += valor;
//          }
//      }

Corrente corrente = new Corrente();
corrente.Creditar(500);
corrente.ExibirSaldo(); */

/* Classe Selada
// Oque são classes seladas? São classes que você bloqueia qualquer herança que ela venha a sofrer de outras classes. Apartir dela, nen-
// huma outra classes pode abstrair propriedades dela, ela será única. Junto a ela, temos o MÉTODO SELADO, que além de não dar herança,
// ainda não permite que outras propriedades façam polimorfismo dela.
// Ainda em CLASSES SELADAS, a classe pode até ser filha de outra classe, mas caso tenha o nome "sealed", nenhuma outra classe pode ter
// uma herança dela.

// Ex. Classe 'Pessoa' será uma classe selada:

//      public sealed class Pessoa
//      {
//          public string Cadastro { get; set; }
//          public string Nome { get; set; }
//          public int Idade { get; set; }

//          public VIRTUAL void Apresentar()
//          {
//              Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Meu ID é {Cadastro}");
//          }
//      }

// Ex. O método 'Apresentar' será selado:

//      public class Pessoa
//      {
//          public string Cadastro { get; set; }
//          public string Nome { get; set; }
//          public int Idade { get; set; }

//          public sealed virtual void Apresentar()
//          {
//              Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Meu ID é {Cadastro}");
//          }
//      }

//      public classe Alunos : Pessoa
//      {
//          public double Nota { get; set; }
//      } */

/* Interfaces
// Oque são Interfaces? Nada mais é do que um "contrato" que pode ser implementado em uma classe. É como se fosse uma classe abstrata, que
// define métodos abstratos para implementar. E assim como uma classe, não pode ser instanciado.

// Ela obtém métodos abstratas, e as classes que IMPLEMENTAREM essa interface, terão que obrigatoriamente implementar esses métodos.
// Quando criamos uma interface, ao darmos o nome, sempre devemos colocar a letra "I" na frente do nome, indicando "Interface", como por
// exemplo "ICalculadora", "IPessoa", etc

// // Ex. Interface de calculadora básica:

//     public interface ICalculadora
//     {
//         int Somar(int a, int b);
//         int Subtrair(int a, int b);
//         int Multiplicar(int a, int b);
//         int Dividir(int a, int b);
//     }

// De algumas diferenças dentre uma INTERFACE e uma CLASSE que podemos perceber, uma é que as propriedades não tem o "public" no começo.
// Isso se deve ao fato de ela ja ser automaticamente 'public'. Por isso, não tem nenhum tipo de acessor no começo;
// Outra diferença também é que esses métodos não tem um CORPO ('{}'), pois ele não é implementado, logo, não precisa do corpo;
// Mas, caso você coloque um corpo nos métodos da interface, ela não terá de ser obrigatória para implementação nas classes que implemen-
// tarem esta interface;

// Ex. Interface de calculadora com método 'Dividir' com corpo:

//     public interface ICalculadora
//     {
//         int Somar(int a, int b);
//         int Subtrair(int a, int b);
//         int Multiplicar(int a, int b);
//         int Dividir(int a, int b)
//         {
//             return a / b;
//         }
//     } */
