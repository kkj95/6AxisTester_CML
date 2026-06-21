using FZ4P.DriverIc.MoveHall.MoveTargetData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.ReadHall.ReadTargetData
{
    public interface IAxisReadTargetResolver
    {
        AxisTargetData Resolve(string axisName);
    }
}
