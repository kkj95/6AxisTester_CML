using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML.CM824.Registers
{
    public class RegMap_COMMON
    {
        public uint Calib_flash { get; set; } = RegisterMap.CALIB_FLASH;
        public uint Debug_status { get; set; } = RegisterMap.DEBUG_STATUS;
        public uint Fw_actuator_id { get; set; } = RegisterMap.FW_ACTUATOR_ID;
        public uint Fw_build_config_id { get; set; } = RegisterMap.FW_BUILD_CONFIG_ID;
        public uint Fw_build_date { get; set; } = RegisterMap.FW_BUILD_DATE;
        public uint Fw_build_time { get; set; } = RegisterMap.FW_BUILD_TIME;
        public uint Fw_chip_id { get; set; } = RegisterMap.FW_CHIP_ID;
        public uint Fw_uid_h { get; set; } = RegisterMap.FW_UID_H;
        public uint Fw_uid_l { get; set; } = RegisterMap.FW_UID_L;
        public uint Fw_version_major { get; set; } = RegisterMap.FW_VERSION_MAJOR;
        public uint Fw_version_minor { get; set; } = RegisterMap.FW_VERSION_MINOR;
        public uint Fw_version_patch { get; set; } = RegisterMap.FW_VERSION_PATCH;
        public uint Pwm_frequency { get; set; } = RegisterMap.PWM_FREQUENCY;
        public uint Set_pwm_frequency { get; set; } = RegisterMap.SET_PWM_FREQUENCY;
        public uint Sma_config_version { get; set; } = RegisterMap.SMA_CONFIG_VERSION;
        public uint Thermistor { get; set; } = RegisterMap.THERMISTOR;
        public uint Vsync_count { get; set; } = RegisterMap.VSYNC_COUNT;
        public uint Vsync_ctrl { get; set; } = RegisterMap.VSYNC_CTRL;
    }
}
