using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class ShortDistanceTrackFactory : ITrackFactory
    {
        public ITrack CreateTrack() => new RubberTrack();
        public IRunner CreateRunner() => new ProfessionalRunner();
    }

}
