using FZ4P.DriverIc.MoveHall.MoveTargetData;
using FZ4P.DriverIc.SlaveID.Context;
using FZ4P.DriverIc.SlaveID.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.MoveHall
{
    public class MoveHall_13Bit : IMoveHall
    {
        private readonly IDlnInterface _dln;
        private readonly IAxisMoveTargetResolver _axisMoveTargetResolver;

        private int slaveAddr;
        private int memoryAddr;

        public MoveHall_13Bit(IDlnInterface dln, IAxisMoveTargetResolver axisMoveTargetResolver)
        {
            _dln = dln;
            _axisMoveTargetResolver = axisMoveTargetResolver;
        }

        public bool Move(int ch, string name, int pos, bool openLoop = false)
        {
            int data = pos << 3;
            byte[] buff = new byte[2] { (byte)(data >> 8), (byte)(data % 256) };

            var target = _axisMoveTargetResolver.Resolve(name);
            slaveAddr = target.SlaveAddr;
            memoryAddr = target.MemoryAddr;

            if (!_dln.WriteArray(ch, slaveAddr, memoryAddr, buff)) return false;

            return true;
        }
    }
}
