using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;

namespace FZ4P.DriverIc.IC.CML.CM824.Registers
{
    public class RegMap_8WS
    {
        public uint Buf_input_pos_x { get; set; } = RegisterMap.BUF_INPUT_POS_X;
        public uint Buf_input_pos_y { get; set; } = RegisterMap.BUF_INPUT_POS_Y;
        public uint Buf_input_pos_z { get; set; } = RegisterMap.BUF_INPUT_POS_Z;
        public uint Buf_pos_est_x { get; set; } = RegisterMap.BUF_POS_EST_X;
        public uint Buf_pos_est_y { get; set; } = RegisterMap.BUF_POS_EST_Y;
        public uint Buf_pos_est_z { get; set; } = RegisterMap.BUF_POS_EST_Z;
        public uint Input_pos_x { get; set; } = RegisterMap.INPUT_POS_X;
        public uint Input_pos_y { get; set; } = RegisterMap.INPUT_POS_Y;
        public uint Input_pos_z { get; set; } = RegisterMap.INPUT_POS_Z;
        public uint Pos_est_x { get; set; } = RegisterMap.POS_EST_X;
        public uint Pos_est_y { get; set; } = RegisterMap.POS_EST_Y;
        public uint Pos_est_z { get; set; } = RegisterMap.POS_EST_Z;
        public uint rmid_cal0 { get; set; } = RegisterMap.RMID_CAL0;
        public uint rmid_cal1 { get; set; } = RegisterMap.RMID_CAL1;
        public uint rmid_cal2 { get; set; } = RegisterMap.RMID_CAL2;
        public uint rmid_cal3 { get; set; } = RegisterMap.RMID_CAL3;
        public uint rmid_cal4 { get; set; } = RegisterMap.RMID_CAL4;
        public uint rmid_cal5 { get; set; } = RegisterMap.RMID_CAL5;
        public uint rmid_cal6 { get; set; } = RegisterMap.RMID_CAL6;
        public uint rmid_cal7 { get; set; } = RegisterMap.RMID_CAL7;
        public uint user_input_pos_x { get; set; } = RegisterMap.USER_INPUT_POS_X;
        public uint user_input_pos_y { get; set; } = RegisterMap.USER_INPUT_POS_Y;
        public uint user_input_pos_z { get; set; } = RegisterMap.USER_INPUT_POS_Z;
    }
}
