using CsvHelper.Configuration;

namespace testapp_api.Shared.Models;

public sealed class TestFileMap: ClassMap<TestFile>
{
    public TestFileMap()
    {
        Map(m => m.STATION_ID).Name("STATION_ID");
        Map(m => m.SITE_NAME).Name("SITE_NAME");
        Map(m => m.ZDALY_GAS_BRAND).Name("ZDALY_GAS_BRAND");
        Map(m => m.CITY).Name("CITY");
        Map(m => m.CLUSTER_MEDIAN_PRICE).Name("CLUSTER_MEDIAN_PRICE");
        Map(m => m.CLIENT_MARKET_PRICE).Name("CLIENT_MARKET_PRICE");
        Map(m => m.LATITUDE).Name("LATITUDE");
        Map(m => m.LONGITUDE).Name("LONGITUDE");
    }
}