using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usoniandream.WindowsPhone.LocationServices.Mappers
{
    public interface IMapper<Ttarget, Tsource> : IDisposable
    {
        IEnumerable<Ttarget> JSON2Model(Tsource root);
        IEnumerable<Ttarget> JSON2Model(IEnumerable<Tsource> root);
        Ttarget JSON2FirstModel(Tsource root);
        Ttarget JSON2LastModel(Tsource root);
    }
}
