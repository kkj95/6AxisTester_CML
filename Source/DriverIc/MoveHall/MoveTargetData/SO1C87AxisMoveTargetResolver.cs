using FZ4P.DriverIc.ReadHall.ReadTargetData;
using FZ4P.DriverIc.SlaveID.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.MoveHall.MoveTargetData
{
    public class SO1C87AxisMoveTargetResolver : IAxisMoveTargetResolver
    {
        private readonly ActuatorSlaveID_SO1C87 _slave;

        public SO1C87AxisMoveTargetResolver(ActuatorSlaveID_SO1C87 slave)
        {
            _slave = slave;
        }

        public AxisTargetData Resolve(string axisName)
        {
            if (axisName.Contains("X"))
                return new AxisTargetData { SlaveAddr = _slave.SlaveID_OISX.XSlaveAddr, MemoryAddr = 0x00 };

            if (axisName.Contains("Y1"))
                return new AxisTargetData { SlaveAddr = _slave.SlaveID_OISY.Y1SlaveAddr, MemoryAddr = 0x00 };

            if (axisName.Contains("Y2"))
                return new AxisTargetData { SlaveAddr = _slave.SlaveID_OISY.Y2SlaveAddr, MemoryAddr = 0x00 };

            throw new NotSupportedException(axisName);
        }
    }

    public class SO1C87AxisReadTargetResolver : IAxisReadTargetResolver
    {
        private readonly ActuatorSlaveID_SO1C87 _slave;

        public SO1C87AxisReadTargetResolver(ActuatorSlaveID_SO1C87 slave)
        {
            _slave = slave;
        }

        public AxisTargetData Resolve(string axisName)
        {
            if (axisName.Contains("X"))
                return new AxisTargetData { SlaveAddr = _slave.SlaveID_OISX.XSlaveAddr, MemoryAddr = 0x84 };

            if (axisName.Contains("Y1"))
                return new AxisTargetData { SlaveAddr = _slave.SlaveID_OISY.Y1SlaveAddr, MemoryAddr = 0x84 };

            if (axisName.Contains("Y2"))
                return new AxisTargetData { SlaveAddr = _slave.SlaveID_OISY.Y2SlaveAddr, MemoryAddr = 0x84 };

            throw new NotSupportedException(axisName);
        }
    }
}
