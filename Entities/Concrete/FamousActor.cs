using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FamousActor
    {
        public int FamousActorId { get; set; }
        public string  ActorName { get; set; }
        [JsonIgnore]
        public List<FilmFamousActor> FilmFamousActors { get; set; }
    }
}
