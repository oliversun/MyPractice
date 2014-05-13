using System;
using System.Collections.Generic;
using Ctrip.SOA.Comm;
using System.Diagnostics;
using Freeway.Logging;
using Freeway.Metrics;

namespace ConsoleApplication3
{
    public class SOAHotelBusiness
    {
        static readonly ILog logger = LogManager.GetLogger("SOAHotelBusiness");
        static readonly IMetric metricLogger = MetricManager.GetMetricLogger();

        //酒店推荐产品查询
        public static void RecommendHotleProduct(string CmessageID)
        {



            string requestXml = @"<?xml version='1.0'?>
<Request>
<Header UserID='110120' RequestType='Hotel.Booking.RecommendWS.GetHotelRecommandRequest' AsyncRequest='false' Timeout='0' MessagePriority='3' RequestBodySize='0' SerializeMode='Xml' RouteStep='0' />
<GetHotelRecommandRequest>
<CityId>2</CityId>
<CheckinDate>2013-07-10T00:00:00</CheckinDate>
<CheckoutDate>2013-07-11T00:00:00</CheckoutDate>
<TotalQuantity>5</TotalQuantity>
<BusinessId>5</BusinessId>
<LandMarkLon>0</LandMarkLon>
<LandMarkLat>0</LandMarkLat>
<UserBehaiors>
<UserBehavior>
<City>2</City>
<CheckInDate>2013-07-10T00:00:00</CheckInDate>
<CheckOutDate>2013-07-11T00:00:00</CheckOutDate>
<Zone>0</Zone>
<BeginPrice>-1</BeginPrice>
<EndPrice>-1</EndPrice>
</UserBehavior>
</UserBehaiors>
</GetHotelRecommandRequest>
</Request>";
            string responseXml = WSAgent.Request(requestXml, @"http://soa.testp.sh.ctriptravel.com/SOA.ESB/Ctrip.SOA.ESB.asmx", 60);//todo for debug


        }


    }
}
