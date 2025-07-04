// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using TNSUIL_ConsoleApp_DataLoader.DBContextClass;
using TNSUIL_ConsoleApp_DataLoader.BLL;
using TNSUIL_ConsoleApp_DataLoader.DLL;
using System.Configuration;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;
using TNSUIL_ConsoleApp_DataLoader;
using TNSUIL_ConsoleApp_DataLoader.Models;
using System.Threading.Tasks;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(config =>
    {
        config.AddJsonFile("appsettings.json", optional: false);
    })
    .ConfigureServices((context, services) =>
    {
        var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<DBContext>(options =>
            options.UseNpgsql(connectionString)); // Use UseNpgsql for PostgreSQL

        services.AddScoped<HttpClient>();
        services.AddScoped<IAPI,API>();
        services.AddScoped<IDataLogic, DataLogic>();
        services.AddAutoMapper(typeof(Program)); // Register AutoMapper with all profiles in the assembly
        //services.AddAutoMapper(typeof(MappingProfile));
    })
    .Build();



using var scope = host.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<DBContext>();
var api = scope.ServiceProvider.GetRequiredService<IAPI>();

//string[] districts = ["Chengalpattu", "Coimbatore", "Cuddalore", "Dharmapuri", "Dindigul", "Erode",
//  "Kallakurichi", "Kanyakumari", "Karur", "Krishnagiri", "Namakkal", "Pudukkottai",
//  "Ramanathapuram", "Sivaganga", "Thanjavur", "Theni", "Thoothukudi", "Tiruchirappalli",
//  "Tirunelveli", "Tiruppur", "Tiruvallur", "Tiruvannamalai", "Tiruvarur", "Vellore",
//  "Viluppuram", "Virudhunagar" ];

string[] districts = new string[]
{
    "Ariyalur","Chengalpattu","Chennai","Coimbatore","Cuddalore","Dharmapuri","Dindigul","Erode","Kallakurichi","Kanchipuram",
    "Kanniyakumari","Karur","Krishnagiri","Madurai","Mayiladuthurai","Nagapattinam","Namakkal","Nilgiris","Perambalur","Pudukkottai",
    "Ramanathapuram","Ranipet","Salem","Sivaganga","Tenkasi","Thanjavur","Theni","Thoothukudi","Tiruchirappalli","Tirunelveli",
    "Tirupathur","Tiruppur","Tiruvallur","Tiruvannamalai","Tiruvarur","Vellore","Viluppuram","Virudhunagar"
};

//Console.Write("Enter Start Date (yyyy-MM-dd): ");
//string? startInput = Console.ReadLine(); // Use nullable type string?

//Console.Write("Enter End Date (yyyy-MM-dd): ");
//string? endInput = Console.ReadLine(); // Use nullable type string?

//if (!string.IsNullOrEmpty(startInput) && !string.IsNullOrEmpty(endInput) &&
//   DateTime.TryParse(startInput, out DateTime startDate) &&
//   DateTime.TryParse(endInput, out DateTime endDate))
//{
//    Console.WriteLine($"Start Date: {startDate:yyyy-MM-dd}");
//    Console.WriteLine($"End Date: {endDate:yyyy-MM-dd}");
//}
//else
//{
//    Console.WriteLine("Invalid date format or empty input. Please use yyyy-MM-dd.");
//}

var startdate = DateTime.Parse("2015-01-01");
var curdate = DateTime.Now;

List<Task> tasks = new List<Task>();
//var semaphore = new SemaphoreSlim(10); // Limit to 5 concurrent requests

foreach (var utility in context.TblStations.ToList())
{   

    Console.WriteLine($"Station: {utility.URL}, Code: {utility.Utility}");
    foreach(var district in districts)
    {
        //https://indiawris.gov.in/Dataset/Wind Direction?stateName=Tamil%20nadu&districtName=Chennai&agencyName=CWC&startdate=2015-01-01&enddate=2025-01-01&download=false&page=0&size=1000

        string start_date = startdate.ToString("yyyy-MM-dd");
        string enddate = curdate.ToString("yyyy-MM-dd");
        string domain = utility.URL;    //.Replace(" ", "%20");
        string statename = utility.StateName.Replace(" ", "%20");
        string agency = utility.Agency.Replace(" ", "%20");
        string utilityName = utility.Utility;


        //if (utilityName == "Atmospheric Pressure")
        //{
        //   // for (int i = 0; i <= utility.page; i++)
        //   // {
        //        //tasks.Add(Task.Run(async () =>
        //        //{
        //            var resultap = await api.Atmospheric_Pressure($"{domain}?stateName={statename}&districtName={district}" +
        //            $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
        //            Console.WriteLine(resultap);

            //            Console.WriteLine("Atmospheric Pressure has been looped");
            //       // }));
            //    //}

            //    //await Task.WhenAll(tasks);

            //}

        //if (utilityName == "Evapo Transpiration")
        //{
            

        //    var resultet = await api.Evapo_Transpiration($"{domain}?stateName={statename}&districtName={district}" +
        //    $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
        //    Console.WriteLine(resultet);

            

        //}

         if(utilityName == "Ground Water Level")
            {

                //    for(int i = 0; i <= utility.page; i++)
                //    {
                //        tasks.Add(Task.Run(async () =>
                //        {
                var resultet = await api.Ground_Water_Level($"{domain}?stateName={statename}&districtName={district}" +
                    $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
                    Console.WriteLine(resultet);

                    Console.WriteLine("Ground Water Level has been looped");
                //        }));
                //    }u

                //    await Task.WhenAll(tasks);


        }

        else if(utilityName == "RainFall")
        {
            //    for (int i = 0; i <= utility.page; i++)
            //    {
            //        tasks.Add(Task.Run(async () =>
            //        {
            var resultet = await api.RainFall($"{domain}?stateName={statename}&districtName={district}" +
            $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
            Console.WriteLine(resultet);

            Console.WriteLine("RainFall has been looped");
            //        }));
        }

        //    await Task.WhenAll(tasks);


        //}

        else if (utilityName == "Relative Humidity")
        {
        //    for (int i = 0; i <= utility.page; i++)
        //    {
        //        tasks.Add(Task.Run(async () =>
        //        {
                var resultet = await api.Relative_Humidity($"{domain}?stateName={statename}&districtName={district}" +
                $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
                Console.WriteLine(resultet);

                Console.WriteLine("Relative Humidity has been looped");
        //        }));
        }

            //    await Task.WhenAll(tasks);


            //}

        else if (utilityName == "Reservoir")
        {
            //    for (int i = 0; i <= utility.page; i++)
            //    {
            //        tasks.Add(Task.Run(async () =>
            //        {
            var resultet = await api.Reservoir($"{domain}?stateName={statename}&districtName={district}" +
            $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
            Console.WriteLine(resultet);

            Console.WriteLine("Reservoir has been looped");
            //        }));
        }

        //    await Task.WhenAll(tasks);


        //}

        else if (utilityName == "River Water Discharge")
        {
        //    for (int i = 0; i <= utility.page; i++)
        //    {
        //        tasks.Add(Task.Run(async () =>
        //        {
                var resultet = await api.River_Water_Discharge($"{domain}?stateName={statename}&districtName={district}" +
                $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
                Console.WriteLine(resultet);

        //            Console.WriteLine("River Water Discharge has been looped");
        //        }));
            }

            //    await Task.WhenAll(tasks);


            //}

        else if (utilityName == "River Water Level")
        {
            //    for (int i = 0; i <= utility.page; i++)
            //    {
            //        tasks.Add(Task.Run(async () =>
            //        {
            var resultet = await api.River_Water_Level($"{domain}?stateName={statename}&districtName={district}" +
            $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
            Console.WriteLine(resultet);

            Console.WriteLine("River Water Level has been looped");
        //        }));

        }

        //    await Task.WhenAll(tasks);

        //}

        else if (utilityName == "Soil Moisture")
        {
            //    for (int i = 0; i <= utility.page; i++)
            //    {
            //        tasks.Add(Task.Run(async () =>
            //        {
            var resultet = await api.Soil_Moisture($"{domain}?stateName={statename}&districtName={district}" +
            $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
            Console.WriteLine(resultet);

            Console.WriteLine("Soil Moisture has been looped");
            //        }));

        }

        //    await Task.WhenAll(tasks);


        //}

        else if (utilityName == "Solar Radiation")
        {
            //    for (int i = 0; i <= utility.page; i++)
            //    {
            //        tasks.Add(Task.Run(async () =>
            //        {
            var resultet = await api.Solar_Radiation($"{domain}?stateName={statename}&districtName={district}" +
            $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
            Console.WriteLine(resultet);

             Console.WriteLine("Solar Radiation has been looped");
            //        }));

        }

        //    await Task.WhenAll(tasks);

        //}

        else if (utilityName == "Suspended Sediment")
        {
            //    for (int i = 0; i <= utility.page; i++)
            //    {
            //        tasks.Add(Task.Run(async () =>
            //        {
            var resultet = await api.Suspended_Sediment($"{domain}?stateName={statename}&districtName={district}" +
            $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
            Console.WriteLine(resultet);

            Console.WriteLine("Suspended Sediment has been looped");
        //        }));

         }

                //    await Task.WhenAll(tasks);

                //}

        else if (utilityName == "Temperature")
        {
            //    for (int i = 0; i <= utility.page; i++)
            //    {
            //        tasks.Add(Task.Run(async () =>
            //        {
            var resultet = await api.Temperature($"{domain}?stateName={statename}&districtName={district}" +
            $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
            Console.WriteLine(resultet);

            Console.WriteLine("Temperature has been looped");
            //        }));

        }

                //    await Task.WhenAll(tasks);

                //}

        else if (utilityName == "Wind Direction")
            {
                //    for (int i = 0; i <= utility.page; i++)
                //    {
                //        tasks.Add(Task.Run(async () =>
                //        {
                var resultet = await api.Wind_Direction($"{domain}?stateName={statename}&districtName={district}" +
                $"&agencyName={agency}&startdate={start_date}&enddate={enddate}&download={utility.download}&page={utility.page}&size={utility.size}", utilityName, district);
                Console.WriteLine(resultet);

                Console.WriteLine("Wind Direction has been looped");
                //        }));

            }
            //    await Task.WhenAll(tasks);


            //}

        }

    //await Task.WhenAll(tasks);
}



Console.WriteLine($"Completed data loading has been done!");


//var app = scope.ServiceProvider.GetRequiredService<App>();
//await app.RunAsync();