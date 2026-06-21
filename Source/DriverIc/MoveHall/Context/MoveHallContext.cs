using FZ4P.Commons.Helper;
using FZ4P.DriverIc.MoveHall.MoveTargetData;
using FZ4P.DriverIc.MoveHall.Parameters;
using FZ4P.DriverIc.ReadHall;
using FZ4P.DriverIc.ReadHall.Context;
using FZ4P.DriverIc.SlaveID.Context;
using FZ4P.DriverIc.SlaveID.ResultData;
using FZ4P.Logic.OISPeakCurrent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.MoveHall.Context
{
    public class MoveHallContext 
    {
        private readonly IMoveHall moveHall;
        private readonly AxisTargetFactory _resolverFactory = new AxisTargetFactory();
        private readonly StrategySlaveIDContext strategySlaveIDContext = new StrategySlaveIDContext();

        public MoveHallContext(IC_BITUSE type, IDlnInterface dln, MoveHallContextParam param)
        {
            var SlaveID = strategySlaveIDContext.GetSlaveID(param.actuatorType);
            var resolver =_resolverFactory.CreateAxisMoveTargetResolver(SlaveID);

            switch (type)
            {
                case IC_BITUSE.BIT_12:
                    moveHall = new MoveHall_12Bit(dln, resolver);
                    break;

                case IC_BITUSE.BIT_13:
                    moveHall = new MoveHall_13Bit(dln, resolver);
                    break;

                default : 
                    moveHall = new MoveHall(dln, resolver);
                    break;
            }
        }

        public bool Move(int ch, string name, int pos, bool openLoop = false)
        {
            return moveHall.Move(ch, name, pos, openLoop);
        }

    }
}
