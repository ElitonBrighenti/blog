using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Blog
{
    internal class News : Post
    {
        public string Source {  get; set; }

        public override void Show()
        {
            Console.WriteLine($"\nEXIBINDO POST NOTICIA:" +
            $"\nTítulo: {Title}\n" +
            $"Data: {Date}\n" +
            $"Conteúdo: {Content}\n" +
            $"Fonte: {Source}\n" +
            $"Likes: {Likes}, Dislikes: {Dislikes}");
        }
    }
}
