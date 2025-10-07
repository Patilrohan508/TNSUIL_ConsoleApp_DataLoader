using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TNSUIL_ConsoleApp_DataLoader.DBContextClass;
using TNSUIL_ConsoleApp_DataLoader.DTOs;
using TNSUIL_ConsoleApp_DataLoader.Models;
//using EFCore.BulkExtensions;


namespace TNSUIL_ConsoleApp_DataLoader.DLL
{
    public class DataLogic : IDataLogic
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;

        public DataLogic(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<string> Atmospheric_Pressure(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<AtmosphericPressure>>(model);

                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                //await _context.AtmosphericPressures.AddRangeAsync(mapped).ConfigureAwait(false);
                //await _context.SaveChangesAsync().ConfigureAwait(false);

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch(Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Evapo_Transpiration(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<EvapoTranspiration>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Ground_Water_Level(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<GroundWaterLevel>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> RainFall(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<RainFall>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Relative_Humidity(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<RelativeHumidity>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Reservoir(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<Reservoir>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> River_Water_Discharge(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<RiverWaterDischarge>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();
                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }
        public async Task<string> River_Water_Level(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<RiverWaterLevel>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Soil_Moisture(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<SoilMoisture>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Solar_Radiation(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<SoilMoisture>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();
                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Suspended_Sediment(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<Suspended_Sediment>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Temperature(List<TempData> model, string stationCode, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<Temperature>>(model, opt =>
                {
                    opt.Items["StationCode"] = stationCode;
                    opt.Items["District"] = district;
                });
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();


                return $"{mapped.Count} records saved successfully for {stationCode} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public async Task<string> Wind_Direction(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<WindDirection>>(model);
                await _context.AddRangeAsync(mapped);
                await _context.SaveChangesAsync();

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

    }
}
