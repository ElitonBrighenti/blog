using System.Runtime.CompilerServices;

namespace Trabalho_Blog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var blog = new Blog();

            while(true)
            {
                int opcaoEscolhida = menu.ExibeMenu();
                switch(opcaoEscolhida)
                {
                    case 1:
                        blog.NewNews(); 
                        break;
                    case 2:
                        blog.NewProduct();
                        break;
                    case 3:
                        blog.NewPost(); 
                        break;
                    case 4:
                        blog.ShowAll(); 
                        break;
                    case 5:
                        blog.LikePost();
                        break;
                    case 6:
                        blog.DislikePost();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do blog...");
                        return; // Encerra o programa
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            
        }
    }
}
