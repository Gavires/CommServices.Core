using CommServices.Core.Abstract.Repository;
using CommServices.Core.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommServices.Core.DependencyInjection {
    public class ServiceManager {
        protected static IServiceProvider ServiceProvider = null;

        public static T GetService<T>() => ServiceProvider.GetService<T>();

        public void RegisterModules(IServiceCollection services = null, bool registerLogging = false) {
            services = services ?? new ServiceCollection();

            services.AddScoped<IUserRepository, UserRepository>();

            //services.Scan(scan => scan.FromAssemblyOf<BaseDbContext>()
            //    .AddClasses(x => x.AssignableTo(typeof(ReadOnlyRepository<,>)))
            //    .AsImplementedInterfaces()
            //    .WithScopedLifetime());
            //services.Scan(scan => scan.FromAssemblyOf<IMailer>()
            //    .AddClasses()
            //    .AsImplementedInterfaces()
            //    .WithScopedLifetime());
            //services.Scan(scan => scan.FromAssemblyOf<MdsDb>()
            //    .AddClasses(x => x.AssignableTo(typeof(ReadOnlyRepository<,>)))
            //    .AsImplementedInterfaces()
            //    .WithScopedLifetime());


            ServiceProvider = services.BuildServiceProvider();
        }

    }
}
