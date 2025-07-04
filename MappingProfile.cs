using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TNSUIL_ConsoleApp_DataLoader.Models;
using AutoMapper;

namespace TNSUIL_ConsoleApp_DataLoader
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MappingModel, AtmosphericPressure>();
            CreateMap<MappingModel, EvapoTranspiration>();
            CreateMap<MappingModel, GroundWaterLevel>();
            CreateMap<MappingModel, RainFall>();
            CreateMap<MappingModel, RelativeHumidity>();
            CreateMap<MappingModel, Reservoir>();
            CreateMap<MappingModel, RiverWaterDischarge>();
            CreateMap<MappingModel, RiverWaterLevel>();
            CreateMap<MappingModel, SoilMoisture>();
            CreateMap<MappingModel, SolarRadiation>();
            CreateMap<MappingModel, Suspended_Sediment>();
            CreateMap<MappingModel, Temperature>();
            CreateMap<MappingModel, WindDirection>();
        }
    }
}
