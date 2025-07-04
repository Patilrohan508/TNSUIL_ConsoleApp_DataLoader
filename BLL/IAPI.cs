using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNSUIL_ConsoleApp_DataLoader.BLL
{
    public interface IAPI
    {
        public Task<string> Atmospheric_Pressure(string url, string utility, string district);
        public Task<string> Evapo_Transpiration(string url, string utility, string district);
        public Task<string> Ground_Water_Level(string url, string utility, string district);
        public Task<string> RainFall(string url, string utility, string district);
        public Task<string> Relative_Humidity(string url, string utility, string district);
        public Task<string> Reservoir(string url, string utility, string district);
        public Task<string> River_Water_Discharge(string url, string utility, string district);
        public Task<string> River_Water_Level(string url, string utility, string district);
        public Task<string> Soil_Moisture(string url, string utility, string district);
        public Task<string> Solar_Radiation(string url, string utility, string district);
        public Task<string> Suspended_Sediment(string url, string utility, string district);
        public Task<string> Temperature(string url, string utility, string district);
        public Task<string> Wind_Direction(string url, string utility, string district);
    }
}
