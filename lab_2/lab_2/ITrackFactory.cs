using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public interface ITrackFactory
    {
        ITrack CreateTrack();
        IRunner CreateRunner();
    }

    public interface ITrack
    {
        string GetTrackType();
    }

    public interface IRunner
    {
        string GetRunnerType();
    }

}
