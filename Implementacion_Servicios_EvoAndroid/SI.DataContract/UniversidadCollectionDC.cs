using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [CollectionDataContract]
    public class UniversidadCollectionDC : List<UniversidadDC>
    {
    }
}
