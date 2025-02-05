using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    [FromTable("Customer", Schema = "Sales")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Customer
    {
        [Key]
        [Identity]
        public Int32 Customerid { get; set; }

        public Int32? Personid { get; set; }

        public Int32? Storeid { get; set; }

        public Int32? Territoryid { get; set; }

        [SqlCompute("Accountnumber")]
        public String Accountnumber { get; set; }

        public DateTime Modifieddate { get; set; }

    }
}


