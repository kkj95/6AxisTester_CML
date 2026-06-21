using FZ4P.DriverIc.IC.CML.CM824.Registers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.SlaveID.ResultData
{
    public class ActuatorMoveCode
    {
        public int AF_MID_CODE { get; set; } = 0x00;
        public int AF_MIN_CODE { get; set; } = 0x00;
        public int AF_MAX_CODE { get; set; } = 0x00;

        public int OIS_MID_CODE { get; set; } = 0x00;
        public int OIS_MIN_CODE { get; set; } = 0x00;
        public int OIS_MAX_CODE { get; set; } = 0x00;
    }

    public class ActuatorSlaveID_AF
    {
        public int AFOriginAddr { get; set; } = 0x00;
        public int AF_Addr { get; set; } = 0x00;
        public int AF_ADC_Addr { get; set; } = 0x00;
    }

    public class ActuatorSlaveID_OISX
    {
        public int XOriginAddr { get; set; } = 0x00;
        public int XSlaveAddr { get; set; } = 0x00;
    }
    public class ActuatorSlaveID_OISY
    {
        public int Y1OriginAddr { get; set; } = 0x00;
        public int Y2OriginAddr { get; set; } = 0x00;
        public int Y1SlaveAddr { get; set; } = 0x00;
        public int Y2SlaveAddr { get; set; } = 0x00;
    }

    public class ActuatorSlaveID_FRA
    {
        public int FRA_Addr { get; set; } = 0x00;

        public int FRA_AFSlaveAddr { get; set; } = 0x00;
        public int FRA_XSlaveAddr { get; set; } = 0x00;
        public int FRA_Y1SlaveAddr { get; set; } = 0x00;
        public int FRA_Y2SlaveAddr { get; set; } = 0x00;
    }

    public class ActuatorSingleSlaveID
    {
        public int SingleOriginSlaveAddr { get; set; } = 0x00;
        public int SingleOriginWriteSlaveAddr { get; set; } = 0x00;
        public int SingleOriginReadSlaveAddr { get; set; } = 0x00;
    }

    public abstract class ActuatorSlaveData
    {   
        public int OIS_ADC_Addr { get; set; } = 0x00;
    }

    public class ActuatorSlaveID_SO1C87 : ActuatorSlaveData
    {
        public ActuatorMoveCode moveCode { get; set; } = new ActuatorMoveCode();
        public ActuatorSlaveID_AF SlaveID_AF { get; set; } = new ActuatorSlaveID_AF();
        public ActuatorSlaveID_OISX SlaveID_OISX { get; set; } = new ActuatorSlaveID_OISX();
        public ActuatorSlaveID_OISY SlaveID_OISY { get; set; } = new ActuatorSlaveID_OISY();
        public ActuatorSlaveID_FRA SlaveID_FRA { get; set; } = new ActuatorSlaveID_FRA();
    }
    public class ActuatorSlaveID_SO2810 : ActuatorSlaveData
    {
        public ActuatorMoveCode moveCode { get; set; } = new ActuatorMoveCode();
        public ActuatorSlaveID_AF SlaveID_AF { get; set; } = new ActuatorSlaveID_AF();
        public ActuatorSlaveID_OISX SlaveID_OISX { get; set; } = new ActuatorSlaveID_OISX();
        public ActuatorSlaveID_OISY SlaveID_OISY { get; set; } = new ActuatorSlaveID_OISY();
        public ActuatorSlaveID_FRA SlaveID_FRA { get; set; } = new ActuatorSlaveID_FRA();
    }
    public class ActuatorSlaveID_SO1C86 : ActuatorSlaveData
    {
        public ActuatorMoveCode moveCode { get; set; } = new ActuatorMoveCode();
        public ActuatorSlaveID_AF SlaveID_AF { get; set; } = new ActuatorSlaveID_AF();
        public ActuatorSlaveID_OISX SlaveID_OISX { get; set; } = new ActuatorSlaveID_OISX();
        public ActuatorSlaveID_OISY SlaveID_OISY { get; set; } = new ActuatorSlaveID_OISY();
        public ActuatorSlaveID_FRA SlaveID_FRA { get; set; } = new ActuatorSlaveID_FRA();
    }
    public class ActuatorSlaveID_CM824 : ActuatorSlaveData
    {
        public ActuatorMoveCode moveCode { get; set; } = new ActuatorMoveCode();
        public ActuatorSingleSlaveID SingleSlaveID { get; set; } = new ActuatorSingleSlaveID();

        public RegMap_8WS _regMap8WS            { get; set; }       = new RegMap_8WS();
        public RegMap_AF _regMapAF              { get; set; }       = new RegMap_AF();
        public RegMap_APOIS _regMapAPOIS        { get; set; }       = new RegMap_APOIS();
        public RegMap_CM824 _regMapCM824        { get; set; }       = new RegMap_CM824();
        public RegMap_COMMON _regMapCOMMON      { get; set; }       = new RegMap_COMMON();
        public RegMap_EIS _regMapEIS            { get; set; }       = new RegMap_EIS();
        public RegMap_MP _regMapMP              { get; set; }       = new RegMap_MP();
        public RegMap_OIS _regMapOIS            { get; set; }       = new RegMap_OIS();
    }
}
