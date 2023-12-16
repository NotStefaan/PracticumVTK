using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumVTK.Data
{
    class User
    {
        [Key]
        public int id_user { get; set; }

        public string Username, Lastname, Fathername, Password, Groupname, Avatar, Email;

        public string username { 
        
            get { return Username; }
            set { Username = value; }
        }

        public string lastname { 
        
            get { return Lastname; }
            set { Lastname = value; }
        }

        public string fathername { 
        
            get { return Fathername; }
            set { Fathername = value; }
        }

        public string groupname { 
        
            get { return Groupname; }
            set { Groupname = value; }
        }

        public string password { 
        
            get { return Password; }
            set { Password = value; }
        }

        public string avatar
        {

            get { return Avatar; }
            set { Avatar = value; }
        }

        public string email
        {

            get { return Email; }
            set { Email = value; }
        }

        public User() { }

        public User(string Username, string Lastname, string Fathername, string Groupname, string Password, string Avatar, string Email) 
        {
            Username = username;
            Lastname = lastname;
            Fathername = fathername;
            Groupname = groupname;
            Password = password;
            Avatar = avatar;
            Email = email;
        }

        public User(string username, string lastname, string fathername, string groupname, string password, string email)
        {
            Username = username;
            Lastname = lastname;
            Fathername = fathername;
            Groupname = groupname;
            Password = password;
            Email = email;
        }
    }
}
