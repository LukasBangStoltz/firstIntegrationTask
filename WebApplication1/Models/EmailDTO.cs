using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmailDTO
    {
        public string Reciver { get; set; }
        public string Body { get; set; }

        public string Document { get; set; }

        public EmailDTO(string _Reciver, string _Body, string _document)
        {
            this.Reciver = _Reciver;
            this.Body = _Body;
            Document = _document;
        }
        public EmailDTO( )
        {
        }



    }
}