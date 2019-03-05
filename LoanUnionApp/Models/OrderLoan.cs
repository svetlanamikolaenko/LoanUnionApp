using LoanUnionApp.Models.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanUnionApp.Models
{
    public class OrderLoan:Base
    {
        public int CustomerId { get; set; }
        public int LoanId { get; set; }

        [Required(ErrorMessage = "Необхідно завантажити фото паспорту та індивідуального коду платників податків")]
        [JsonProperty("documetImages")]
        public byte[] DocumentImages { get; set; }

        [Required(ErrorMessage = "Вкажіть суму кредиту")]
        [JsonProperty("amount")]
        public double Amount { get; set; }
                      
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [JsonProperty("approvedDate")]
        public DateTime ApprovedDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

    }
}