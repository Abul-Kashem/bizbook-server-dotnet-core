﻿using System;
using Model;
using Model.Constants;
using Model.Model;

namespace ServiceLibrary.Reports
{
    public class SchedulerService
    {
        public static void ProcessData(string shopId)
        {
            var db = BizBookInventoryContext.Create();
            var end = DateTime.Today.Date.AddDays(1).AddSeconds(-2);
            var start = DateTime.Today.Date;
            var timeType = ReportTimeType.Daily;

            //SaleReportService saleReportService = new SaleReportService(new BaseRepository<SaleReport>(db));
            //saleReportService.ShopClose(shopId, start, end, timeType);

            //TransactionReportService service2 = new TransactionReportService(new BaseRepository<TransactionReport>(db));
            //service2.ShopClose(shopId, start, end, timeType);

            //ProductReportService productReportService = new ProductReportService(new BaseRepository<ProductReport>(db));
            //productReportService.ShopClose(shopId, start, end, timeType);
        }
    }
}
