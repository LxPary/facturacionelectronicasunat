﻿using System;

namespace OpenInvoicePeru.FirmadoSunat.Estructuras
{
    [Serializable]
    public class Payment
    {
        public string PaidDate { get; set; }
        public int IdPayment { get; set; }
        public PayableAmount PaidAmount { get; set; }

        public Payment()
        {
            PaidAmount = new PayableAmount();
        }
    }
}