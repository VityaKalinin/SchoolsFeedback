using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolsFeedback.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Theme { get; set; }
        public string Text { get; set; }
        public string Status{ get; set; }
        public DateTime DateCreated { get; set; }
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }
    }

}