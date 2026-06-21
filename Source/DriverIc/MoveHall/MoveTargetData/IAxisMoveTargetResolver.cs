using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.MoveHall.MoveTargetData
{
    public interface IAxisMoveTargetResolver
    {
        AxisTargetData Resolve(string axisName);
    }
}
