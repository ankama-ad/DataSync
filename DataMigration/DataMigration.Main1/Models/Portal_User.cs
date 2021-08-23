using System;
using System.Collections.Generic;
using System.Text;

namespace DataMigration.Main1.Models
{
    public class Portal_User
    {
        private string _userID;
        public string UserID
        {
            set
            {
                this._userID = value;
            }
            get
            {
                return this._userID;
            }
        }

        private string _username;
        public string UserName
        {
            set
            {
                this._username = value;
            }
            get
            {
                return this._username;
            }
        }

        private string _email;
        public string EmailAddress
        {
            set
            {
                this._email = value;
            }
            get
            {
                return this._email;
            }
        }

        private string _department_id;
        public string DepartmentID
        {
            set
            {
                this._department_id = value;
            }
            get
            {
                return this._department_id;
            }
        }

        private string _coworker_id;
        public string Co_WorkderID
        {
            set
            {
                this._coworker_id = value;
            }
            get
            {
                return this._coworker_id;
            }
        }

        private string _reporting_manager_id;
        public string Reporting_Manager_ID
        {
            set
            {
                this._reporting_manager_id = value;
            }
            get
            {
                return this._reporting_manager_id;
            }
        }

        private string _designation;
        public string Designation
        {
            set
            {
                this._designation = value;
            }
            get
            {
                return this._designation;
            }
        }

        private string _firstname;
        public string FirstName
        {
            set
            {
                this._firstname = value;
            }
            get
            {
                return this._firstname;
            }
        }

        private string _lastname;
        public string LastName
        {
            set
            {
                this._lastname = value;
            }
            get
            {
                return this._lastname;
            }
        }
    }
}
