using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    [FromTable("ProductListPriceHistory", Schema= "Production")]
    [SqlParameter("al_id", typeof(Decimal))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_History_Price
    {
        [Key]
        public Int32 Productid { get; set; }

        [Key]
        public DateTime Startdate { get; set; }

        public DateTime? Enddate { get; set; }

        public Decimal Listprice { get; set; }

        public DateTime Modifieddate { get; set; }

    }
}
