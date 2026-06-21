using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.DriverIc.IC.CML
{
    public enum CmlStatus
    {
        CML_OK = 0x0000, /** Success */
        CML_ERR = 0x0001, /** Generic failure */
        CML_I2C_ERR = 0x0002, /** I2C error */
        CML_TIMEOUT = 0x0003, /** Operation timeout */
        CML_OUT_OF_RANGE = 0x0004, /** Supplied value is out of range */
        CML_FILE_NOT_FOUND = 0x0005, /** No file found */
        CML_EMPTY_FILE = 0x0006, /** Supplied file has no contents */
        CML_BUFFER_TOO_SMALL = 0x0007, /** Buffer too small for requested data */
        CML_INVALID_DEVICE_ADDR = 0x0008, /** Supplied device address is not valid */
        CML_CHECKSUM_MISMATCH = 0x0009, /** Checksum does not match expectation */
        CML_PLL_ERROR = 0x000A, /** PLL error */
        CML_INVALID_ACCESS = 0x000B, /** Unsupported I2C access type */
        CML_SYS_NOT_READY = 0x000C, /** System is not ready */
        CML_SYS_STATUS_CHECKSUM_FAIL = 0x000D, /** System hardware checksum value is incorrect */
        CML_OUT_OF_MEMORY = 0x000E, /** API failed to allocate necessary memory for the operation */
        CML_API_NOT_INITIALISED = 0x000F, /** API has not been initialised */
        CML_REGMAP_NOT_INITIALISED = 0x0010, /** Module register map has not been initialised */
        CML_GYRO_UNKNOWN_TYPE = 0x0011, /** Gyro type is unknown */
        CML_CALIBRATE_GYRO_ERR = 0x0012, /** Gyro offset calibration failed due to inaccuracy */
        CML_BAD_STATE = 0x0013, /** Firmware is in the wrong operation/actuator state prior to an operation */
        CML_NULL_PTR_ERROR = 0x0014, /** Null object found */
        CML_NOT_SUPPORTED = 0x0015, /** Unsupported option specified */
        CML_FW_VERIFICATION_FAIL = 0x0016, /** Firmware verification check fail */
        CML_FW_NOT_READY = 0x0017, /** Firmware not ready to accept commands */
    };
}
