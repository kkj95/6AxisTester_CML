using FZ4P.DriverIc.SlaveID.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.SlaveID
{
    public class Strategy_SlaveID_2810 : IStrategySlaveID
    {
        public ActuatorSlaveData GetSlaveID()
        {
            return new ActuatorSlaveID_SO2810()
            {
                SlaveID_AF = new ActuatorSlaveID_AF()
                {
                    AFOriginAddr = 0x0C,
                    AF_Addr = 0x28,

                },

                moveCode = new ActuatorMoveCode()
                {
                    AF_MID_CODE = 2048,
                    AF_MAX_CODE = 4095,
                    AF_MIN_CODE = 0,
                },

                SlaveID_OISX = new ActuatorSlaveID_OISX()
                {
                    XOriginAddr = 0x0E,
                    XSlaveAddr = 0x70,
                },

                SlaveID_OISY = new ActuatorSlaveID_OISY()
                {
                    Y1OriginAddr = 0x4E,
                    Y2OriginAddr = 0x00,
                    Y1SlaveAddr = 0x30,
                    Y2SlaveAddr = 0x00,
                },

                SlaveID_FRA = new ActuatorSlaveID_FRA()
                {
                    FRA_Addr = 0x14,
                    FRA_AFSlaveAddr = 0x50,
                    FRA_XSlaveAddr = 0xE0,
                    FRA_Y1SlaveAddr = 0x60,
                    FRA_Y2SlaveAddr = 0x00,
                },

                //미사용
                OIS_ADC_Addr = 0x00,
            };
        }
    }
}
