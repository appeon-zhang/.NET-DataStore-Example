using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    [FromTable("ProductProductPhoto",Schema ="Production")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Productproductphoto
    {
        [Key]
        public Int32 Productid { get; set; }

        [Key]
        public Int32 Productphotoid { get; set; }

        [SqlColumn("ProductProductPhoto", "\"primary\"", "Primary")]
        public bool? Primary { get; set; }

        [ConcurrencyCheck]
        public DateTime Modifieddate { get; set; }

    }
}
