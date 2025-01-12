﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LapTrinhQuanLy.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [Required(ErrorMessage = "ID Khong duoc de trong !")]
        public string PersonID { get; set; }
        [AllowHtml]
        public string PersonName { get; set; }
    }
}