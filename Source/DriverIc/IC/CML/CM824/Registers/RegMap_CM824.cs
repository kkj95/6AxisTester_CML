using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML.CM824.Registers
{
    public class RegMap_CM824
    {
        public const uint FLASH_CONFIG = 0x40006402;
        public const uint HW_REVISION = 0x2f02a;
        public uint Debug_status { get; set; } = RegisterMap.DEBUG_STATUS;
        public uint Device_reset { get; set; } = RegisterMap.DEVICE_RESET;
        public uint Flash_bank_protect { get; set; } = RegisterMap.FLASH_BANK_PROTECT;
        public uint Flash_config { get; set; } = FLASH_CONFIG;
        public uint Flash_program_type { get; set; } = RegisterMap.FLASH_PROGRAM_TYPE;
        public uint Flash_sector_erase { get; set; } = RegisterMap.FLASH_SECTOR_ERASE;
        public uint Flash_unlock { get; set; } = RegisterMap.FLASH_UNLOCK;
        public uint Flash_write_address { get; set; } = RegisterMap.FLASH_WRITE_ADDRESS;
        public uint Flash_write_data { get; set; } = RegisterMap.FLASH_WRITE_DATA;
        public uint Fw_status { get; set; } = RegisterMap.FW_STATUS;
        public uint Fw_uid_h { get; set; } = RegisterMap.FW_UID_H;
        public uint Fw_uid_l { get; set; } = RegisterMap.FW_UID_L;
        public uint Fw_version_major { get; set; } = RegisterMap.FW_VERSION_MAJOR;
        public uint Fw_version_minor { get; set; } = RegisterMap.FW_VERSION_MINOR;
        public uint Fw_version_patch { get; set; } = RegisterMap.FW_VERSION_PATCH;
        public uint Hif_checksum { get; set; } = RegisterMap.HIF_CHECKSUM;
        public uint Hif_checksum_enable { get; set; } = RegisterMap.HIF_CHECKSUM_ENABLE;
        public uint Hif_data_len { get; set; } = RegisterMap.HIF_DATA_LEN;
        public uint Hif_data_port { get; set; } = RegisterMap.HIF_DATA_PORT;
        public uint Hif_rd_addr { get; set; } = RegisterMap.HIF_RD_ADDR;
        public uint Hif_status { get; set; } = RegisterMap.HIF_STATUS;
        public uint Hif_wr_addr { get; set; } = RegisterMap.HIF_WR_ADDR;
        public uint Hw_revision { get; set; } = HW_REVISION;
        public uint Image_checksum { get; set; } = RegisterMap.IMAGE_CHECKSUM;
        public uint Lp_ctrl { get; set; } = RegisterMap.LP_CTRL;
        public uint Part_id { get; set; } = RegisterMap.PART_ID;
        public uint Sys_status { get; set; } = RegisterMap.SYS_STATUS;
        public uint Sys_unlock { get; set; } = RegisterMap.SYS_UNLOCK;
        public uint Thermistor_status { get; set; } = RegisterMap.THERMISTOR_STATUS;
        public uint Voltage_status { get; set; } = RegisterMap.VOLTAGE_STATUS;
        public uint Wire_status { get; set; } = RegisterMap.WIRE_STATUS;


        #region 조건부 레지스터 임시 주석
        //조건부 레지스터 주소
        //public uint Process_ready { get; set; } = RegisterMap.PROCESS_READY_CM824;
        //public uint Process_request_1 { get; set; } = RegisterMap.PROCESS_REQUEST_1_CM824;
        //public uint Process_request_2 { get; set; } = RegisterMap.PROCESS_REQUEST_2_CM824;
        //public uint Process_request_3 { get; set; } = RegisterMap.PROCESS_REQUEST3;
        #endregion
    }
}
