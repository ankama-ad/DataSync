using DataMigration.Data.Contex;
using DataMigration.Data.Models;
using DataMigration.Main1.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataMigration.Main1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //using (StreamReader r = new StreamReader("data.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<Portal_User> items = JsonConvert.DeserializeObject<List<Portal_User>>(json);
            //}
            string jsonFile = "data.json";          
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", jsonFile);
            var json = File.ReadAllText(path);
            var jObject = JObject.Parse(json);

            var content = new ERPContext();

            try
            {

                foreach (var item in jObject["coworker"])
                {
                    var objUser = new User();
                    // objUser.UserId = item["UserID"].ToString();
                    objUser.CoworkerId = (int?)item["CoworkerCode"];
                    objUser.FirstName = item["FirstName"].ToString();
                    objUser.LastName = item["LastName"].ToString();
                    objUser.Email = item["EmailAddress"].ToString();
                    objUser.ReportingManagerId = (int)item["ManagerCoworkerCode"];
                    objUser.DepartmentId = (int)item["CoworkerGLDepartmentCode"];
                    objUser.Designation = item["CoworkerTitleDescription"].ToString();
                    objUser.IsActive = true;

                    content.Users.Add(objUser);

                }
                content.SaveChanges();

            }catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
    

