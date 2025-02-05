using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.Oracle
{
    [FromTable("AddressType", Schema= "Person")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class D_Dddw_Addresstype
    {
        [Key, Identity, ConcurrencyCheck]
        public Int32 Addresstypeid { get; set; }

        [ConcurrencyCheck]
        public String Name { get; set; }

    }
}
