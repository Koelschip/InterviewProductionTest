using Xunit;
using Xunit.Sdk;
using InterviewProductionTest;
using Xunit.Abstractions;
using InterviewProductionTest.Models;

namespace InterviewProductionTest.xUnit
{
    public class InterviewUnitTests
    {
        private readonly InterviewProductionTest.TestMethods _testMethods;
        private readonly Invoice[] _invoices;

        public InterviewUnitTests()
        {
            _testMethods = new InterviewProductionTest.TestMethods();
            _invoices = new Invoice[]
            {
                new Invoice
                {
                    InvoiceNumber = "A12345",
                    InvoiceDate = DateTime.Parse("2023-05-11"),
                    InvoiceType = "Debit",
                    TotalAmount = 200.0
                },
                new Invoice
                {
                    InvoiceNumber = "A12345",
                    InvoiceDate = DateTime.Parse("2023-05-11"),
                    InvoiceType = "Credit",
                    TotalAmount = 200.0
                },
                new Invoice
                {
                    InvoiceNumber = "B54321",
                    InvoiceDate = DateTime.Parse("2023-05-15"),
                    InvoiceType = "Debit",
                    TotalAmount = 26.0
                },
                new Invoice
                {
                    InvoiceNumber = "A12345",
                    InvoiceDate = DateTime.Parse("2023-05-13"),
                    InvoiceType = "Debit",
                    TotalAmount = 5.0
                },
                new Invoice
                {
                    InvoiceNumber = "D12125",
                    InvoiceDate = DateTime.Parse("2023-05-12"),
                    InvoiceType = "Credit",
                    TotalAmount = 270.0
                },
                new Invoice
                {
                    InvoiceNumber = "A12345",
                    InvoiceDate = DateTime.Parse("2023-05-11"),
                    InvoiceType = "Debit",
                    TotalAmount = 200.0
                },
            };
        }

        [Fact]
        public void TestMethods_ReturnCurrentDateString()
        {
            string actual = _testMethods.ReturnCurrentDateString();

            Assert.Equal(DateTime.Now.ToString("yyyyMMdd"), actual);
        }

        [Fact]
        public void TestMethods_ContainsDigitsXORAlpha_EmptyString()
        {
            var testString = "";
            bool actual = _testMethods.ContainsDigitsXORAlpha(testString);

            Assert.False(actual);
        }

        [Fact]
        public void TestMethods_ContainsDigitsXORAlpha_DigitOnly()
        {
            var testString = "7539923471";
            bool actual = _testMethods.ContainsDigitsXORAlpha(testString);

            Assert.True(actual);
        }

        [Fact]
        public void TestMethods_ContainsDigitsXORAlpha_AlphaOnly()
        {
            var testString = "ThisStringOnlyHasAlpha";
            bool actual = _testMethods.ContainsDigitsXORAlpha(testString);

            Assert.True(actual);
        }

        [Fact]
        public void TestMethods_ContainsDigitsXORAlpha_DigitAndAlpha()
        {
            var testString = "This2String4Has5Both";
            bool actual = _testMethods.ContainsDigitsXORAlpha(testString);

            Assert.False(actual);
        }

        [Fact]
        public void TestMethods_GetDebitInvoices()
        {
            Invoice[] debitInvoices = _testMethods.GetDebitInvoices(_invoices);

            var expectedResults = new Invoice[] { _invoices[0], _invoices[2], _invoices[3], _invoices[5] };

            Assert.Equivalent(expectedResults, debitInvoices);
        }

        [Fact]
        public void TestMethods_GetDebitInvoices_EmptyList()
        {
            Invoice[] debitInvoices = _testMethods.GetDebitInvoices(new Invoice[0]);

            Assert.Equivalent(new Invoice[0], debitInvoices);
        }

        [Fact]
        public void TestMethods_GetLowestTotalAmount()
        {
            Invoice lowestInvoice = _testMethods.GetLowestTotalAmount(_invoices);

            var expectedResult = _invoices[3];

            Assert.Equivalent(expectedResult, lowestInvoice);
        }

        [Fact]
        public void TestMethods_GetLowestTotalAmount_EmptyArray()
        {
            Invoice lowestInvoice = _testMethods.GetLowestTotalAmount(new Invoice[0]);

            Assert.Equivalent(new Invoice(), lowestInvoice);
        }

        [Fact]
        public void TestMethods_GetDuplicateInvoices()
        {
            Invoice[] duplicateInvoices = _testMethods.GetDuplicateInvoices(_invoices[0], _invoices);

            var expectedResults = new Invoice[] { _invoices[0], _invoices[5] };

            Assert.Equivalent(expectedResults, duplicateInvoices);
        }

        [Fact]
        public void TestMethods_GetDuplicateInvoices_EmptyArray()
        {
            Invoice[] duplicateInvoices = _testMethods.GetDuplicateInvoices(_invoices[0], new Invoice[0]);

            Assert.Equivalent(new Invoice[0], duplicateInvoices);
        }
    }
}