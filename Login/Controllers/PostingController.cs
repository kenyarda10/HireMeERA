using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Abstract;


namespace Login.Controllers
{
    public class PostingController : Controller
    {
        private IPostingRepository repository;

        public PostingController(IPostingRepository postingRepository)
        {
            this.repository = postingRepository;
        }

        public ViewResult Postings()
        {
            return View(repository.Postings);
        }
    }
}