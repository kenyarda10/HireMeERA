using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Concrete
{
    public class EFPostingRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Posting> Postings
        {
            get { return context.Postings; }
        }
    }
}