using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Trabalho_Blog
{
    internal class Menu
    {
        public int ExibeMenu()
        {
            Console.WriteLine("BLOG: O que você quer fazer?\r\n" +
                "1. Novo post de notícia\r\n" +
                "2. Nova resenha de produto\r\n" +
                "3. Novo post de outros assuntos\r\n" +
                "4. Listar todas as postagens\r\n" +
                "5. Curtir uma postagem\r\n" +
                "6. Nao curtir uma postagem\r\n" +
                "0. Sair\r\n");

            Console.Write("Digite a sua opção:");
            int opcao = int.Parse(Console.ReadLine()!);

            return opcao;

        }
    }
}
