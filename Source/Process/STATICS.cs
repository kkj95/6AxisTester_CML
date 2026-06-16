using FZ4P.BarcodeReader;
using FZ4P.BarcodeReader.CommandLine.Keyens;
using FZ4P.BarcodeReader.FileSelector;
using FZ4P.DriverIc.Adapter;
using FZ4P.UI;
using Modules.Communication.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace FZ4P
{
    public enum DeviceType
    {
        DLN,
        ESP32
    }
    public class DeviceConfig
    {
        public DeviceType SelectedType { get; set; } = DeviceType.DLN;
        public string Esp32Ip { get; set; } = "192.168.1.101";
    }

    public static class DeviceFactory
    {
        public static void CreateDevices(DeviceConfig config, out IDlnInterface mainDln, out IDlnInterface lightDln)
        {
            switch (config.SelectedType)
            {
                case DeviceType.ESP32:
                    // ESP32 사용 시 (LightDln이 필요 없거나 별도 주소라면 여기서 설정)
                    mainDln = new Esp32WifiDevice(config.Esp32Ip);
                    lightDln = new DlnAdapter(new DLN(1));
                    break;

                case DeviceType.DLN:
                default:
                    // DLN 사용 시 (기존 코드의 0번, 1번 인덱스 할당)
                    mainDln = new DlnAdapter(new DLN(0));
                    lightDln = null;
                    break;
            }
        }

    }
    public static class STATIC
    {
        public static FVision fVision = new FVision();
        public static F_Manage fManage = new F_Manage();
        //public static F_Start fStart = new F_Start();
        public static HandlerConnection TcpConn = new HandlerConnection();
        public static int I2CFailcnt = 0;
        public static int I2CFailToDisonnectCount = 0;
        public static string SaveLogData = string.Empty;

        public static F_SystemLogView fSystemLogView = new F_SystemLogView();

        public static F_Manual fManual = new F_Manual();

        public enum STATE
        {
            Manage,
            Main,
            Vision,
        }
        private static int state = 0;
        public static int State
        {
            get { return state; }
            set { if (state != value) state = value; StateChange?.Invoke(null, EventArgs.Empty); }
        }

        public static event EventHandler StateChange = null;

        public static string BaseDir = "C:\\6AxisTester\\";
        public static string RecipeDir = BaseDir + "Recipe\\";
        public static string SpecDir = BaseDir + "Spec\\";
        public static string RootDir = BaseDir + "\\DoNotTouch\\";
        public static string DataDir = BaseDir + "\\Data\\";
        public static string UserScriptDir = BaseDir + "\\DriverIC\\FW\\";
        public static string OptionPath = RootDir + "OptionState.txt";
        public static string YieldPath = RootDir + "Yield.txt";
        public static string YieldItemPath = RootDir + "YieldItem.txt";
        public static string CurrentPath = RootDir + "CurrPath.txt";
        public static string PackageDir = BaseDir + "Package\\";
        public static string TestTimeDir = RootDir + "TestTime.txt";
        public static string VisionFileDir = RootDir + "VisionFile.txt";
        public static string RetryCountDir = RootDir + "RetryCount.txt";
        public static string PasswordDir = RootDir + "PW.txt";
        public static string ScannerDir = RootDir + "ScannerType\\";
        public static string AFPIDDir = BaseDir + "AFPID\\";
        public static string OISPIDDir = BaseDir + "OISPID\\";
        public static DateTime LogDate = new DateTime();
        public static string FailNumber = string.Empty;
        public static string ActID = string.Empty;

        public static string PKGRelease(string srcdir, string Ext, string destdir)
        {

            string[] Arr = Directory.GetFiles(srcdir, Ext);
            string destFile = string.Empty;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Contains("CurrentPath ") || Arr[i].Contains("MCInfo"))
                    continue;
                destFile = destdir + Arr[i].Substring(srcdir.Length);
                if (File.Exists(destFile))
                    File.Delete(destFile);
                File.Move(Arr[i], destFile);
            }
            return destFile;
        }
        public static string PKGRelease(string srcdir, string Ext, string destdir, string formatText)
        {

            string[] Arr = Directory.GetFiles(srcdir, Ext).Where(f => Path.GetFileName(f).Contains(formatText)).ToArray();
            string destFile = string.Empty;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Contains("CurrentPath ") || Arr[i].Contains("MCInfo"))
                    continue;
                destFile = destdir + Arr[i].Substring(srcdir.Length);
                if (File.Exists(destFile))
                    File.Delete(destFile);
                File.Move(Arr[i], destFile);
            }
            return destFile;
        }
        public static void SetTextLine(string path, List<string> list)
        {
            try
            {
                string FilePath = path;
                //if (!File.Exists(FilePath)) return;
                StreamWriter sw = new StreamWriter(FilePath);
                for (int i = 0; i < list.Count; i++)
                { sw.WriteLine(list[i]); }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static List<string> GetTextAll(string path)
        {
            List<string> result = new List<string>();
            string FilePath = path;
            if (!File.Exists(FilePath)) return null;
            StreamReader sr = new StreamReader(FilePath);
            while (sr.Peek() >= 0)
            {
                result.Add(sr.ReadLine());
            }
            sr.Close();
            return result;
        }
        public static byte[] BinFileRead(string fileName)
        {
            byte[] reselt;
            if (fileName != "")
            {
                if (!File.Exists(fileName))
                {
                    return null;
                }
                BinaryReader binReader = new BinaryReader(File.Open(fileName, FileMode.Open));
                int count = (int)binReader.BaseStream.Length;
                reselt = binReader.ReadBytes(count);
                binReader.Close();
            }
            else
            {
                return null;
            }
            return reselt;
        }
        public static string OpenFile(string InitDir, string ext, bool save = false)
        {
            FileDialog op;
            if (save) op = new SaveFileDialog();
            else op = new OpenFileDialog();

            op.InitialDirectory = InitDir;
            if (ext != "") ext = ext.Remove(0, 1);
            op.Filter = "*." + ext + "|*." + ext;
            if (op.ShowDialog() == DialogResult.OK)
                return op.FileName;
            else return null;
        }
        public static string CreateDateDir()
        {
            DateTime dt = STATIC.LogDate;
            string dir = string.Format("{0}\\{1}\\{2}\\{3}\\", DataDir, dt.Year, dt.Month, dt.Day);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return dir;
        }
        public static char GetEthernetIPv4()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Wi-Fi 제외 조건
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    continue;

                // 비활성화된 NIC 제외
                if (ni.OperationalStatus != OperationalStatus.Up)
                    continue;

                // IPv4 검색
                foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    {

                        string s = ip.Address.ToString();

                        return s[s.Length - 1];
                    }
                }
            }
            return '0';
        }



        public static Recipe Rcp = new Recipe();
        public static Process Process = new Process();
        //DLN 사용 시 
        //public static IDlnInterface Dln = new DlnAdapter(new DLN(0));
        //ESP32 사용 시
        //public static IDlnInterface LightDln = new DlnAdapter(new DLN(1));
        //public static IDlnInterface Dln = new Esp32WifiDevice("192.168.1.101");
        // 초기화 시점에 생성되도록 변경 (readonly 제거)
        // 필드 선언 (static 생성 시 new 하지 않음)
        public static IDlnInterface Dln;
        public static IDlnInterface LightDln;

        public static DeviceConfig HardwareConfig = new DeviceConfig();
        public static string ConfigPath = RootDir + "HardwareConfig.xml";

        public static void Initialize()
        {
            // 1. 설정 로드
            if (File.Exists(ConfigPath))
            {
                HardwareConfig = DataIO.DeserializeXMLFileToObject<DeviceConfig>(ConfigPath);
            }
            else
            {
                DataIO.SerializeToXMLFile(HardwareConfig, ConfigPath);
            }

            // 2. 팩토리를 통해 하드웨어 타입에 맞는 인스턴스들을 한 번에 할당
            DeviceFactory.CreateDevices(HardwareConfig, out Dln, out LightDln);
        }

        public static AK73XX DrvIC = new AK73XX();

        public static Scanner Scanner = new Scanner(new SR_X300());
        public static CommunicationTypeSelector ScannerParamSelector= new CommunicationTypeSelector(ScannerDir);
    }
    public static class DataIO
    {
        public static string SerializeToXML<T>(this T toSerialize)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                using (var ms = new MemoryStream())
                {
                    using (var xw = XmlWriter.Create(ms, new XmlWriterSettings()
                    {
                        Encoding = new UTF8Encoding(false),
                        Indent = true,
                    }))
                    {
                        xmlSerializer.Serialize(xw, toSerialize, ns);
                        return Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
            catch
            { return string.Empty; }

        }
        public static bool SerializeToXMLFile<T>(this T toSerialize, string FileName) where T : class, new()
        {
            try
            {
                string dir = Path.GetDirectoryName(FileName);
                try { Directory.CreateDirectory(dir); }
                catch
                { return false; }
                string backFile = Path.ChangeExtension(FileName, ".bak");
                if (File.Exists(backFile))
                    File.Delete(backFile);
                try { File.WriteAllText(backFile, toSerialize.SerializeToXML<T>()); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                FileInfo info = new FileInfo(backFile);
                if (info.Length == 0)
                { return false; }

                if (File.Exists(FileName))
                    File.Delete(FileName);
                File.Move(backFile, FileName);
                return true;
            }
            catch { return false; }
        }
        public static object Deserialize<T>(this string toDeserialize) where T : class, new()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                using (StringReader txtReader = new StringReader(toDeserialize))
                {
                    return xmlSerializer.Deserialize(txtReader);
                }
            }
            catch
            { return default(T); }
        }
        public static T DeserializeXMLFileToObject<T>(string FileName) where T : class, new()
        {
            try
            {
                string xml = File.ReadAllText(FileName);
                return xml.Deserialize<T>() as T;
            }
            catch
            {
                return default(T);
            }
        }

        public static T GetEnumArttribute<T>(Enum val) where T : Attribute
        {
            Type enumT = val.GetType();
            string enumName = Enum.GetName(enumT, val);
            if (enumName != null)
            {
                FieldInfo finfo = enumT.GetField(enumName);
                if (finfo != null)
                {
                    T attri = (T)Attribute.GetCustomAttribute(finfo, typeof(T));
                    return attri;
                }
            }

            return null;
        }
        public static T GetCustomAttribute<T>(PropertyDescriptor p) where T : Attribute
        {
            T attri = (T)p.Attributes[typeof(T)];
            return attri;

        }
    }
}