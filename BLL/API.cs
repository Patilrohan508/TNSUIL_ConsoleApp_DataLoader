using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TNSUIL_ConsoleApp_DataLoader.DLL;
using TNSUIL_ConsoleApp_DataLoader.DTOs;
using static System.Collections.Specialized.BitVector32;

namespace TNSUIL_ConsoleApp_DataLoader.BLL
{
    public class API : IAPI
    {
        private readonly HttpClient _httpClient;
        private readonly IDataLogic dll;
        public API(IDataLogic logic)
        {
            _httpClient = new HttpClient();
            dll = logic;
        }

        public async Task<string> Atmospheric_Pressure(string url,string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.Atmospheric_Pressure(stationWrapper.Data, utility,district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Evapo_Transpiration(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.Evapo_Transpiration(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Ground_Water_Level(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await  dll.Ground_Water_Level(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> RainFall(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.RainFall(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Relative_Humidity(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.Relative_Humidity(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Reservoir(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.Reservoir(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> River_Water_Discharge(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.River_Water_Discharge(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }


        public async Task<string> River_Water_Level(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.River_Water_Level(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Soil_Moisture(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.Soil_Moisture(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Solar_Radiation(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.Solar_Radiation(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Suspended_Sediment(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.Suspended_Sediment(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Temperature(StationRequest requestObj)
        {
            try
            {

                var body = new Dictionary<string, string>
                {
                    ["station_code"] = requestObj.StationId,
                    ["starttime"] = requestObj.StartDate,
                    ["endtime"] = requestObj.EndDate,
                    ["dataset"] = "MT_TEMP",
                };

                string json = JsonSerializer.Serialize(body);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("https://indiawris.gov.in/CommonDataSetMasterAPI/getCommonDataSetByStationCode", content);

                if (response.IsSuccessStatusCode)
                {

                    string responseBody = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    TempMap stationWrapper = JsonSerializer.Deserialize<TempMap>(responseBody, options);
                    if (stationWrapper?.data == null)
                    {
                        return $"Deserialization resulted in null for {requestObj.StationId} {requestObj.StartDate} {requestObj.EndDate}";
                    }

                    var result = await dll.Temperature(stationWrapper.data, requestObj.StationId, requestObj.District);

                    return "";

                }

                return "";

                //var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                //response.EnsureSuccessStatusCode(); // Throw if not success  
                //return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());

            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Wind_Direction(string url, string utility, string district)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, new StringContent(string.Empty));
                response.EnsureSuccessStatusCode(); // Throw if not success  

                string responseBody = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                ApiResponse<MappingModel>? stationWrapper = JsonSerializer.Deserialize<ApiResponse<MappingModel>>(responseBody, options);
                if (stationWrapper?.Data == null)
                {
                    return $"Deserialization resulted in null for {utility} {district} ";
                }

                var result = await dll.Wind_Direction(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

    }


    public class ApiResponse<T>
    {
        public int? StatusCode { get; set; }
        public string? Message { get; set; }
        public List<T>? Data { get; set; }
    }

}
