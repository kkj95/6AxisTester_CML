using FZ4P.DriverIc.SlaveID.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.SlaveID
{
    /// <summary>
    /// 데이터 구조만 일단 잡았고... 실제 사용여부는 확인하여 구성해야된다.
    /// </summary>
    public class Strategy_SlaveID_1C87 : IStrategySlaveID
    {
        public ActuatorSlaveData GetSlaveID()
        {
            return new ActuatorSlaveID_SO1C87()
            {
                SlaveID_AF = new ActuatorSlaveID_AF()
                {
                    // AFOriginAddr = 0x0C;
                    AF_Addr = 0x0C,
                    AF_ADC_Addr = 0x48,
                },

                moveCode = new ActuatorMoveCode()
                {
                    AF_MID_CODE = 2048,
                    AF_MAX_CODE = 4095,
                    AF_MIN_CODE = 0,

                    OIS_MID_CODE = 4096,
                    OIS_MAX_CODE = 8191,
                    OIS_MIN_CODE = 0,
                },

                SlaveID_OISX = new ActuatorSlaveID_OISX()
                {
                    XOriginAddr = 0x0E,
                    XSlaveAddr = 0x0E,
                },

                SlaveID_OISY = new ActuatorSlaveID_OISY()
                {
                    Y1OriginAddr = 0x4E,
                    Y2OriginAddr = 0x00,
                    Y1SlaveAddr = 0x4E,
                    Y2SlaveAddr = 0x00,
                },

                SlaveID_FRA = new ActuatorSlaveID_FRA()
                {
                    FRA_Addr = 0x14,

                    FRA_AFSlaveAddr = 0x18,
                    FRA_XSlaveAddr = 0x1C,
                    FRA_Y1SlaveAddr = 0x9C,
                    FRA_Y2SlaveAddr = 0xD8,
                },

                OIS_ADC_Addr = 0x49,
            };
        }
    }
}
