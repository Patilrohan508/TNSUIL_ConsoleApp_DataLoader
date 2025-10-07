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
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

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

//string[] districts = new string[]
//{
//    "Ariyalur","Chengalpattu","Chennai","Coimbatore","Cuddalore","Dharmapuri","Dindigul","Erode","Kallakurichi","Kanchipuram",
//    "Kanniyakumari","Karur","Krishnagiri","Madurai","Mayiladuthurai","Nagapattinam","Namakkal","Nilgiris","Perambalur","Pudukkottai",
//    "Ramanathapuram","Ranipet","Salem","Sivaganga","Tenkasi","Thanjavur","Theni","Thoothukudi","Tiruchirappalli","Tirunelveli",
//    "Tirupathur","Tiruppur","Tiruvallur","Tiruvannamalai","Tiruvarur","Vellore","Viluppuram","Virudhunagar"
//};
//string stateName = "Tamil nadu";
//string[] districts = new string[]
//{
//    "Chengalpattu","Coimbatore","Cuddalore","Dharmapuri",
//    "Dindigul","Erode","Kallakurichi","Kanyakumari",
//    "Karur","Krishnagiri","Namakkal","Pudukkottai",
//    "Ramanathapuram","Sivaganga","Thanjavur",
//    "Theni","Thoothukudi","Tiruchirappalli","Tirunelveli","Tiruppur",
//    "Tiruvallur","Tiruvannamalai","Tiruvarur",
//    "Tuticorin","Vellore","Viluppuram","Virudhunagar"
//};
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

//var startdate = DateTime.Parse("2015-01-01");
//var curdate = DateTime.Now;

//List<(string State, string District, string StartDate, string EndDate)> tuples = new();

//string start_date = startdate.ToString("yyyy-MM-dd");
//string end_date = curdate.ToString("yyyy-MM-dd");

//foreach (var district in districts)
//{
//    tuples.Add((stateName, district, start_date, end_date));
//}



var temperatureRecords = new List<LoopObject>
{
    new LoopObject { stationid = "TNSWAWSCGP0002", District = "Karunkuzhi", StartDate = DateTime.ParseExact("04/11/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSCBE0018", District = "Chithraichavadi anicut", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSCBE0017", District = "Sethumadai", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSCUD0006", District = "Lekkur", StartDate = DateTime.ParseExact("23/07/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSCUD0005", District = "Palur", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSDPI0012", District = "Vaniyar reservoir", StartDate = DateTime.ParseExact("01/05/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSDGL0033", District = "Kamachipuram", StartDate = DateTime.ParseExact("14/06/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSDGL0034", District = "Viralipatti", StartDate = DateTime.ParseExact("01/05/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSERD0015", District = "Bavanisagar dam", StartDate = DateTime.ParseExact("30/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSERD0014", District = "Lbp quarters campus", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSVPM0004", District = "Tirukoilur", StartDate = DateTime.ParseExact("28/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSKKI0045", District = "Aralvaimozhi", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSKUR0022", District = "K paramathi", StartDate = DateTime.ParseExact("17/10/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSKUR0021", District = "Mayanur", StartDate = DateTime.ParseExact("16/06/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSKRI0010", District = "Krishnagiri reservoir", StartDate = DateTime.ParseExact("17/03/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSKRI0011", District = "Melumalai", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSNKL0013", District = "Mangalapuram", StartDate = DateTime.ParseExact("04/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSPDU0025", District = "Pudukkottai", StartDate = DateTime.ParseExact("28/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSPDU0026", District = "Raya raghunatha samudiram", StartDate = DateTime.ParseExact("11/09/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSRMD0040", District = "Parthibanur regulator", StartDate = DateTime.ParseExact("28/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSSVG0039", District = "Kundrakudi", StartDate = DateTime.ParseExact("20/10/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTJR0029", District = "Kurungulam", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTJR0028", District = "Lower anicut", StartDate = DateTime.ParseExact("09/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTJR0030", District = "Thanjavur", StartDate = DateTime.ParseExact("24/04/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "016-SRDCBE", District = "Theni", StartDate = DateTime.ParseExact("01/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTNI0035", District = "Mayiladumparai", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTHO0042", District = "Kalampatti", StartDate = DateTime.ParseExact("28/03/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTHO0041", District = "Keelaeral", StartDate = DateTime.ParseExact("01/05/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "013-SRDCBE", District = "Musiri", StartDate = DateTime.ParseExact("01/12/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTJR0027", District = "Grand anicut", StartDate = DateTime.ParseExact("14/04/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTRY0023", District = "Perambalur", StartDate = DateTime.ParseExact("24/04/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTRY0024", District = "Upper anicut", StartDate = DateTime.ParseExact("02/03/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTNV0043", District = "Cheranmahadevi", StartDate = DateTime.ParseExact("10/12/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTNV0044", District = "Nambiyar", StartDate = DateTime.ParseExact("29/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTPR0019", District = "Sundakkampalyam", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSCBE0016", District = "Uppar dam", StartDate = DateTime.ParseExact("26/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTPR0020", District = "Uthampalayam", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTRL0001", District = "Poondi reservoir", StartDate = DateTime.ParseExact("28/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTVM0007", District = "Dusi ayyangarkulam", StartDate = DateTime.ParseExact("24/04/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTVM0008", District = "Kilnatcipatu", StartDate = DateTime.ParseExact("31/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTVR0031", District = "Koradachery", StartDate = DateTime.ParseExact("06/11/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSTVR0032", District = "Thiruthuraipoondi", StartDate = DateTime.ParseExact("28/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSVEL0009", District = "Gollapally", StartDate = DateTime.ParseExact("21/07/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSVPM0003", District = "Kiladayalam", StartDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSVRN0038", District = "Kavalur", StartDate = DateTime.ParseExact("28/09/2021", "dd/MM/yyyy",CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSVRN0036", District = "Savaspuram", StartDate = DateTime.ParseExact("28/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
    new LoopObject { stationid = "TNSWAWSVRN0037", District = "Vembakottai dam", StartDate = DateTime.ParseExact("28/09/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture) }

};

List<Task> tasks = new List<Task>();
var semaphore = new SemaphoreSlim(10); // Limit to 5 concurrent requests

foreach (var utility in context.TblStations.Where(x => x.Utility == "Temperature").ToList())
{

    Console.WriteLine($"Station: {utility.URL}, Code: {utility.Utility}");
    foreach (var records in temperatureRecords)
    {
        //https://indiawris.gov.in/Dataset/Wind Direction?stateName=Tamil%20nadu&districtName=Chennai&agencyName=CWC&startdate=2015-01-01&enddate=2025-01-01&download=false&page=0&size=1000

        StationRequest requestObj = new StationRequest();
        requestObj.Agency = utility.Agency.Replace(" ", "%20");
        requestObj.Domain = utility.URL;
        requestObj.District = records.District.Replace(" ", "%20");
        requestObj.EndDate = records.EndDate.ToString("yyyy-MM-dd");
        requestObj.StartDate = records.StartDate.ToString("yyyy-MM-dd");
        requestObj.StateName = utility.StateName.Replace(" ", "%20");
        requestObj.StationId = records.stationid;
        requestObj.UtilityName = utility.Utility;




        string start_date = records.StartDate.ToString("yyyy-MM-dd");
        string enddate = records.EndDate.ToString("yyyy-MM-dd");
        string domain = utility.URL;    //.Replace(" ", "%20");
        string stationid = records.stationid;
        string statename = utility.StateName.Replace(" ", "%20");
        string agency = utility.Agency.Replace(" ", "%20");
        string utilityName = utility.Utility;
        string district = records.District.Replace(" ", "%20");

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

        if (utilityName == "Ground Water Level")
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

        else if (utilityName == "RainFall")
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
            var resultet = await api.Temperature(requestObj);
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



//Console.WriteLine($"Completed data loading has been done!");


//var app = scope.ServiceProvider.GetRequiredService<App>();
//await app.RunAsync();


//var curdate = DateTime.Now;

//foreach (var utility in context.TblStations.Where(x => x.Utility == "Temperature").ToList())
//{
//    string domain = utility.URL;
//    string statename = utility.StateName.Replace(" ", "%20");
//    string agency = utility.Agency.Replace(" ", "%20");
//    string utilityName = utility.Utility;

//    foreach (var record in temperatureRecords)
//    {
//        string start_date = record.DataTime.ToString("yyyy-MM-dd");
//        string end_date = curdate.ToString("yyyy-MM-dd"); // always current date

//        var result = await api.Temperature(
//            $"{domain}?stateName={statename}&districtName={record.District.Replace(" ", "%20")}" +
//            $"&agencyName={agency}&startdate={start_date}&enddate={end_date}&download={utility.download}&page={utility.page}&size={utility.size}",
//            utilityName,
//            record.District
//        );

//        Console.WriteLine(result);
//    }
//}



public class LoopObject
{
    public string stationid { get; set; }
    public string District { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; } = DateTime.Now;
}

public class StationRequest
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Domain { get; set; }
    public string StationId { get; set; }
    public string StateName { get; set; }
    public string Agency { get; set; }
    public string UtilityName { get; set; }
    public string District { get; set; }

}