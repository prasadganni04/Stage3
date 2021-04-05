using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitUsage1AndParameterizedOptionalParameters
{
    class NamedParameters
    {
        public void GetCohortDetails(string name,int count,string mode, string track,string currentmodule)
        {
            Console.WriteLine("It is"+name+"with "+count+"gencs undergoing training for "+track+"through"+mode+". The current module of training is"+currentmodule+".");
        }
        static void Main(string[] args)
        {
            NamedParameters np = new NamedParameters();
            np.GetCohortDetails("Prasad", 25, "obl", "dotnet", "asp.net");
            np.GetCohortDetails(name: "prasadganni", currentmodule: "ASP.NET", count: 10, mode: "OBL", track: "DOTNET");
            np.GetCohortDetails(currentmodule:"prasad",count:56,mode:"dotnet",track:"asp.net",name:"obl");
        }


    }
}
