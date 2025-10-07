using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNSUIL_ConsoleApp_DataLoader.DTOs;

namespace TNSUIL_ConsoleApp_DataLoader.DLL
{
    public interface IDataLogic
    {
        public Task<string> Atmospheric_Pressure(List<MappingModel> model, string utility, string district);
        public Task<string> Evapo_Transpiration(List<MappingModel> model, string utility, string district);
        public Task<string> Ground_Water_Level(List<MappingModel> model, string utility, string district);
        public Task<string> RainFall(List<MappingModel> model, string utility, string district);
        public Task<string> Relative_Humidity(List<MappingModel> model, string utility, string district);
        public Task<string> Reservoir(List<MappingModel> model, string utility, string district);
        public Task<string> River_Water_Discharge(List<MappingModel> model, string utility, string district);
        public Task<string> River_Water_Level(List<MappingModel> model, string utility, string district);
        public Task<string> Soil_Moisture(List<MappingModel> model, string utility, string district);
        public Task<string> Solar_Radiation(List<MappingModel> model, string utility, string district);
        public Task<string> Suspended_Sediment(List<MappingModel> model, string utility, string district);
        public Task<string> Temperature(List<TempData> model, string stationCode, string district);
        public Task<string> Wind_Direction(List<MappingModel> model, string utility, string district);

    }
}
