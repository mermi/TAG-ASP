using Data.Infrastructure;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ArticleService : IArticleService
    {
        public static DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utwk = new UnitOfWork(dbFactory);
        public void AddArticle(article a)
        {
            utwk.ArticleRepository.Add(a);
            utwk.Commit();
        }

        public List<article> getAllArticles()
        {
            return utwk.ArticleRepository.GetAll().ToList();
        }

        public article getArticle(int id)
        {
            article a = new article();
            a = utwk.ArticleRepository.GetById(id);
            return a;
        }

        public article UpdateArticle(article a )
        {
          
            utwk.ArticleRepository.Update(a);
            return a;
        }

    }

    public interface IArticleService
    {
        void AddArticle(article a);
        List<article> getAllArticles();
        article getArticle(int id);
        article UpdateArticle(article a );
    }
}
