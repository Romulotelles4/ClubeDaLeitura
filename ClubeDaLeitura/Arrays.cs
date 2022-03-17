using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    public class Arrays
    {
        public static Revista[] revistas = new Revista[100];
        public static Emprestimo[] emprestimos = new Emprestimo[100];
        public static CadastroAmigo[] cadastroAmigos = new CadastroAmigo[100];


        public static void AddRevista(Revista revista) 
        {
            for(int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null)
                {
                    revistas[i] = revista;
                    break;
                }
            }
            
        }

        public static void AddEmprestimo(Emprestimo emprestimo)
        {
            for (int i = 0; i < emprestimos.Length; i++)
            {
                if (emprestimos[i] == null)
                {
                    emprestimos[i] = emprestimo;
                    break;
                }
                
            }

        }

        public static void AddCadastro(CadastroAmigo cadastro)
        {
            for (int i = 0; i < cadastroAmigos.Length; i++)
            {
                if (cadastroAmigos[i] == null)
                {
                    cadastroAmigos[i] = cadastro;
                    break;
                }
            }

        }
    }
}
