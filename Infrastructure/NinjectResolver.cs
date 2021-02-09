using Ninject;
using Ninject.Extensions.ChildKernel;
using Repository.CaseDataRepository;
using Repository.CheckListDataRepository;
using Repository.PropertyDataRepository;
using Repository.UserDataRepository;
using Services.Case;
using Services.CheckList;
using Services.Property;
using Services.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace RCMSWebAPI.Infrastructure
{
    public class NinjectResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectResolver() : this(new StandardKernel())
        {
        }

        public NinjectResolver(IKernel ninjectKernel, bool scope = false)
        {
            kernel = ninjectKernel;
            if (!scope)
            {
                AddBindings(kernel);
            }
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectResolver(AddRequestBindings(new ChildKernel(kernel)), true);
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public void Dispose()
        {

        }

        private void AddBindings(IKernel kernel)
        {
            // singleton and transient bindings go here
        }

        private IKernel AddRequestBindings(IKernel kernel)
        {
           
            kernel.Bind<ICaseService>().To<CaseService>().InSingletonScope();
            kernel.Bind<ICaseRepository>().To<CaseRepository>().InSingletonScope();
            kernel.Bind<IUserDataService>().To<UserDataService>().InSingletonScope();
            kernel.Bind<IUserRepository>().To<UserRepository>().InSingletonScope();
            kernel.Bind<IPropertyService>().To<PropertyService>().InSingletonScope();
            kernel.Bind<IPropertyRepository>().To<PropertyRepository>().InSingletonScope();
            kernel.Bind<ICheckListService>().To<CheckListService>().InSingletonScope();
            kernel.Bind<ICheckListRepository>().To<CheckListRepository>().InSingletonScope();
            return kernel;
        }
    }
}