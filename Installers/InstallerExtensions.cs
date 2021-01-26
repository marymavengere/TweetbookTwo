using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetbookTwo.Installers
{
    public class InstallerExtensions
    {
        public static void InstallerServicesInAssembly(this IServiceCollection services,IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes.Where(x =>
            typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList;

            installers.ForEach(installer => installer.InstallServices(services, Configuration));
        }
    }
}
