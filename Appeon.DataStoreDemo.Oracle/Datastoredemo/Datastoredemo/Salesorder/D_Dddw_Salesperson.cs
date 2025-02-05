using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.Oracle
{
    [FromTable("SalesPerson", Schema= "Sales")]
    [FromTable("SalesTerritory", Schema= "Sales")]
    [FromTable("Person", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Salesperson
    {
        [SqlColumn("SalesPerson", "BusinessEntityID")]
        public Int32 Salesperson_Businessentityid { get; set; }

        [SqlColumn("SalesPerson", "TerritoryID")]
        public Int32? Salesperson_Territoryid { get; set; }

        [SqlColumn("SalesTerritory", "Name")]
        public String Salesterritory_Name { get; set; }

        [SqlColumn("SalesTerritory", "Group")]
        public String Salesterritory_Group { get; set; }

        [SqlColumn("Person", "Title")]
        public String Person_Title { get; set; }

        [SqlColumn("Person", "FirstName")]
        public String Person_Firstname { get; set; }

        [SqlColumn("Person", "MiddleName")]
        public String Person_Middlename { get; set; }

        [SqlColumn("Person", "LastName")]
        public String Person_Lastname { get; set; }

        [SqlColumn("Person", "Suffix")]
        public String Person_Suffix { get; set; }

    }
}
