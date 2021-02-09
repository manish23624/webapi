﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RCMSWebAPI.Models
{
    [Table("IRCTC_User")]
    public partial class UserMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string User_Active { get; set; }
        public string Flag { get; set; }
    }
}