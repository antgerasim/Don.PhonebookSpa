using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.PhoneBookSpa.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Don.PhoneBookSpa.Web.Host.Startup
{
    [DependsOn(
       typeof(PhoneBookSpaWebCoreModule))]
    public class PhoneBookSpaWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhoneBookSpaWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookSpaWebHostModule).GetAssembly());
        }
    }
}
