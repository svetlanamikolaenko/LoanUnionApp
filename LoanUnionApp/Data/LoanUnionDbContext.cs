using LoanUnionApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoanUnionApp.Data
{
    public class LoanUnionDbContext: DbContext
    {
        public LoanUnionDbContext() : base ("name=LoanUnionDataBase")
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<OrderLoan> OrderLoan { get; set; }
    }
}