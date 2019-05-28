using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.SqlAnyWhere
{
    [FromTable("PhoneNumberType", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Phonenumbertype
    {
        public Int32 Phonenumbertypeid { get; set; }

        public String Name { get; set; }

    }
}
