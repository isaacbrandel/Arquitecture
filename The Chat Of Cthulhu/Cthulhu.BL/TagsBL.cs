using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cthulhu.BL
{
   public class TagsBL
    {
        Contexto _contexto;
        public TagsBL()
        {
            _contexto = new Contexto();
            
            }
        
        public List<Tags> Tags()
        {
            _contexto.Categorias.ToList();

            var Tags1 = new Tags();
            Tags1.Nombre = "Terror";
            Tags1.Id = 1;
            var Tags2 = new Tags();
            Tags2.Nombre = "Drama";
            Tags2.Id = 2;
            var Tags3 = new Tags();
            Tags3.Nombre = "Infantil";
            Tags3.Id = 3;
            var ListaTags = new List<Tags>();
            ListaTags.Add(Tags1);
            ListaTags.Add(Tags2);
            ListaTags.Add(Tags3);

            return ListaTags;
        }

    }
}
