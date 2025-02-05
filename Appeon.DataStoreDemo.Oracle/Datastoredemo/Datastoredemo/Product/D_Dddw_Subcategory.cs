using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.Oracle
{
    [FromTable("ProductSubcategory", Schema= "Production")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Dddw_Subcategory
    {
        [Key, Identity, ConcurrencyCheck]
        public Int32 Productsubcategoryid { get; set; }

        [ConcurrencyCheck]
        public Int32 Productcategoryid { get; set; }

        [ConcurrencyCheck]
        public String Name { get; set; }

    }
}
