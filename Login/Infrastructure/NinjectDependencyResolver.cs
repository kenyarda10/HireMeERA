using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;

namespace Login.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            
            Mock<IPostingRepository> mock = new Mock<IPostingRepository>();
            mock.Setup(m => m.Postings).Returns(new List<Posting> {
            new Posting { jobTitle = "Football", jobDescription = "QB" },
            new Posting { jobTitle = "Surf board", jobDescription = "Shark" },
            new Posting { jobTitle = "Running shoes", jobDescription = "Sprinter" }
            });

            kernel.Bind<IPostingRepository>().ToConstant(mock.Object);
            
            //kernel.Bind<IPostingRepository>().To<EFPostingRepository>();
        }
    }
}