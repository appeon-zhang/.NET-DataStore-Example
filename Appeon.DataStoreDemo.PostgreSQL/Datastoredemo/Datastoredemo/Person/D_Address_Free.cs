using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    [FromTable("Address", Schema= "Person")]
    [SqlParameter("al_addressid", typeof(Decimal))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Address_Free
    {
        [Key, Identity]
        public Int32 Addressid { get; set; }

        public String Addressline1 { get; set; }

        public String Addressline2 { get; set; }

        public String City { get; set; }

        public Int32 Stateprovinceid { get; set; }

        public String Postalcode { get; set; }

        public DateTime? Modifieddate { get; set; }

    }
}
