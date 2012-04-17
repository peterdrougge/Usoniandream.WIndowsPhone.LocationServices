using System;
using Usoniandream.WindowsPhone.LocationServices.Mappers;
namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias
{
    public interface ISearchCriteria<Ttarget, Tsource>
    {
        string APIkey { get; }
        RestSharp.RestClient Client { get; }
        RestSharp.RestRequest Request { get; }
        IMapper<Ttarget, Tsource> Mapper { get; set; }
    }
}
