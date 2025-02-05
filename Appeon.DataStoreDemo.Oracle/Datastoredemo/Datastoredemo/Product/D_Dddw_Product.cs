using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.Oracle
{
    [FromTable("Product", Schema= "Production")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Dddw_Product
    {
        [Key, Identity, ConcurrencyCheck]
        public Int32 Productid { get; set; }

        [ConcurrencyCheck]
        public String Name { get; set; }

    }
}
