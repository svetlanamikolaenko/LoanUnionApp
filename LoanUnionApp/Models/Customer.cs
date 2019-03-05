using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanUnionApp.Models
{
    public class Customer: Base
    {
        [Required(ErrorMessage = "Ім'я обов'язкове до заповнення")]
        [StringLength(50)]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Прізвище обов'язкове до заповнення")]
        [StringLength(50)]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "По-батькові обов'язкове до заповнення")]
        [StringLength(50)]
        [JsonProperty("fathersName")]
        public string FathersName { get; set; }

        [Required(ErrorMessage = "Дата народження обов'язкова до заповнення")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email обов'язкове до заповнення")]
        [StringLength(50)]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Необхідно заповнити номер телефону")]
        [JsonProperty("phoneNumber")]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Вкажіть індивідуальний код платника податків")]
        [StringLength(11)]
        [JsonProperty("uniqueCode")]
        public long UniqueCode { get; set; }

        [Required(ErrorMessage = "Вкажіть серію та номер паспорту")]
        [StringLength(8)]
        [JsonProperty("passportNamber")]
        public string PassportNumber { get; set; }

        [Required(ErrorMessage = "Поле ким виданий паспорт є обов'язкове")]
        [StringLength(120)]
        [JsonProperty("passportGivenByWhom")]
        public string PassportGivenByWhom { get; set; }

        [Required(ErrorMessage = "Необхідно вказати дату видачі паспорту")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [JsonProperty("passportGivenDate")]
        public DateTime PassportGivenDate { get; set; }

        [Required(ErrorMessage = "Вкажіть зарплатню за місяць")]
        [StringLength(50)]
        [JsonProperty("monthSalary")]
        public double MonthSalary { get; set; }      
    }
}
