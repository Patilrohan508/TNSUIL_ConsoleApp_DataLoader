using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TNSUIL_ConsoleApp_DataLoader.DBContextClass;
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

        public string Atmospheric_Pressure(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<AtmosphericPressure>>(model);

                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                //await _context.AtmosphericPressures.AddRangeAsync(mapped).ConfigureAwait(false);
                //await _context.SaveChangesAsync().ConfigureAwait(false);

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch(Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Evapo_Transpiration(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<EvapoTranspiration>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Ground_Water_Level(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<GroundWaterLevel>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string RainFall(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<RainFall>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Relative_Humidity(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<RelativeHumidity>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Reservoir(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<Reservoir>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string River_Water_Discharge(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<RiverWaterDischarge>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }
        public string River_Water_Level(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<RiverWaterLevel>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Soil_Moisture(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<SoilMoisture>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Solar_Radiation(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<SoilMoisture>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Suspended_Sediment(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<Suspended_Sediment>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Temperature(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<Temperature>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

        public string Wind_Direction(List<MappingModel> model, string utility, string district)
        {
            try
            {
                if (model == null || model.Count == 0)
                {
                    return "No records to save.";
                }

                var mapped = _mapper.Map<List<WindDirection>>(model);
                _context.BulkInsert(mapped); // Wrap BulkInsert in Task.Run for async execution.  

                return $"{mapped.Count} records saved successfully for {utility} {district}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";

            }

        }

    }
}
