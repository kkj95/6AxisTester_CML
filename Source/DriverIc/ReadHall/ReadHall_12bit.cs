using FZ4P.DriverIc.ReadHall.ReadTargetData;
using FZ4P.DriverIc.SlaveID.Context;
using FZ4P.DriverIc.SlaveID.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FZ4P.DriverIc.ReadHall
{
    public class ReadHall_12bit : IReadHall
    {
        private readonly IDlnInterface _dln;
        private readonly IAxisReadTargetResolver _resolver;

        private int slaveAddr;
        private int memoryAddr;
        public ReadHall_12bit(IDlnInterface dln, IAxisReadTargetResolver resolver)
        {
            _dln = dln;
            _resolver = resolver;
        }

        public int Read(int ch, string name)
        {
            byte[] data = new byte[] { 0x00, 0x00 };
            
            var target = _resolver.Resolve(name);
            slaveAddr = target.SlaveAddr;
            memoryAddr = target.MemoryAddr;

            if (slaveAddr != 0x00) _dln.ReadArray(ch, slaveAddr, memoryAddr, data);

            return ((data[0] << 8) + data[1]) >> 4;
        }
    }
}
