using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetbookTwo
{
    public interface Installer
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
      
    }
}
