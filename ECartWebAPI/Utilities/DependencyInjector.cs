using Autofac;
using ECart.Business.Service;
using ECart.Business.Service.Interface;
using ECart.Data.Repository;
using ECart.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECart.API.Utilities
{
    public class DependencyInjector : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CountryRepository>().As<ICountryRepository>();
            //builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<CountryService>().As<ICountryService>();
        }

    }
}
