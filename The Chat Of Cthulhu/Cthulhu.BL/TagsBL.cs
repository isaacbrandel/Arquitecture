using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cthulhu.BL
{
   public class TagsBL
    {
        public List<Tags> Tags()
        {
            var Tags1 = new Tags();
            Tags1.Nombre = "Terror";
            var Tags2 = new Tags();
            Tags2.Nombre = "Drama";
            var Tags3 = new Tags();
            Tags3.Nombre = "Infantil";
            var ListaTags = new List<Tags>();
            ListaTags.Add(Tags1);
            ListaTags.Add(Tags2);
            ListaTags.Add(Tags3);

            return ListaTags;
        }

    }
}
