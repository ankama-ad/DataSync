using DataMigration.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataMigration
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
            string jsonFile = @"C:\Users\kalisur\source\repos\DataMigration\DataMigration\data.json";
            var json = File.ReadAllText(jsonFile);
            var jObject = JObject.Parse(json);
            

            foreach(var item in jObject["coworker"])
            {
                Portal_User objUser = new Portal_User();
                objUser.UserID = item["UserID"].ToString();
                objUser.Co_WorkderID = item["CoworkerCode"].ToString();
                objUser.FirstName = item["FirstName"].ToString();
                objUser.LastName = item["LastName"].ToString();
                objUser.EmailAddress = item["EmailAddress"].ToString();
                objUser.Reporting_Manager_ID = item["ManagerCoworkerCode"].ToString();
                objUser.DepartmentID = item["CoworkerGLDepartmentCode"].ToString();
                objUser.Designation = item["CoworkerTitleDescription"].ToString();
               
            }
        }
    }
}
    

