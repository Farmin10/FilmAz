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
    public class EfLanguageDal : EfEntityRepositoryBase<Language>,ILanguageDal
    {
        FilmContext _context;
        public EfLanguageDal(FilmContext context):base(context)
        {
            _context = context;
        }
    }
}
