using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3ArT.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        //Single Interface
        //Eg: ICategoryRepository CategoryRepository {get;}
        void Save();
    }
}
