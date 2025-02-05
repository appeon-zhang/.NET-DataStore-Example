using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.SqlAnyWhere
{
    [FromTable("Customer", Schema= "Sales")]
    [FromTable("CreditCard", Schema= "Sales")]
    [SqlParameter("al_customer_id", typeof(Decimal))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Customer_Creditcard
    {
        [Identity, SqlColumn("Customer", "CustomerID")]
        public Int32 Customer_Customerid { get; set; }

        [Identity, SqlColumn("CreditCard", "CreditCardID")]
        public Int32 Creditcard_Creditcardid { get; set; }

        [SqlColumn("CreditCard", "CardType")]
        public String Creditcard_Cardtype { get; set; }

        [SqlColumn("CreditCard", "CardNumber")]
        public String Creditcard_Cardnumber { get; set; }

        [SqlColumn("CreditCard", "ExpMonth")]
        public Byte Creditcard_Expmonth { get; set; }

        [SqlColumn("CreditCard", "ExpYear")]
        public Int16 Creditcard_Expyear { get; set; }

    }
}
