using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Blog
{
    internal class Post
    {
        public string Title {  get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int Likes {  get; set; }
        public int Dislikes { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"\n EXIBINDO POST:" +
                $"\nTítulo: {Title}\n" +
                $"Data: {Date}\n" +
                $"Conteúdo: {Content}\n" +
                $"Likes: {Likes}, Dislikes: {Dislikes}");
        }

        public void Like()
        {
            Likes++;
        }

        public void Dislike()
        {
            Dislikes++;
        }

    }
}
