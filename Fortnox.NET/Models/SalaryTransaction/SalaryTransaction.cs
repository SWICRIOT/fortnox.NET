﻿using FortnoxNET.Utils;
using Newtonsoft.Json;
using System;

namespace FortnoxNET.Models.SalaryTransaction
{
    [JsonPropertyClass("SalaryTransaction")]
    public class SalaryTransaction
    {
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }

        public bool ShouldSerializeUrl() => false;

        public string EmployeeId { get; set; }

        public string SalaryCode { get; set; }

        public int? SalaryRow { get; set; }

        public bool ShouldSerializeSalaryRow() => false;

        public DateTime? Date { get; set; }

        public string Number { get; set; }

        public string Amount { get; set; }

        public string Total { get; set; }

        public string Expense { get; set; }

        public string VAT { get; set; }

        public string TextRow { get; set; }

        public string ConstCenter { get; set; }

        public string Project { get; set; }
    }
}
