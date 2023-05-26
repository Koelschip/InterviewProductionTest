using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProductionTest.Models
{
    public class Invoice
    {
        public string InvoiceNumber { get; set; } = "0";
        public double TotalAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceType { get; set; } = "Debit";
        public string? ExceptionType { get; set; }
    }
}
