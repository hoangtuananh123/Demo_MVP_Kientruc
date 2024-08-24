using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVP_QL.View.Banan_View
{
    internal interface IAddBanan
    {
         int BananId { get; set; }
         string BananName { get; set; }
         Boolean BananStatus { get; set; }

        String Message { get; set; }



    }
}
