using DataMigration.Data.Contex;
using DataMigration.Data.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Quartz;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataMigration.Scheduler.Schedule
{
    public class ScheduledJob : IJob
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<ScheduledJob> logger;


        public ScheduledJob(IConfiguration configuration, ILogger<ScheduledJob> logger)
        {
            this.logger = logger;
            this.configuration = configuration;
        }

        public async Task Execute(IJobExecutionContext context)
        {

            this.logger.LogWarning($"Hello from scheduled task {DateTime.Now.ToLongTimeString()}");

            //string jsonFile = "data.json";
            //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", jsonFile);
            //var json = File.ReadAllText(path);
            //var jObject = JObject.Parse(json);

            //var content = new ERPContext();

            //try
            //{

            //    foreach (var item in jObject["coworker"])
            //    {
            //        if (content.Users.Any(t => t.CoworkerId != (int?)item["CoworkerCode"]))
            //        {
            //            var objUser = new User();
            //            // objUser.UserId = item["UserID"].ToString();
            //            objUser.CoworkerId = (int?)item["CoworkerCode"];
            //            objUser.FirstName = item["FirstName"].ToString();
            //            objUser.LastName = item["LastName"].ToString();
            //            objUser.Email = item["EmailAddress"].ToString();
            //            objUser.ReportingManagerId = (int)item["ManagerCoworkerCode"];
            //            objUser.DepartmentId = (int)item["CoworkerGLDepartmentCode"];
            //            objUser.Designation = item["CoworkerTitleDescription"].ToString();
            //            objUser.IsActive = true;

            //            content.Users.Add(objUser);
            //        }

            //    }
            //    content.SaveChanges();

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            await Task.CompletedTask;
            
        }
    }
}
