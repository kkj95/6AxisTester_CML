using Dln;
using FZ4P.DriverIc.IC.CML.CM824.RegisterMaps;
using FZ4P.DriverIc.IC.CML.CM824.Registers;
using FZ4P.DriverIc.Interfaces;
using FZ4P.DriverIc.MoveHall.Context;
using FZ4P.DriverIc.MoveHall.Parameters;
using FZ4P.DriverIc.ReadHall.Context;
using FZ4P.DriverIc.SlaveID.Context;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML.CM824
{
    /// <summary>
    /// handler 역할을 해야됨.
    /// </summary>
    public class CM824 : IDriverIC_AF_Function,IDriverIC_OIS_Function
    {
        private readonly IDlnInterface _dln;
        //슬레이브 주소 정보

        public int OriginAddr { get; set; } = 0x72;
        public int WriteSlaveAddress { get; set; } = 0xE4;
        public int ReadSlaveAddress { get; set; } = 0xE5;

        //레지스터 맵(논리적 주소)
        private RegMap_8WS _regMap8WS = new RegMap_8WS();
        private RegMap_AF _regMapAF = new RegMap_AF();
        private RegMap_APOIS _regMapAPOIS = new RegMap_APOIS();
        private RegMap_CM824 _regMapCM824 = new RegMap_CM824();
        private RegMap_COMMON _regMapCOMMON = new RegMap_COMMON();
        private RegMap_EIS _regMapEIS = new RegMap_EIS();
        private RegMap_MP _regMapMP = new RegMap_MP();
        private RegMap_OIS _regMapOIS = new RegMap_OIS();

        private readonly ActuatorType actuatorType = ActuatorType.TypeCM824;

        public CM824(IDlnInterface dln)
        {
            _dln = dln;
        }

        #region AF Function
        public void AFMove(int ch, int code)
        {
            int memoryAddress = (int)_regMap8WS.Input_pos_z;
            _dln.Write2Byte(ch, OriginAddr, memoryAddress, 1, (ushort)code);
        }

        public void AFOnOff(int ch, bool isOn)
        {
            int memoryAddress = (int)_regMapAF.Tempest_offset;
            ushort temp_offset = 0x0000;
            ushort bitServoOnOff = 0x0000;

            if (isOn)
                bitServoOnOff = (ushort)RegisterMap.SERVO_CTRL_ENABLE;

            _dln.Write2Byte(ch, OriginAddr, (int)memoryAddress, 1, temp_offset);

            memoryAddress = (int)_regMapAF.Servo_ctrl;
            _dln.Write2Byte(ch, OriginAddr, memoryAddress, 1, bitServoOnOff);
        }

        public int ReadAFHall(int ch)
        {
            int memoryAddress = (int)_regMap8WS.Input_pos_z;

            //버전?? 에따라 읽어오는게 달라질수 있어보인다?? 아직 모름...
            //int memoryAddress = (int)_regMap8WS.buf_Input_pos_z;
            
            return (int)_dln.Read2Byte(ch, OriginAddr, memoryAddress, 1);
        }

        public void RegisterZeroSet(int iCh, int TargetSlaveID, byte address)
        {

            throw new NotImplementedException();
        }

        #region 해당 동작과 맞지않는 단위 동작?? 및 기능 해석이 추가적으로 필요한 메서드들...
        public bool ICReset(int ch)
        {
            throw new NotImplementedException();
        }
        public void AFSleep(int ch)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// AF 메모리 업데이트에 필요한 데이터를 넣어주는 곳...
        /// </summary>
        /// <param name="ch"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AF_IC_Data(int ch)
        {
            throw new NotImplementedException();
        }

        public bool AF_Memory_Update(int ch, int mode)
        {
            throw new NotImplementedException();
        }

        public bool ChangeSlaveAddr(int ch)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion

        #region OIS Function
        public bool ChangeSlaveAddrOIS(int ch)
        {
            throw new NotImplementedException();
        }

        public void OIS_drift_test_mode_init(int ch, bool status)
        {
            throw new NotImplementedException();
        }

        public void OIS_drift_test_mode_close(int ch, bool status)
        {
            throw new NotImplementedException();
        }

        public void OISOn(int ch, string name, bool isOn)
        {
            throw new NotImplementedException();
        }

        public bool Move(int ch, string name, int pos, bool openLoop = false)
        {
            var param = new MoveHallContextParam() {
                actuatorType = actuatorType,
            };
            var context = new MoveHallContext(IC_BITUSE.BIT_13, _dln, param);
            return context.Move(ch, name, pos, openLoop);
        }

        public int ReadHall(int ch, string name)
        {
            throw new NotImplementedException();
        }

        public int ReadHallOpenLoop(int ch, string name)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
