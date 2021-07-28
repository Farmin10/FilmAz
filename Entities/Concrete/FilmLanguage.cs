using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FilmLanguage
    {
        //public int FilmLanguageId { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
