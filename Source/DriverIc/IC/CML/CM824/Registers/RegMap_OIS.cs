using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML.CM824.Registers
{
    public class RegMap_OIS
    {
        public uint gyro_ctrl                  { get; set; } = RegisterMap.GYRO_CTRL;
        public uint servo_ctrl                 { get; set; } = RegisterMap.SERVO_CTRL;
        public uint status                     { get; set; } = RegisterMap.STATUS;
        public uint tempest_offset             { get; set; } = RegisterMap.TEMPEST_OFFSET;
    }
}
