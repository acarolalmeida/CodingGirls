using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Exerício02
{
    public class Conta
    {
        private string _login;
        private string _password;

        private List<string> loginsArmazenados = new List<string>();
        private List<string> senhasArmazenadas = new List<string>();

        public Conta()
        { 

        }

        public void Menu()
        {
            Console.WriteLine("Selecione o que deseja fazer:");
            Console.Write("1 - Criar uma nova conta / 2 - Alterar senha / 3 - Acessar sua conta: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcaoEscolhida)
            {
                case 1:
                    CriarConta();
                    break;
                case 2:
                    AlterarSenha();
                    break;
                case 3:
                    AcessarConta();
                    break;
                default:
                    Console.WriteLine("Esta opção não é válida.\n");
                    break;
            }
        }

        public void CriarConta()
        {
            DEFINELOGIN:
            Console.Write("Digite o login desejado: ");
            _login = Console.ReadLine();
            bool verificaDuplicacaoLogin = loginsArmazenados.Contains(_login);

            if (!verificaDuplicacaoLogin)
            {
                loginsArmazenados.Add(_login);
            }

            else
            {
                Console.WriteLine("\nEste login já existe. Tente novamente.\n");
                goto DEFINELOGIN;

            }

            DEFINESENHA:
            Console.Write("Digite a senha desejada: ");
            string senhaNova = Console.ReadLine();
            Console.Write("Digite a senha novamente: ");
            string confereSenha = Console.ReadLine();

            if (senhaNova == confereSenha)
            {
                _password = senhaNova;
                string senhaCriptografada = Criptografia.GeraMD5Hash(_password);
                senhasArmazenadas.Add(senhaCriptografada);
                
            }

            else 
            {
                Console.WriteLine("\nAs senhas inseridas não são iguais. Tente novamente!\n");
                goto DEFINESENHA;
            }
            
            Console.WriteLine("\nConta criada com sucesso!\n");
        }

        public void AlterarSenha() 
        {
            LOGIN:
            Console.Write("Login: ");
            string loginInserido = Console.ReadLine();
            int id = loginsArmazenados.IndexOf(loginInserido);

            if (!(loginsArmazenados.Contains(loginInserido)))
            {
                Console.WriteLine("\nEste usuário não existe!\n");
                goto LOGIN;
            }

            SENHAATUAL:
            Console.Write("Senha atual: ");
            string senhaAtual = Console.ReadLine();
            string senhaAtualCripto = Criptografia.GeraMD5Hash(senhaAtual);

            if (senhaAtualCripto == senhasArmazenadas[id])
            {
                goto DEFINENOVASENHA;
            }

            else
            {
                Console.WriteLine("\nSenha incorreta!\n");
                goto SENHAATUAL;
            }

            DEFINENOVASENHA:
            Console.Write("Nova senha: ");
            string novaSenha = Console.ReadLine();
            Console.Write("Repita a nova senha: ");
            string confirmaSenha = Console.ReadLine();

            if (novaSenha == confirmaSenha)
            {
                string novaSenhaCript = Criptografia.GeraMD5Hash(senhaAtual);
                senhasArmazenadas[id] = novaSenhaCript;
                Console.WriteLine("\nSenha alterada com sucesso!\n");
            }

            else
            {
                Console.WriteLine("\nAs senhas inseridas não são iguais. Tente novamente!\n");
                goto DEFINENOVASENHA;
            }
        }

        public void AcessarConta() 
        {
            INFORMALOGIN:
            Console.Write("Informe seu login: ");
            _login = Console.ReadLine();
            
            if (!(loginsArmazenados.Contains(_login)))
            {
                Console.WriteLine("\nEste usuário não existe!\n");
                goto INFORMALOGIN;
            }

            else 
            {
                INFORMASENHA:
                Console.Write("Informe sua senha: ");
                _password = Console.ReadLine();

                int id = loginsArmazenados.IndexOf(_login);
                bool resposta = Criptografia.VerificaMD5Hash(_password, senhasArmazenadas[id]);

                if (resposta)
                {
                    Console.WriteLine("\nBem vindo(a) ao sistema!");
                }
                else
                {
                    Console.WriteLine("\nSenha Incorreta!\n");
                    goto INFORMASENHA;
                }
            }
        }
    }
}