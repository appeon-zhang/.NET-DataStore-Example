using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.SqlAnyWhere
{
    [FromTable("SalesTerritory", Schema= "Sales")]
    [FromTable("CountryRegion", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Salesterritory
    {
        [Identity, SqlColumn("SalesTerritory", "TerritoryID")]
        public Int32 Salesterritory_Territoryid { get; set; }

        [SqlColumn("SalesTerritory", "Name")]
        public String Salesterritory_Name { get; set; }

        [SqlColumn("SalesTerritory", "CountryRegionCode")]
        public String Salesterritory_Countryregioncode { get; set; }

        [SqlColumn("SalesTerritory", "Group")]
        public String Salesterritory_Group { get; set; }

        [SqlColumn("CountryRegion", "Name")]
        public String Countryregion_Name { get; set; }

    }
}
