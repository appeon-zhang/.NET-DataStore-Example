using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.SqlServer
{
    [FromTable("Address", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Address
    {
        [Key, Identity, ConcurrencyCheck]
        public Int32 Addressid { get; set; }

        [ConcurrencyCheck]
        public String Addressline1 { get; set; }

        [ConcurrencyCheck]
        public String Addressline2 { get; set; }

        [ConcurrencyCheck]
        public String City { get; set; }

        [ConcurrencyCheck]
        public Int32 Stateprovinceid { get; set; }

        [ConcurrencyCheck]
        public String Postalcode { get; set; }

        public DateTime Modifieddate { get; set; }

        public Guid Rowguid { get; set; }

    }
}
