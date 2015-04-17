using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolsFeedback.Models
{
    public class Message
    {
        public int ID { get; set; }
        [DisplayName("Тема")]
        [Required]
        public string Theme { get; set; }
        [DisplayName("Запрос")]
        [Required]
        public string Text { get; set; }
        public string Status{ get; set; }
        public DateTime DateCreated { get; set; }
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }
    }

}