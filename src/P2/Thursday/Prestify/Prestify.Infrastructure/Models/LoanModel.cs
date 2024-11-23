using Prestify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestify.Infrastructure.Models
{
    public class LoanModel
    {
        public int Id { get; set; }
        public string LoanNumber { get; set; }
        public decimal Amount { get; set; }
        public int Rate { get; set; }
        public int Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }
        public bool Inactive { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
    }
}
