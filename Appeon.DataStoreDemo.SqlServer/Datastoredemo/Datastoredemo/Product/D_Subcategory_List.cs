using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.SqlServer
{
    [FromTable("ProductSubcategory", Schema= "Production")]
    [SqlParameter("ai_id", typeof(Decimal))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Subcategory_List
    {
        [Key, Identity, ConcurrencyCheck]
        public Int32 Productsubcategoryid { get; set; }

        [ConcurrencyCheck]
        public Int32 Productcategoryid { get; set; }

        [ConcurrencyCheck]
        public String Name { get; set; }

        [ConcurrencyCheck]
        public DateTime Modifieddate { get; set; }

    }
}
