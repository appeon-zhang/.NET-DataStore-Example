using SnapObjects.Data;
using System;

namespace Appeon.DataStoreDemo.SqlServer
{
    [FromTable("BusinessEntityAddress", Schema= "Person")]
    [FromTable("Address", Schema= "Person")]
    [FromTable("AddressType", Schema= "Person")]
    [FromTable("Customer", Schema= "Sales")]
    [FromTable("StateProvince", Schema= "Person")]
    [SqlParameter("al_customer_id", typeof(Decimal))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    public class D_Dddw_Customer_Address
    {
        [SqlColumn("BusinessEntityAddress", "BusinessEntityID")]
        public Int32 Businessentityaddress_Businessentityid { get; set; }

        [SqlColumn("BusinessEntityAddress", "AddressID")]
        public Int32 Businessentityaddress_Addressid { get; set; }

        [SqlColumn("BusinessEntityAddress", "AddressTypeID")]
        public Int32 Businessentityaddress_Addresstypeid { get; set; }

        [SqlColumn("Address", "AddressLine1")]
        public String Address_Addressline1 { get; set; }

        [SqlColumn("Address", "AddressLine2")]
        public String Address_Addressline2 { get; set; }

        [SqlColumn("Address", "City")]
        public String Address_City { get; set; }

        [SqlColumn("Address", "StateProvinceID")]
        public Int32 Address_Stateprovinceid { get; set; }

        [SqlColumn("Address", "PostalCode")]
        public String Address_Postalcode { get; set; }

        [SqlColumn("AddressType", "Name")]
        public String Addresstype_Name { get; set; }

        [SqlColumn("Customer", "CustomerID")]
        public Int32 Customer_Customerid { get; set; }

        [SqlColumn("StateProvince", "StateProvinceCode")]
        public String Stateprovince_Stateprovincecode { get; set; }

        [SqlColumn("StateProvince", "CountryRegionCode")]
        public String Stateprovince_Countryregioncode { get; set; }

        [SqlColumn("StateProvince", "Name")]
        public String Stateprovince_Name { get; set; }

    }
}
