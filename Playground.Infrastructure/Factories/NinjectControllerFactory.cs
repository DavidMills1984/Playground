using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Playground.Model.Interfaces;
using Playground.Data.Concrete;
using Playground.Service;



namespace Playground.Infrastructure.Factories
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext,
        Type controllerType)
        {
            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            // put additional bindings here
            ninjectKernel.Bind<ILayoutRepository>().To<LayoutRepository>();
            ninjectKernel.Bind<ILayoutService>().To<LayoutService>();
            ninjectKernel.Bind<IHeaderRepository>().To<HeaderRepository>();

        }
    }
}