using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--- EXERCÍCIO 01 ---\n");
            Exercicio01();
            Console.WriteLine("\n--- EXERCÍCIO 02 ---\n");
            Exercicio02();
            Console.WriteLine("\n--- EXERCÍCIO 03 ---\n");
            Exercicio03();
            Console.WriteLine("\n--- EXERCÍCIO 04 ---\n");
            Exercicio04();
        }
        static void Exercicio01()
        {
            string nome = "Ana Carolina Duarte de Oliveira";
            string endereco = "Rua Blumenau, 2260, Bairro Saguaçu - Itajaí, SC";
            string cep = "83020-056";
            string telefone = "(47) 98739-9976";

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Endereço: {endereco}");
            Console.WriteLine($"CEP: {cep}");
            Console.WriteLine($"Telefone: {telefone}");
        }

        static void Exercicio02()
        {
            string nome = "Carol Shaw";
            string formacao = "Engenheira de Computação";
            string contibuicao = "Carol foi a primeira mulher a desenvolver um game de modo profissional. " +
                                 "Foi uma das programadoras responsáveis pelo Atari e trabalhou na Activision.";

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Formação: {formacao}");
            Console.WriteLine($"Contibuição: {contibuicao}");
        }
        
        static void Exercicio03()
        {
            Console.WriteLine("Música: Running up that hill");
            Console.WriteLine("Artista/Compositor(a): Kate Bush");
            Console.WriteLine("Gênero: Alternativo/Indie");
            Console.WriteLine("Letra: \n");
            Console.WriteLine(@"It doesn't hurt me.
Do you want to feel how it feels?
Do you want to know that it doesn't hurt me?
Do you want to hear about the deal that I'm making?
You, it's you and me.

If I only could,
I'd make a deal with God,
And I'd get him to swap our places,
Be running up that road,
Be running up that hill,
Be running up that building.
If I only could, oh

You don't want to hurt me,
But see how deep the bullet lies.
Unaware I'm tearing you asunder.
Ooh, there is thunder in our hearts.

Is there so much hate for the ones we love?
Tell me, we both matter, don't we?
You, you and me.
It's you and me won't be unhappy.

If I only could,
I'd make a deal with God,
And I'd get him to swap our places,
Be running up that road,
Be running up that hill,
Be running up that building,
If I only could, oh

C'mon, baby, c'mon darling,
Let me steal this moment from you now.
C'mon, angel, c'mon, c'mon, darling,
Let's exchange the experience, oh

And if I only could,
I'd make a deal with God,
And I'd get him to swap our places,
Be running up that road,
Be running up that hill,
With no problems.

If I only could,
I'd make a deal with God,
And I'd get him to swap our places,
Be running up that road,
Be running up that hill,
With no problems.

If I only could,
Be running up that hill
If I only could,
Be running up that hill

If I only could,
Be running up that hill
If I only could,
Be running up that hill

If I only could,
Be running up that hill
If I only could,
Be running up that hill
If I only could,
Be running up that hill");
        }

        static void Exercicio04()
        {
            Console.WriteLine("Precisamos de mais modelos femininos que sejam bons em tecnologia, que sejam empreendedores. " +
                              "Hoje, poucas mulheres assim aparecem na mídia, e se as meninas não são representadas na " +
                              "televisão como inteligentes, boas em matemática e ciências, elas não têm referência à medida " +
                              "que crescem. Sejamos nós esta referência!\n");
        }
    }
}
