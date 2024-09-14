using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Trabalho_Blog
{
    internal class Blog
    {
        public List<Post> posts = new List<Post>();

        public void NewPost()
        {
            Console.Clear();
            Console.WriteLine("CRIANDO POST SIMPLES");
            var post = new Post();
            ReadData(post);
            posts.Add(post);
            LimpaTelaeMensagem("Noticia criada com sucesso");
        }
        public void NewNews()
        {
            Console.Clear();
            Console.WriteLine("CRIANDO POST DE NOTICIA\n");
            var postNews = new News();
            ReadData(postNews);
            posts.Add(postNews);
            LimpaTelaeMensagem("Noticia Criada com sucesso");
        }
        public void NewProduct()
        {
            Console.Clear();
            Console.WriteLine("CRIANDO POST DE PRODUTO\n");
            var postReview = new ProductReview();
            ReadData(postReview);
            posts.Add(postReview);
            LimpaTelaeMensagem("Review criando com sucesso");
        }
        public void ShowAll()
        {
            if(posts.Count == 0)
            {
                Console.WriteLine("\nNenhum post cadastrado");
            }
                
            foreach (var post in posts)
                {
                    post.Show();
                }
            LimpaTelaeMensagem("Fim da exibição...");

        }
        public void ReadData(Post post)
        {
            post.Date = DateTime.Now;

            Console.Write("Digite o titulo: ");
            post.Title = Console.ReadLine()!;

            Console.Write("Digite o conteudo: ");
            post.Content = Console.ReadLine()!;


            if (post is News postNews)
            {
                Console.Write("Digite a fonte: ");
                postNews.Source = Console.ReadLine()!;
            }

            else if (post is ProductReview postReview)
            {
                Console.Write("Digite a marca do produto: ");
                postReview.Brand = Console.ReadLine()!;

                Console.Write("Digite a avaliação do produto: ");
                postReview.Stars = Console.ReadLine()!;
            }
        }

        public void LimpaTelaeMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("\nPressione alguma tecla para continuar: ");
            Console.ReadKey();
            Console.Clear();
        }

        public void LikePost()
        {
            ShowAll(); 
            Console.Write("Digite o número da postagem que você deseja curtir: ");
            int indice = int.Parse(Console.ReadLine()!);
            if (posts == null || posts.Count == 0)
            {
                Console.WriteLine("Lista Vazia");
                LimpaTelaeMensagem("Voltando ao menu");
                return;
            }
            if (indice >= 0 && indice < posts.Count)
            {
                posts[indice].Like();
                Console.WriteLine("Postagem curtida com sucesso.");
                LimpaTelaeMensagem("Voltando ao menu");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
                LimpaTelaeMensagem("Voltando ao menu");
            }

        }
        public void DislikePost()
        {
            ShowAll(); // Exibe todas as postagens com números
            Console.Write("Digite o número da postagem que você deseja não curtir: ");
            int indice = int.Parse(Console.ReadLine()!);

            if (posts == null || posts.Count == 0)
            {
                Console.WriteLine("Lista Vazia");
                LimpaTelaeMensagem("Voltando ao menu");
                return;
            }

            if (indice >= 0 && indice < posts.Count)
            {
                posts[indice].Dislike();
                Console.WriteLine("Postagem curtida com sucesso.");
                LimpaTelaeMensagem("Voltando ao menu");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
                LimpaTelaeMensagem("Voltando ao menu");
            }
        }
    }
}
