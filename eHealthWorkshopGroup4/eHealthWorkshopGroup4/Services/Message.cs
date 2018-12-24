using System;
using System.Collections.Generic;
using System.Text;

namespace eHealthWorkshopGroup4.Services
{
    public class Message
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        public Message(string Title, string Date, string Content)
        {
            this.Title = Title;
            this.Date = Date;
            this.Content = Content;
        }
    }
}
