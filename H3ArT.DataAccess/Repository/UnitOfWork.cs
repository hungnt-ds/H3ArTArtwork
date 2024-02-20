using H3ArT.DataAccess.Data;
using H3ArT.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3ArT.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            //Eg Category = new CategoryRepository(_db);
        }

        //Eg public ICategoryRepository CategoryRepository {get;private set;}


        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
