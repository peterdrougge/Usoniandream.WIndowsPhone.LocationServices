using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Usoniandream.WindowsPhone.LocationServices.SearchCriterias.Stockholm.Parking.ParkingLocation
{
    public abstract class ParkingLocationsBase : SearchCriteriaBase<Models.Stockholm.ParkingLocation, Usoniandream.WindowsPhone.LocationServices.Models.JSON.Stockholm.ParkingPlaces.RootObject>
    {
        public ParkingLocationsBase(Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum vehicletype)
            : base("STHLM_DATA_SERVICE_URI_PARKINGLOCATION")
        {
            Mapper = new Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.Parking.ParkingLocation();
            APIKeyResourceName = "STHLM_DATA_API_KEY_PARKING";
            VehicleType = vehicletype;

            switch (this.VehicleType)
            {
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Car:
                    Request.Resource += "ptillaten/";
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Bike:
                    Request.Resource += "pmotorcykel/";
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Truck:
                    Request.Resource += "plastbil/";
                    break;
                case Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum.Handicap:
                    Request.Resource += "prorelsehindrad/";
                    break;
                default:
                    throw new ArgumentException("VehicleType must be set", "VehicleType");
            }

            Request.AddParameter("outputFormat", "json");
            Request.AddParameter("apiKey", APIkey);
        }

        public Usoniandream.WindowsPhone.LocationServices.Models.Enums.Stockholm.VehicleTypeEnum VehicleType { get; private set; }
    }
}
