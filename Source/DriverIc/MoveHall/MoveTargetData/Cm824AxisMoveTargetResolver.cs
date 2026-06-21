using FZ4P.DriverIc.ReadHall.ReadTargetData;
using FZ4P.DriverIc.SlaveID.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.MoveHall.MoveTargetData
{
    public class Cm824AxisMoveTargetResolver : IAxisMoveTargetResolver
    {
        private int _slaveID = 0;
        private int[] Position = new int[] { -1, -1, -1 };

        public Cm824AxisMoveTargetResolver(ActuatorSlaveID_CM824 slave)
        {
            _slaveID = slave.SingleSlaveID.SingleOriginSlaveAddr;

            Position[0] = (int)slave._regMap8WS.Input_pos_x;
            Position[1] = (int)slave._regMap8WS.Input_pos_y;
            Position[2] = (int)slave._regMap8WS.Input_pos_z;
        }

        public AxisTargetData Resolve(string axisName)
        {
            if (axisName.Contains("X"))
                return new AxisTargetData { SlaveAddr = _slaveID, MemoryAddr = Position[0] };

            if (axisName.Contains("Y"))
                return new AxisTargetData { SlaveAddr = _slaveID, MemoryAddr = Position[1] };

            if (axisName.Contains("Z"))
                return new AxisTargetData { SlaveAddr = _slaveID, MemoryAddr = Position[2] };

            throw new NotSupportedException(axisName);
        }
    }

    public class Cm824AxisReadTargetResolver : IAxisReadTargetResolver
    {
        private int _slaveID = 0;
        private int[] Position = new int[] { -1, -1, -1 };

        public Cm824AxisReadTargetResolver(ActuatorSlaveID_CM824 slave)
        {
            _slaveID = slave.SingleSlaveID.SingleOriginSlaveAddr;

            Position[0] = (int)slave._regMap8WS.Input_pos_x;
            Position[1] = (int)slave._regMap8WS.Input_pos_y;
            Position[2] = (int)slave._regMap8WS.Input_pos_z;
        }

        public AxisTargetData Resolve(string axisName)
        {
            if (axisName.Contains("X"))
                return new AxisTargetData { SlaveAddr = _slaveID, MemoryAddr = Position[0] };

            if (axisName.Contains("Y"))
                return new AxisTargetData { SlaveAddr = _slaveID, MemoryAddr = Position[1] };

            if (axisName.Contains("Z"))
                return new AxisTargetData { SlaveAddr = _slaveID, MemoryAddr = Position[2] };

            throw new NotSupportedException(axisName);
        }
    }
}
