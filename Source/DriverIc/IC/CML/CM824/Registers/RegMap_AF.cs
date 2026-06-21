using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML.CM824.Registers
{
    public class RegMap_AF
    {
        public uint Af_target { get; set; } = RegisterMap.AF_TARGET;
        public uint Servo_ctrl { get; set; } = RegisterMap.SERVO_CTRL;
        public uint Status { get; set; } = RegisterMap.STATUS;
        public uint Tempest_offset { get; set; } = RegisterMap.TEMPEST_OFFSET;
    }
}
