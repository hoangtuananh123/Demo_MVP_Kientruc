﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVP_QL.View.Monan_View
{
    internal interface IaddMonan
    {
        int MonAnId { get; set; }
        string MonAnName { get; set; }
        float MonAnPrice { get; set; }
        int IdCategory { get; set; }
        String Message { get; set; }
    }
}
