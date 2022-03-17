using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    public class TelaInicial
    {
        public string opcao;
        public bool continua = true;
        public void Menu()
        {
            while (continua == true)
            {
                Console.WriteLine("CLUBE DA LEITURA:\n");
                Console.WriteLine("Digite 1 para cadastrar uma revista.");
                Console.WriteLine("Digite 2 para cadastrar um empréstimo.");
                Console.WriteLine("Digite 3 para cadastrar um amigo.");
                Console.WriteLine("Digite 4 para verificar os empréstimos realizados no mês.");
                Console.WriteLine("Digite 5 para verificar os empréstimos em aberto.");
                Console.WriteLine("Digite s para sair.");
                opcao = Console.ReadLine();
                PegarOpcao();
            }

        }

        public void PegarOpcao()
        {
            if (opcao == "1")
            {
                Console.Clear();
                CadastrarRevista();
                Console.Clear();
                continua = true;
            }
            if (opcao == "2")
            {
                Console.Clear();
                CadastrarEmprestimo();
                Console.Clear();
                continua = true;
            }
            if (opcao == "3")
            {
                Console.Clear();
                CadastrarAmigo();
                Console.Clear();
                continua = true;
            }
            if (opcao == "4")
            {
               
            }
            else if (opcao == "s" || opcao == "S")
            {
                Console.WriteLine("Tchau!");
                continua = false;
            }


        }

        public void CadastrarRevista()
        {
            Revista novaRevista = new Revista();
            Console.WriteLine("Qual o tipo da revista? ");
            novaRevista.tipo = Console.ReadLine();
            Console.WriteLine("Qual o numero da edição? ");
            novaRevista.numedicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o ano da revista? ");
            novaRevista.anorevista = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a cor da caixa que ela esta? ");
            novaRevista.corcaixa = Console.ReadLine();
            Console.WriteLine("Qual a etiqueta da caixa? ");
            novaRevista.etiqueta = Console.ReadLine();
            Console.WriteLine("Qual o número da caixa? ");
            novaRevista.numerocaixa = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista cadastrada com sucesso!");
            Console.ResetColor();
            Console.ReadLine();
            Arrays.AddRevista(novaRevista);
        }
        public void CadastrarEmprestimo()
        {
            Emprestimo novoEmprestimo = new Emprestimo();

            Console.WriteLine("Qual o nome do amigo que pegou? ");
            novoEmprestimo.amigoquepegou = Console.ReadLine();
            Console.WriteLine("Qual revista ele pegou? ");
            novoEmprestimo.qualrevista = Console.ReadLine();
            Console.WriteLine("Qual data ele pegou? ");
            novoEmprestimo.dataemprestimo = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Qual data ele precisa devolver? ");
            novoEmprestimo.datadevolucao = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Quantas revistas ele pegou? ");
            novoEmprestimo.quantrevista = Convert.ToInt32(Console.ReadLine());

            if (novoEmprestimo.quantrevista > 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O amiguinho só pode pegar uma revista por vez!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cadastro de empréstimo realizado com sucesso!");
                Console.ResetColor();
            }
            Console.ReadLine();
            Arrays.AddEmprestimo(novoEmprestimo);
        }

        public void CadastrarAmigo()
        {
            CadastroAmigo novoCadastro = new CadastroAmigo();

            Console.WriteLine("Qual o nome do amiguinho? ");
            novoCadastro.nomeAmigo = Console.ReadLine();
            Console.WriteLine("Qual o nome do responsável? ");
            novoCadastro.nomeResponsáve = Console.ReadLine();
            Console.WriteLine("Qual o telefone? ");
            novoCadastro.telefone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o endereço? ");
            novoCadastro.endereco = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadastro realizado com sucesso! ");
            Console.ResetColor();
            Console.ReadLine();
            Arrays.AddCadastro(novoCadastro);
        }
    
    }
}
