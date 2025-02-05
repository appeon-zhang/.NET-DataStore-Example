using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.SqlAnyWhere
{
    [FromTable("Customer", Schema= "Sales")]
    [FromTable("SalesTerritory", Schema= "Sales")]
    [FromTable("Person", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Customer_Individual
    {
        [Identity, SqlColumn("Customer", "CustomerID")]
        public Int32 Customer_Customerid { get; set; }

        [SqlColumn("Customer", "PersonID")]
        public Int32? Customer_Personid { get; set; }

        [SqlColumn("Customer", "TerritoryID")]
        public Int32? Customer_Territoryid { get; set; }

        [SqlColumn("Customer", "AccountNumber")]
        public String Customer_Accountnumber { get; set; }

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
