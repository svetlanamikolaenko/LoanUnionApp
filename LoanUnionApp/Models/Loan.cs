using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanUnionApp.Models
{
    public class Loan:Base
    {
        [Required]
        [StringLength(50)]
        [JsonProperty("name")]
        public string Name { get; set; }

        [Required]
        [JsonProperty("period")]
        public int? Period { get; set; }

        [Required]
        [Range(1, 100)]
        [JsonProperty("procent")]
        public int? Procent { get; set; }
    }
}