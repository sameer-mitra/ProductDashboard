using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentLibrary
{
    public class Build
    {
        public string Environment { get; set; }
        public string BuildNumber {get; set;}
        public string Product { get; set; }
    }
}
