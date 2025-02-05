﻿using PowerBuilder.Data;

namespace Appeon.DataStoreDemo.SqlServer.Services
{
    /// <summary>
    /// This Service needs to be injected into the ConfigureServices method of the Startup class. Sample code as follows:
    /// services.AddScoped<IOrderReportService, OrderReportService>();
    /// </summary>
    public class OrderReportService : ServiceBase, IOrderReportService

    {
        public OrderReportService(OrderContext context)
            : base(context)
        {
        }

        public IDataStore RetrieveSubCategorySalesReport(params object[] salesmonth)
        {
            var OrderReportMonth1 = Retrieve("d_subcategorysalesreport_d", salesmonth[0], salesmonth[1]);
            var OrderReportMonth2 = Retrieve("d_subcategorysalesreport_d", salesmonth[0], salesmonth[2]);
            var OrderReportMonth3 = Retrieve("d_subcategorysalesreport_d", salesmonth[0], salesmonth[3]);
            var OrderReportMonth4 = Retrieve("d_subcategorysalesreport_d", salesmonth[0], salesmonth[4]);
            var OrderReportMonth5 = Retrieve("d_subcategorysalesreport_d", salesmonth[0], salesmonth[5]);
            var OrderReportMonth6 = Retrieve("d_subcategorysalesreport_d", salesmonth[0], salesmonth[6]);

            var dataStore = new DataStore("d_subcategorysalesreport");
            dataStore.AddRow();

            if (OrderReportMonth1.RowCount > 0)
            {
                dataStore.SetItem(0, "name", OrderReportMonth1.GetItem<string>(0, "subcategoryname"));

                dataStore.SetItem(0, "salesqtymonth1", OrderReportMonth1.GetItem<int?>(0, "totalsalesqty") ?? 0);
                dataStore.SetItem(0, "salesroommonth1", OrderReportMonth1.GetItem<decimal?>(0, "totalsaleroom") ?? 0);
            }

            if (OrderReportMonth2.RowCount > 0)
            {
                dataStore.SetItem(0, "salesqtymonth2", OrderReportMonth2.GetItem<int?>(0, "totalsalesqty") ?? 0);
                dataStore.SetItem(0, "salesroommonth2", OrderReportMonth2.GetItem<decimal?>(0, "totalsaleroom") ?? 0);
            }

            if (OrderReportMonth3.RowCount > 0)
            {
                dataStore.SetItem(0, "salesqtymonth3", OrderReportMonth3.GetItem<int?>(0, "totalsalesqty") ?? 0);
                dataStore.SetItem(0, "salesroommonth3", OrderReportMonth3.GetItem<decimal?>(0, "totalsaleroom") ?? 0);
            }

            if (OrderReportMonth4.RowCount > 0)
            {
                dataStore.SetItem(0, "salesqtymonth4", OrderReportMonth4.GetItem<int?>(0, "totalsalesqty") ?? 0);
                dataStore.SetItem(0, "salesroommonth4", OrderReportMonth4.GetItem<decimal?>(0, "totalsaleroom") ?? 0);
            }

            if (OrderReportMonth5.RowCount > 0)
            {
                dataStore.SetItem(0, "salesqtymonth5", OrderReportMonth5.GetItem<int?>(0, "totalsalesqty") ?? 0);
                dataStore.SetItem(0, "salesroommonth5", OrderReportMonth5.GetItem<decimal?>(0, "totalsaleroom") ?? 0);
            }

            if (OrderReportMonth6.RowCount > 0)
            {
                dataStore.SetItem(0, "salesqtymonth6", OrderReportMonth6.GetItem<int?>(0, "totalsalesqty") ?? 0);
                dataStore.SetItem(0, "salesroommonth6", OrderReportMonth6.GetItem<decimal?>(0, "totalsaleroom") ?? 0);
            }

            return dataStore;
        }
    }
}

