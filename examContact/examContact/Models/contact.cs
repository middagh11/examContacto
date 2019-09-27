using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace examContact.Models
{
    enum typeContact
    {
        name,
        list,
        email,
        birthdate,

    }
    public class contact
    {
       [Key]
        public int friend { get; set; }
       [required]
        public string name { get; set; }
        [required]
        public string email { get; set; }
        public DataType birthdate { get; set; }
        [Display(Description ="contact")]
        public string ContactValue { get; set; }

    }
}