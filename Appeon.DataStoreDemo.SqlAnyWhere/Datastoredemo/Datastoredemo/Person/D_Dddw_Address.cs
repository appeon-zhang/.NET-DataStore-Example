using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.SqlAnyWhere
{
    [FromTable("Address", Schema= "Person")]
    [FromTable("StateProvince", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Address
    {
        public Int32 Addressid { get; set; }

        public String Addressline1 { get; set; }

        public String City { get; set; }

        public Int32 Stateprovinceid { get; set; }

        [SqlColumn("StateProvince", "Name")]
        public String Stateprovince_Name { get; set; }

    }
}
