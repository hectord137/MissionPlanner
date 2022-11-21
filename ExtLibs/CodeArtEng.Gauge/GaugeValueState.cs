using System;

namespace CodeArtEng.Gauge
{
    [Flags]
    public enum  GaugeValueState
    {
        OK = 1,
        Warning = 2,
        Error = 4
    };
}
