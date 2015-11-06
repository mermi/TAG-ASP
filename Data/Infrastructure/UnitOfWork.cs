using Data;
using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private vgtaContext dataContext;
        protected vgtaContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }


        private IArticleRepository articleRepository;
        public IArticleRepository ArticleRepository
        {
            get { return articleRepository = new ArticleRepository(dbFactory); ; }
        }




        public void Dispose()
        {
            DataContext.Dispose();
        }

    }
}
