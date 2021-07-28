using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.RepositoryPattern;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfFilmFamousActorDal : EfEntityRepositoryBase<FilmFamousActor>,IFilmFamousActorDal
    {
        FilmContext _context;
        public EfFilmFamousActorDal(FilmContext context):base(context)
        {
            _context = context;
        }
    }
}
