using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {

        enum Cores {             
            Vermelho,
            Rosa,
            Roxo
        };


        static void Main(string[] args)
        {
            Cores corFavoritaGrazi = Cores.Rosa; 
            Console.WriteLine("Minha cor favorita é: " + corFavoritaGrazi);

            var meuNome = "Grazielle Amanda do Carmo Café";
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Meu nome é: " + meuNome);

            // Tipos 
            // int - 156 
            // Float - 3.14 numero decimal 
            // Bool - true or false 
            // String - "Texto" 
            // Char - 'A' caractere simples

            int segundaGuerraMundial = 1939;
            Console.WriteLine(" A segunda guerra mundial começou em: " + segundaGuerraMundial);

            dynamic corFavorita = "rosa";
            Console.WriteLine("Minha cor favorita é: " + corFavorita);
            corFavorita = "roxo";
            Console.WriteLine("Minha cor favorita agora é: " + corFavorita);

            // Constante 
            const float pi = 3.14f;
            Console.WriteLine("O valor de pi é: " + pi);

            // Entrada do usuário 
            /* Console.WriteLine("Escreva seu nome: ");
            string nomeUsuario = Console.ReadLine(); 
            Console.WriteLine(" Seu nome é: " + nomeUsuario); */

            // Operadores aritméticos: Soma, Subtração, Multiplicação, Divisão
            const int primeiroNumero = 10;
            const int segundoNumero = 20;
            int soma = primeiroNumero + segundoNumero;
            Console.WriteLine("A soma de " + primeiroNumero + " e " + segundoNumero + " é: " + soma);

            const float terceiroNumero = 5;
            const float quartoNumero = 2;
            float divisao = terceiroNumero / quartoNumero;
            Console.WriteLine("A divisão do número " + terceiroNumero + " pelo número " + quartoNumero + " é: " + divisao);

            // Estruturas condicionais: if, else if, else
            const int idadeFilha = 32;
            const int idadeMae = 60;
            const int idadeTia = 55;
            const int idadePrima = 26;
            if (idadeFilha < idadeMae)
            {
                Console.WriteLine("Grazielle é mais nova que Katia.");
            }
            else if (idadeFilha > idadeMae)
            {
                Console.WriteLine("Grazielle é mais velha que Katia.");
            }
            else
            {
                Console.WriteLine("Grazielle e Katia têm a mesma idade.");

            }

            // Operadores lógicos: && (AND), || (OR), ! (NOT)
            const string nomeFilha = "Grazielle";
            const string nomeMae = "Kátia";
            const string nomeTia = "Cláudia";
            const string nomePrima = "Milena";

            if (nomeFilha == "Grazielle" && idadeFilha > 30)
            {
                Console.WriteLine("Grazielle é a filha de Kátia e tem mais de 30 anos.");
            }
            else if (nomeTia == "Claudia" && idadePrima == 26)
            {
                Console.WriteLine(" A filha de " + nomeMae + " é Milena");
            }
            if (nomeTia == "Cláudia" || nomeMae == "Kátia")
            {
                Console.WriteLine("A tia de Grazielle é Cláudia ou a mãe de Grazielle é Kátia.");

            }

            // Declaração de Funções
            ExibirMensagem("Meu nome é Grazielle Amanda do Carmo Café");
            GerarPreco(10);
            Console.WriteLine(Somar(1, 2, 3));

            // Arrays 
            string[] jogos = new string[4] { "Minecraft", "The Sims", "GTA V", "Fortnite" };
            foreach(var jogo in jogos)
            {
                Console.WriteLine(jogo);
            }

            Console.WriteLine("O meu jogo preferido é o : " + jogos[1]);

            // Switch
            string cor = "rosa"; 

            switch(cor)
            {
                case "vermelho":
                    Console.WriteLine("Minha cor favorita é vermelho");
                    break;
                case "rosa":
                    Console.WriteLine("Minha cor favorita é rosa");
                    break;
                case "roxo":
                    Console.WriteLine("Minha cor favorita é roxo");
                    break; 
            }

            // While 
            int contador = 0; 
            while(contador <= 10)
            {
                Console.WriteLine("Contador: " + contador);
                contador = contador + 1; 
            }

            // foreach 
            string[] nomes =
            {
                "Grazielle",
                "Kátia",
                "Isabelle",
                "José Geraldo"
            }; 

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            // for 
            int contadorUm = 0; 
            for(contadorUm =0; contadorUm <= 10; contadorUm++)  
            {
                Console.WriteLine("Contador está no número:" + contadorUm);
            }
        }

            // Funções: blocos de código reutilizáveis que realizam uma tarefa específica

        static void ExibirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem); 
        }

        static void GerarPreco(int preco)
        {
            int precoFinal = preco + (2 * preco);
            Console.WriteLine(" O preço final do produto é : " + precoFinal);
        }

        // Função com retorno de valor 
        static int Somar(int a, int b, int c)
        {
            int soma = a + b + c;
            return soma;
        }
       
    }
}
