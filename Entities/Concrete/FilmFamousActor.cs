using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FilmFamousActor
    {
        //public int FilmFamousActorId { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int FamousActorId { get; set; }
        public FamousActor  FamousActor{ get; set; }
        public bool IsMainRole { get; set; }
    }
}
