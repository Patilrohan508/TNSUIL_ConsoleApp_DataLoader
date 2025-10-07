using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNSUIL_ConsoleApp_DataLoader.DTOs
{
    
    public class TempMap
    {
        public int? statusCode { get; set; }
        public string? message { get; set; }
        public List<TempData>? data { get; set; }
    }

    public class TempData
    {
        public string? datatypeCode { get; set; }
        public string? datatypeDescription { get; set; }
        public string? dataTime { get; set; }
        public double? dataValue { get; set; }
        public string? unitCode { get; set; }
    }

    

}

