using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNSUIL_ConsoleApp_DataLoader.DLL
{
    public interface IDataLogic
    {
        public string Atmospheric_Pressure(List<MappingModel> model, string utility, string district);
        public string Evapo_Transpiration(List<MappingModel> model, string utility, string district);
        public string Ground_Water_Level(List<MappingModel> model, string utility, string district);
        public string RainFall(List<MappingModel> model, string utility, string district);
        public string Relative_Humidity(List<MappingModel> model, string utility, string district);
        public string Reservoir(List<MappingModel> model, string utility, string district);
        public string River_Water_Discharge(List<MappingModel> model, string utility, string district);
        public string River_Water_Level(List<MappingModel> model, string utility, string district);
        public string Soil_Moisture(List<MappingModel> model, string utility, string district);
        public string Solar_Radiation(List<MappingModel> model, string utility, string district);
        public string Suspended_Sediment(List<MappingModel> model, string utility, string district);
        public string Temperature(List<MappingModel> model, string utility, string district);
        public string Wind_Direction(List<MappingModel> model, string utility, string district);

    }
}
