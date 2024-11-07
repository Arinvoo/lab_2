using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class PlasticTrack : ITrack
    {
        public string GetTrackType() => "Plastic Track";
    }

    public class RubberTrack : ITrack
    {
        public string GetTrackType() => "Rubber Track";
    }
}
