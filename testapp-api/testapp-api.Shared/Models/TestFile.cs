using CsvHelper.Configuration.Attributes;

namespace testapp_api.Shared.Models;

public class TestFile
{
    public int STATION_ID { get; set; }
    public string SITE_NAME { get; set; }
    public string ZDALY_GAS_BRAND { get; set; }
    public string CITY { get; set; }
    public string CLUSTER_MEDIAN_PRICE { get; set; }
    public string CLIENT_MARKET_PRICE { get; set; }
    public string LATITUDE { get; set; }
    public string LONGITUDE { get; set; }
}