using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    [FromTable("StateProvince", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Stateprovince
    {
        public Int32 Stateprovinceid { get; set; }

        public String Name { get; set; }

    }
}
