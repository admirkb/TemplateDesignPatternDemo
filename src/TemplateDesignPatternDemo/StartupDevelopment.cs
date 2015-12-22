using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateDesignPatternDemo
{
    public class StartupDevelopment : TemplatedStartup
    {
        protected override LogLevel MinimumLogLevel { get { return LogLevel.Debug; } }

        protected override void SetupErrorPages(IApplicationBuilder app)
        {
            app.UseBrowserLink();
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();
        }

        public StartupDevelopment(IHostingEnvironment env):base(env)
        {

        }
    }
}
