using FZ4P.DriverIc.SlaveID.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.MoveHall.Parameters
{
    public class MoveHallContextParam
    {
        public ActuatorType actuatorType { get; set; } = ActuatorType.Type1C87;

        public int MemoryAddress { get; set; } = -1;
    }
}
