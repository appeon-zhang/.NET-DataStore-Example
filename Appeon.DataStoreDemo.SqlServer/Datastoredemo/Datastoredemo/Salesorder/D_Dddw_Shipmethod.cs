using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.SqlServer
{
    [FromTable("ShipMethod", Schema= "Purchasing")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Dddw_Shipmethod
    {
        [Key, Identity, ConcurrencyCheck]
        public Int32 Shipmethodid { get; set; }

        [ConcurrencyCheck]
        public String Name { get; set; }

        [ConcurrencyCheck]
        public Decimal Shipbase { get; set; }

        [ConcurrencyCheck]
        public Decimal Shiprate { get; set; }

    }
}
