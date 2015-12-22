using Microsoft.AspNet.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateDesignPatternDemo
{
    public class Startup : TemplatedStartup
    {
        public Startup(IHostingEnvironment env):base(env)
        {

        }
    }
}
