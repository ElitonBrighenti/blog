using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Blog
{
    internal class ProductReview : Post
    {
        public string Brand {  get; set; }
        public string Stars { get; set; }

        public override void Show()
        {
            Console.WriteLine($"\nEXIBINDO POST REVIEW PRODUTO:" +
            $"\nTítulo: {Title}\n" +
            $"Data: {Date}\n" +
            $"Conteúdo: {Content}\n" +
            $"Marca: {Brand}\n" +
            $"Avaliacao: {Brand}\n" +
            $"Likes: {Likes}, Dislikes: {Dislikes}");
        }
    }
}
