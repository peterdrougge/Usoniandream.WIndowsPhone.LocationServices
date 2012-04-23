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
using System.Linq;
using Usoniandream.WindowsPhone.GeoConverter.Positions;


namespace Usoniandream.WindowsPhone.LocationServices.Mappers.Stockholm.ServiceGuide
{
    public class DetailedServiceUnit : IMapper<Models.Stockholm.ServiceGuide.DetailedServiceUnit, Models.JSON.Stockholm.DetailedServiceUnit.RootObject>
    {

        public System.Collections.Generic.IEnumerable<Models.Stockholm.ServiceGuide.DetailedServiceUnit> JSON2Model(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Models.Stockholm.ServiceGuide.DetailedServiceUnit> JSON2Model(System.Collections.Generic.IEnumerable<Models.JSON.Stockholm.DetailedServiceUnit.RootObject> root)
        {
            throw new NotImplementedException();
        }

        public Models.Stockholm.ServiceGuide.DetailedServiceUnit JSON2FirstModel(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root)
        {
            RT90 rt90pos = new RT90(root.GeographicalPosition.X, root.GeographicalPosition.Y, RT90.RT90Projection.rt90_2_5_gon_v);
            WGS84 pos = rt90pos.ToWGS84();
            return new Models.Stockholm.ServiceGuide.DetailedServiceUnit()
            {
                Content = root.Name,
                ID = root.Id,
                Location = new System.Device.Location.GeoCoordinate(pos.Latitude, pos.Longitude),
                StreetAddress = GetAttributeByID(root, "StreetAddress"),
                PhoneNumber = GetAttributeByID(root, "PhoneNumber"),
                Contact = GetAttributeByID(root, "ContactPersonName"),
                ContactPhone = GetAttributeByID(root, "ContactPersonPhone"),
                ContactEmail = GetAttributeByID(root, "ContactPersonEmail"),
                ShortDescription = GetAttributeByID(root, "ShortDescription"),
                Description = GetAttributeByID(root, "Description"),
                GeographicalArea = GetGeographicalArea(root),
                ImageId = GetAttributeByID(root, "Image")
            };
        }

        private string GetGeographicalArea(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root)
        {
            if (root.GeographicalAreas.FirstOrDefault()!=null)
            {
                return root.GeographicalAreas.FirstOrDefault().Name;
            }

            return string.Empty;
        }

        private string GetAttributeByID(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root, string id)
        {
            if (root.Attributes.SingleOrDefault(x => x.Id.Equals(id))!=null)
            {
                if (root.Attributes.SingleOrDefault(x => x.Id.Equals(id)).Value != null)
                    return root.Attributes.SingleOrDefault(x => x.Id.Equals(id)).Value.ToString();
            }
            return string.Empty;
        }

        public Models.Stockholm.ServiceGuide.DetailedServiceUnit JSON2LastModel(Models.JSON.Stockholm.DetailedServiceUnit.RootObject root)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
