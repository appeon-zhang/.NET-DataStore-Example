using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.Oracle
{
    [FromTable("ProductCategory", Schema = "Production")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [SqlOrderBy("Productcategoryid")]
    public class D_Dddw_Category
    {
        [Key, Identity, ConcurrencyCheck]
        public Int32 Productcategoryid { get; set; }

        [ConcurrencyCheck]
        public String Name { get; set; }

    }
}
