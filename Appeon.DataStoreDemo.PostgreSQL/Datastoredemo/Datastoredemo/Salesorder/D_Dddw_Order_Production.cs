using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    [FromTable("Product", Schema= "Production")]
    [FromTable("ProductCategory", Schema= "Production")]
    [FromTable("ProductSubcategory", Schema= "Production")]
    [FromTable("ProductModel", Schema= "Production")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Order_Production
    {
        [SqlColumn("Product", "Name")]
        public String Product_Name { get; set; }

        [SqlColumn("Product", "ProductNumber")]
        public String Product_Productnumber { get; set; }

        [SqlColumn("Product", "Color")]
        public String Product_Color { get; set; }

        [SqlColumn("Product", "ListPrice")]
        public Decimal Product_Listprice { get; set; }

        [SqlColumn("Product", "Size")]
        public String Product_Size { get; set; }

        [SqlColumn("Product", "ProductSubcategoryID")]
        public Int32? Product_Productsubcategoryid { get; set; }

        [SqlColumn("Product", "ProductModelID")]
        public Int32? Product_Productmodelid { get; set; }

        [SqlColumn("ProductCategory", "Name")]
        public String Productcategory_Name { get; set; }

        [SqlColumn("ProductSubcategory", "ProductCategoryID")]
        public Int32 Productsubcategory_Productcategoryid { get; set; }

        [SqlColumn("ProductSubcategory", "Name")]
        public String Productsubcategory_Name { get; set; }

        [SqlColumn("ProductModel", "Name")]
        public String Productmodel_Name { get; set; }

        [SqlColumn("Product", "ProductID")]
        public Int32 Product_Productid { get; set; }

    }
}
