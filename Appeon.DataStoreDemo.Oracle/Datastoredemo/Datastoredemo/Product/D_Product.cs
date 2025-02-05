using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.Oracle
{
    [FromTable("Product", Schema= "Production")]
    [SqlParameter("al_subcate", typeof(Decimal))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Product
    {
        [Key, Identity]
        public Int32 Productid { get; set; }

        public String Name { get; set; }

        public String Productnumber { get; set; }

        public int Makeflag { get; set; }

        public String Color { get; set; }

        public int Safetystocklevel { get; set; }

        public int Reorderpoint { get; set; }

        public Decimal Standardcost { get; set; }

        public Decimal Listprice { get; set; }

        [SqlColumn("\"SIZE\"")]
        public String Size { get; set; }

        public String Sizeunitmeasurecode { get; set; }

        public String Weightunitmeasurecode { get; set; }

        public Decimal? Weight { get; set; }

        public Int32 Daystomanufacture { get; set; }

        public String Productline { get; set; }

        public String Class { get; set; }
        
        public String Style { get; set; }

        public Int32? Productsubcategoryid { get; set; }

        public Int32? Productmodelid { get; set; }

        public DateTime Sellstartdate { get; set; }

        public DateTime? Sellenddate { get; set; }

        public DateTime Modifieddate { get; set; }

        public int? Finishedgoodsflag { get; set; }

    }
}
