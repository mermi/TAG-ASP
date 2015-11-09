 

using  Data.Infrastructure;
using  Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.Models;

namespace  Data.Repositories
{
    public class ArticleRepository : RepositoryBase<article>, IArticleRepository
    {

        public ArticleRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IArticleRepository : IRepository<article>
    {

    }
}
