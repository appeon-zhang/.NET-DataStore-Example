using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Appeon.DataStoreDemo.SqlServer
{
    [FromTable("PersonPhone", Schema= "Person")]
    [SqlParameter("ai_id", typeof(Decimal))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Personphone
    {
        [Key]
        public Int32 Businessentityid { get; set; }

        [Key]
        public String Phonenumber { get; set; }

        [Key]
        public Int32 Phonenumbertypeid { get; set; }

        public DateTime Modifieddate { get; set; }

    }
}
