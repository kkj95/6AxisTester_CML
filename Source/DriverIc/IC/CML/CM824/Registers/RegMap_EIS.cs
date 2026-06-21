using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML.CM824.Registers
{
    public class RegMap_EIS
    {
        public uint Eis_ctrl { get; set; } = RegisterMap.EIS_CTRL;
        public uint Eis_data_0 { get; set; } = RegisterMap.EIS_DATA0;
        public uint Eis_data_ctrl { get; set; } = RegisterMap.EIS_DATA_CTRL;
        public uint Eis_mode { get; set; } = RegisterMap.EIS_MODE;
        public uint Eis_packet_trigger { get; set; } = RegisterMap.EIS_PACKET_TRIGGER;
        public uint Eis_qtimer_write { get; set; } = RegisterMap.EIS_QTIMER_WRITE;
        public uint Eis_sample_format { get; set; } = RegisterMap.EIS_SAMPLE_FORMAT;
        public uint Eis_sample_period { get; set; } = RegisterMap.EIS_SAMPLE_PERIOD;
        public uint Vsync_ctrl { get; set; } = RegisterMap.VSYNC_CTRL;
    }
}
