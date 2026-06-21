using FZ4P.DriverIc.SlaveID.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.SlaveID
{
    public class Strategy_SlaveID_CM824 : IStrategySlaveID
    {
        public ActuatorSlaveData GetSlaveID()
        {
            return new ActuatorSlaveID_CM824()
            {
                moveCode = new ActuatorMoveCode()
                {
                    AF_MID_CODE = 2048,
                    AF_MAX_CODE = 4095,
                    AF_MIN_CODE = 0,

                    OIS_MID_CODE = 4096,
                    OIS_MAX_CODE = 8191,
                    OIS_MIN_CODE = 0,
                },

                SingleSlaveID = new ActuatorSingleSlaveID()
                {
                    SingleOriginSlaveAddr = 0x72,
                    SingleOriginWriteSlaveAddr = 0xE4,
                    SingleOriginReadSlaveAddr = 0xE5,
                },

                OIS_ADC_Addr = 0x00, // 미사용
            };
        }
    }
}
