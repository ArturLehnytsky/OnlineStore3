using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "";
        public string MailFromAddress = "";
        public bool UseSsl = true;
        public string Username = "";
        public string Password = "";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
