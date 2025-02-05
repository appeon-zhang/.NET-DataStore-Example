using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.Oracle
{
    [FromTable("UnitMeasure", Schema= "Production")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Dddw_Unit
    {
        [Key, ConcurrencyCheck]
        public String Unitmeasurecode { get; set; }

        [ConcurrencyCheck]
        public String Name { get; set; }

    }
}
