using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.Oracle
{
    [FromTable("Address", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Address
    {
        [Key, Identity, ConcurrencyCheck]
        public int Addressid { get; set; }

        [ConcurrencyCheck]
        public string Addressline1 { get; set; }

        [ConcurrencyCheck]
        public string Addressline2 { get; set; }

        [ConcurrencyCheck]
        public string City { get; set; }

        [ConcurrencyCheck]
        public int Stateprovinceid { get; set; }

        [ConcurrencyCheck]
        public string Postalcode { get; set; }

        public DateTime Modifieddate { get; set; }

    }
}
