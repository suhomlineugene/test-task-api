using AutoMapper;
using testapp_api.Shared.Models;

namespace testapp_api.Shared.Profiles;

public class MappingsProfile : Profile
{
    public MappingsProfile()
    {
        CreateMap<TestFile, TestFileDto>()
            .ForMember(x => x.StationId, opt => opt.MapFrom(aa => aa.STATION_ID))
            .ForMember(x => x.SiteName, opt => opt.MapFrom(aa => aa.SITE_NAME))
            .ForMember(x => x.ZdalyGasBrand, opt => opt.MapFrom(aa => aa.ZDALY_GAS_BRAND))
            .ForMember(x => x.City, opt => opt.MapFrom(aa => aa.CITY))
            .ForMember(x => x.ClusterMedianPrice, opt => opt.MapFrom(aa => aa.CLUSTER_MEDIAN_PRICE))
            .ForMember(x => x.ClientMarketPrice, opt => opt.MapFrom(aa => aa.CLIENT_MARKET_PRICE))
            .ForMember(x => x.Latitude, opt => opt.MapFrom(aa => aa.LATITUDE))
            .ForMember(x => x.Longitude, opt => opt.MapFrom(aa => aa.LONGITUDE));
    }
}