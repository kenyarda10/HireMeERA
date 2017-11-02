using Login.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Abstract
{
    public interface IPostingRepository
    {
        IEnumerable<Posting> Postings { get; }
    }
}