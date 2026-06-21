using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.Interfaces
{
    public interface IDriverIC_AF_Function
    {
        #region AF Function
        bool ChangeSlaveAddr(int ch);
        bool AF_Memory_Update(int ch, int mode);
        void AF_IC_Data(int ch);
        bool ICReset(int ch);                               //IC Reset 
        void AFSleep(int ch);
        void AFOnOff(int ch, bool isOn);                    //서보 OnOff
        void AFMove(int ch, int code);                      //모션 구동

        void RegisterZeroSet(int iCh, int TargetSlaveID, byte address);
        int ReadAFHall(int ch);                             //모션값 읽기
        #endregion
    }
}
