using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitUsage1AndParameterizedOptionalParameters
{
    class OptiomalParameters
    {
        public static void OrderDdetails(string sellerName,string ProductName,int OrderQuantity=1,bool IsReturnable=true)
        {
            Console.WriteLine("Here is the order detail "+OrderQuantity+"number of "+ProductName+" By "+sellerName+" is ordered.It is returnable status is "+IsReturnable+" . ");

        }
        static void Main(string[] args)
        {
            OrderDdetails("Amazon India", "Mobile");
            OrderDdetails("Flipkart", "Shoes", 2, false);
            Console.ReadLine();

        }
    }
}
