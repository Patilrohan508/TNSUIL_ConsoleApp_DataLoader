using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TNSUIL_ConsoleApp_DataLoader.DLL;
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

                var result = dll.Atmospheric_Pressure(stationWrapper.Data, utility,district);

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

                var result = dll.Evapo_Transpiration(stationWrapper.Data, utility, district);

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

                var result =  dll.Ground_Water_Level(stationWrapper.Data, utility, district);

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

                var result = dll.RainFall(stationWrapper.Data, utility, district);

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

                var result = dll.Relative_Humidity(stationWrapper.Data, utility, district);

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

                var result = dll.Reservoir(stationWrapper.Data, utility, district);

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

                var result = dll.River_Water_Discharge(stationWrapper.Data, utility, district);

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

                var result = dll.River_Water_Level(stationWrapper.Data, utility, district);

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

                var result = dll.Soil_Moisture(stationWrapper.Data, utility, district);

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

                var result = dll.Solar_Radiation(stationWrapper.Data, utility, district);

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

                var result = dll.Suspended_Sediment(stationWrapper.Data, utility, district);

                return result;
            }
            catch (Exception ex)
            {
                // Log or handle error  
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> Temperature(string url, string utility, string district)
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

                var result = dll.Temperature(stationWrapper.Data, utility, district);

                return result;
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

                var result = dll.Wind_Direction(stationWrapper.Data, utility, district);

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
