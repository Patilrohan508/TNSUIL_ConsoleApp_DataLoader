using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TNSUIL_ConsoleApp_DataLoader.Models;
using AutoMapper;
using TNSUIL_ConsoleApp_DataLoader.DTOs;

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

            CreateMap<TempData, Temperature>().ForMember(dest => dest.DataTime, opt => opt.MapFrom(src =>
                string.IsNullOrEmpty(src.dataTime)
                    ? DateTime.UtcNow  // fallback if null
                    : DateTime.SpecifyKind(DateTime.Parse(src.dataTime), DateTimeKind.Utc)
            ))
            .ForMember(dest => dest.DataValue, opt => opt.MapFrom(src => src.dataValue))
            .ForMember(dest => dest.StationCode, opt => opt.MapFrom((src, dest, destMember, context) =>
                context.Items["StationCode"]))
            .ForMember(dest => dest.District, opt => opt.MapFrom((src, dest, destMember, context) =>
                context.Items["District"]));



            CreateMap<MappingModel, WindDirection>();
        }
    }
}
