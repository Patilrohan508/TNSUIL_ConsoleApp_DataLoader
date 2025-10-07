using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNSUIL_ConsoleApp_DataLoader.Models
{
    //[Table("tblstations", Schema = "public")]

    public class TblStations
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Agency { get; set; }
        public string Utility { get; set; }
        public string StateName { get; set; }
        public string download { get; set; }
        public int page { get; set; }
        public int size { get; set; }
    }
}
