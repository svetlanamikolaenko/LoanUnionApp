using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanUnionApp.Models
{
    public class Base
    
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}