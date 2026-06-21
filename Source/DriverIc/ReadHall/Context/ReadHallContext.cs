using FZ4P.DriverIc.MoveHall.MoveTargetData;
using FZ4P.DriverIc.MoveHall.Parameters;
using FZ4P.DriverIc.SlaveID.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.ReadHall.Context
{
    public enum IC_BITUSE
    {
        BIT_12 = 0,
        BIT_13 = 1,
    };

    public class ReadHallContext
    {
        private readonly IReadHall readHall;

        private readonly AxisTargetFactory _resolverFactory = new AxisTargetFactory();
        private readonly StrategySlaveIDContext strategySlaveIDContext = new StrategySlaveIDContext();
        public ReadHallContext(IC_BITUSE type, IDlnInterface dln, MoveHallContextParam param)
        {
            var SlaveID = strategySlaveIDContext.GetSlaveID(param.actuatorType);
            var resolver = _resolverFactory.CreateAxisReadTargetResolver(SlaveID);

            switch (type)
            {
                case IC_BITUSE.BIT_12:
                    readHall = new ReadHall_12bit(dln, resolver);
                    break;

                case IC_BITUSE.BIT_13:
                    readHall = new ReadHall_13bit(dln, resolver);
                    break;
            }
        }

        public int ReadHall(int ch, string name)
        {
            return readHall.Read(ch, name);
        }
    }
}
