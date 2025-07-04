using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNSUIL_ConsoleApp_DataLoader.Models
{
    public class SoilMoisture
    {
        public int Id { get; set; }
        public string StationCode { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? AgencyName { get; set; }
        public string? State { get; set; }
        public string? District { get; set; }
        public string? MajorBasin { get; set; }
        public string? Tributary { get; set; }
        public string? DataAcquisitionMode { get; set; }
        public string? StationStatus { get; set; }
        public string? Tehsil { get; set; }
        public string? DatatypeCode { get; set; }
        public string? Description { get; set; }
        public double DataValue { get; set; }
        public DateTime DataTime { get; set; }
        public string? Unit { get; set; }
        public string? Block { get; set; }
        public string? Village { get; set; }
        public string? WellType { get; set; }
        public double? WellDepth { get; set; }
        public string? WellAquiferType { get; set; }

    }
}
