using InterviewProductionTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewProductionTest
{
    public class TestMethods
    {
        /// <summary>
        /// Return a Date string with the date format of yyyyMMdd
        /// </summary>
        public string ReturnCurrentDateString()
        {
            return null;
        }

        /// <summary>
        /// Given a string, return a boolean value of whether the string contains only alpha chacters 
        /// or only digits but not a combination of both
        /// If the string is empty, return false
        /// </summary>
        public bool ContainsDigitsXORAlpha(string text)
        {
            return false;
        }

        /// <summary>
        /// Given an array of invoices, return an array of all "Debit" invoices
        /// If the given array is empty, return an empty invoice array
        /// </summary>
        public Invoice[] GetDebitInvoices(Invoice[] invoices)
        {
            return null;
        }

        /// <summary>
        /// Given an array of invoices, return the invoice with the lowest TotalAmount value
        /// If the given array is empty, return a new invoice
        /// </summary>
        public Invoice GetLowestTotalAmount(Invoice[] invoices)
        {
            return null;
        }

        /// <summary>
        /// Given an invoice and an array of invoices, use the given invoice to find all the duplicates within the
        /// array of invoices, and return the duplicate invoices from the given array
        /// If the given array is empty, return an empty invoice array
        /// </summary>
        public Invoice[] GetDuplicateInvoices(Invoice invoice, Invoice[] invoices)
        {
            return null;
        }
    }
}
