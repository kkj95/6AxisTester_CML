using FZ4P.DriverIc.MoveHall.Parameters;
using FZ4P.DriverIc.ReadHall.ReadTargetData;
using FZ4P.DriverIc.SlaveID.Context;
using FZ4P.DriverIc.SlaveID.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.MoveHall.MoveTargetData
{
    public class AxisTargetFactory
    {

        public IAxisMoveTargetResolver CreateAxisMoveTargetResolver(ActuatorSlaveData SlaveID)
        {
            if(SlaveID is ActuatorSlaveID_SO1C87 slave1C87)
                return new SO1C87AxisMoveTargetResolver(slave1C87);
            else if (SlaveID is ActuatorSlaveID_CM824 slaveCM824)
                return new Cm824AxisMoveTargetResolver(slaveCM824);

            throw new ArgumentNullException("로직에 명시되지 않는 타입입니다 확인 바랍니다.");
        }
        public IAxisReadTargetResolver CreateAxisReadTargetResolver(ActuatorSlaveData SlaveID)
        {
            if (SlaveID is ActuatorSlaveID_SO1C87 slave1C87)
                return new SO1C87AxisReadTargetResolver(slave1C87);
            //else if (SlaveID is ActuatorSlaveID_CM824 slaveCM824)
            //    return new Cm824AxisMoveTargetResolver(slaveCM824);

            throw new ArgumentNullException("로직에 명시되지 않는 타입입니다 확인 바랍니다.");
        }
    }
}
