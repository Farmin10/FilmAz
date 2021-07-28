using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string  LanguageName { get; set; }
        [JsonIgnore]
        public List<FilmLanguage> FilmLanguages { get; set; }
    }
}
