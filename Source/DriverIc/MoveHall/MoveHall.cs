using FZ4P.DriverIc.MoveHall.MoveTargetData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.MoveHall
{
    public class MoveHall : IMoveHall
    {
        private readonly IDlnInterface _dln;
        private readonly IAxisMoveTargetResolver _axisResolver;

        private int slaveAddr;
        private int memoryAddr;

        public MoveHall(IDlnInterface dln, IAxisMoveTargetResolver axisResolver)
        {
            _dln = dln;
            _axisResolver = axisResolver;
        }

        public bool Move(int ch, string name, int pos, bool openLoop = false)
        {
            int data = pos;
            byte[] buff = new byte[2] { (byte)(data >> 8), (byte)(data % 256) };

            var target = _axisResolver.Resolve(name);
            slaveAddr = target.SlaveAddr;
            memoryAddr = target.MemoryAddr;

            if (!_dln.WriteArray(ch, slaveAddr, memoryAddr, buff)) return false;
            return true;
        }
    }

}
