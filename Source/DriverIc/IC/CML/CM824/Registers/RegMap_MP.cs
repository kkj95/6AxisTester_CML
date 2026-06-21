using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML.CM824.Registers
{
    public class RegMap_MP
    {
        public uint Acc_raw_x                  { get; set; } = RegisterMap.ACC_RAW_X;
        public uint Acc_raw_y                  { get; set; } = RegisterMap.ACC_RAW_Y;
        public uint Acc_raw_z                  { get; set; } = RegisterMap.ACC_RAW_Z;
        public uint Buf_gyro_raw_x             { get; set; } = RegisterMap.BUF_GYRO_RAW_X;
        public uint Buf_gyro_raw_y             { get; set; } = RegisterMap.BUF_GYRO_RAW_Y;
        public uint Buf_gyro_raw_z             { get; set; } = RegisterMap.BUF_GYRO_RAW_Z;
        public uint Buf_mp_output_x            { get; set; } = RegisterMap.BUF_MP_OUTPUT_X;
        public uint Buf_mp_output_y            { get; set; } = RegisterMap.BUF_MP_OUTPUT_Y;
        public uint Buf_mp_output_z            { get; set; } = RegisterMap.BUF_MP_OUTPUT_Z;
        public uint Debug_status               { get; set; } = RegisterMap.DEBUG_STATUS;
        public uint Gyro_calib                 { get; set; } = RegisterMap.GYRO_CALIB;
        public uint Gyro_ctrl                  { get; set; } = RegisterMap.GYRO_CTRL;
        public uint Gyro_raw_x                 { get; set; } = RegisterMap.GYRO_RAW_X;
        public uint Gyro_raw_y                 { get; set; } = RegisterMap.GYRO_RAW_Y;
        public uint Gyro_raw_z                 { get; set; } = RegisterMap.GYRO_RAW_Z;
        public uint Mp_acc_offset_x            { get; set; } = RegisterMap.MP_ACC_OFFSET_X;
        public uint Mp_acc_offset_y            { get; set; } = RegisterMap.MP_ACC_OFFSET_Y;
        public uint Mp_acc_offset_z            { get; set; } = RegisterMap.MP_ACC_OFFSET_Z;
        public uint Mp_axis_alignment          { get; set; } = RegisterMap.MP_AXIS_ALIGNMENT;
        public uint Mp_gain_pol_z              { get; set; } = RegisterMap.MP_GAIN_POL_Z;
        public uint Mp_gyr_xgg                 { get; set; } = RegisterMap.MP_GYR_XGG;
        public uint Mp_gyr_ygg                 { get; set; } = RegisterMap.MP_GYR_YGG;
        public uint Mp_gyro_bias_accuracy      { get; set; } = RegisterMap.MP_GYRO_BIAS_ACCURACY;
        public uint Mp_gyro_bias_x             { get; set; } = RegisterMap.MP_GYRO_BIAS_X;
        public uint Mp_gyro_bias_y             { get; set; } = RegisterMap.MP_GYRO_BIAS_Y;
        public uint Mp_gyro_bias_z             { get; set; } = RegisterMap.MP_GYRO_BIAS_Z;
        public uint Mp_output_x                { get; set; } = RegisterMap.MP_OUTPUT_X;
        public uint Mp_output_y                { get; set; } = RegisterMap.MP_OUTPUT_Y;
        public uint Mp_output_z                { get; set; } = RegisterMap.MP_OUTPUT_Z;
        public uint Mp_phase_comp_x0           { get; set; } = RegisterMap.MP_PHASE_COMP_X0;
        public uint Mp_phase_comp_x1           { get; set; } = RegisterMap.MP_PHASE_COMP_X1;
        public uint Mp_phase_comp_y0           { get; set; } = RegisterMap.MP_PHASE_COMP_Y0;
        public uint Mp_phase_comp_y1           { get; set; } = RegisterMap.MP_PHASE_COMP_Y1;
        public uint Set_imu                    { get; set; } = RegisterMap.SET_IMU;
    }
}
