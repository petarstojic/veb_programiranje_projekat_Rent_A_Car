using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class prijave
    {
        private int id;
        private string username;
        private string password;
        private int admin;

        public prijave(int id, string username, string password, int admin)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.admin = admin;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Admin { get => admin; set => admin = value; }
    }
}