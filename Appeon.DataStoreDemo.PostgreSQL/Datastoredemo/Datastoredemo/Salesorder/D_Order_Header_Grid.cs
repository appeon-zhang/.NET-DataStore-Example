using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    [FromTable("SalesOrderHeader", Schema= "Sales")]
    [SqlParameter("adt_start", typeof(DateTime))]
    [SqlParameter("adt_end", typeof(DateTime))]
    [SqlParameter("al_cust_id", typeof(Decimal))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Order_Header_Grid
    {
        [Key, Identity, ConcurrencyCheck]
        public Int32 Salesorderid { get; set; }

        [ConcurrencyCheck]
        public int Revisionnumber { get; set; }

        [ConcurrencyCheck]
        public DateTime Orderdate { get; set; }

        [ConcurrencyCheck]
        public DateTime Duedate { get; set; }

        [ConcurrencyCheck]
        public DateTime? Shipdate { get; set; }

        [ConcurrencyCheck]
        public int Status { get; set; }

        [ConcurrencyCheck]
        public Boolean Onlineorderflag { get; set; }

        [ConcurrencyCheck]
        public String Salesordernumber { get; set; }

        [ConcurrencyCheck]
        public String Purchaseordernumber { get; set; }

        [ConcurrencyCheck]
        public String Accountnumber { get; set; }

        [ConcurrencyCheck]
        public Int32 Customerid { get; set; }

        [ConcurrencyCheck]
        public Int32? Salespersonid { get; set; }

        [ConcurrencyCheck]
        public Int32? Territoryid { get; set; }

        [ConcurrencyCheck]
        public Int32 Billtoaddressid { get; set; }

        [ConcurrencyCheck]
        public Int32 Shiptoaddressid { get; set; }

        [ConcurrencyCheck]
        public Int32 Shipmethodid { get; set; }

        [ConcurrencyCheck]
        public Int32? Creditcardid { get; set; }

        [ConcurrencyCheck]
        public String Creditcardapprovalcode { get; set; }

        [ConcurrencyCheck]
        public Int32? Currencyrateid { get; set; }

        [ConcurrencyCheck]
        public Decimal Subtotal { get; set; }

        [ConcurrencyCheck]
        public Decimal Taxamt { get; set; }

        [ConcurrencyCheck]
        public Decimal Freight { get; set; }

        [ConcurrencyCheck]
        public Decimal Totaldue { get; set; }

        [ConcurrencyCheck]
        public String Comment { get; set; }

        [ConcurrencyCheck]
        public Guid Rowguid { get; set; }

        [ConcurrencyCheck]
        public DateTime Modifieddate { get; set; }

    }
}
