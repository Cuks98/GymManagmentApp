using System;
using System.Collections.Generic;

namespace DataBaseAPI.Models
{
    public class MailRequest
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<String> ListOfMailAddresses { get; set; }
    }
}
