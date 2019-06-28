using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
namespace InfoManager.Models
{
    public class Info
    {
        public int InfoId { get; set; }

        [DisplayName("Tên thông tin")] 
        public string NameOfInfo { get; set; }

        public int CategoryOfInfoID { get; set; }

    }
}