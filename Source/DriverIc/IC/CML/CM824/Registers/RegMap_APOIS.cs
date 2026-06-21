using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML.CM824.Registers
{
    public class RegMap_APOIS
    {
        public uint Freefall_state { get; set; } = RegisterMap.FREEFALL_STATE;
        public uint Mp_motion_level { get; set; } = RegisterMap.MP_MOTION_LEVEL;
        public uint Mp_stroke_win_x { get; set; } = RegisterMap.MP_STROKE_WIN_X;
        public uint Mp_stroke_win_y { get; set; } = RegisterMap.MP_STROKE_WIN_Y;
        public uint Mp_stroke_win_z { get; set; } = RegisterMap.MP_STROKE_WIN_Z;
    }
}
