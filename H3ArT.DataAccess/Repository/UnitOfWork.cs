using H3ArT.DataAccess.Data;
using H3ArT.DataAccess.Repository.IRepository;
using H3ArT.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3ArT.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        //Eg public ICategoryRepository CategoryRepository {get;private set;}
        public ICategoryRepository CategoryObj { get; private set; }


        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            CategoryObj = new CategoryRepository(_db);
            //Eg Category = new CategoryRepository(_db);

        }



        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
