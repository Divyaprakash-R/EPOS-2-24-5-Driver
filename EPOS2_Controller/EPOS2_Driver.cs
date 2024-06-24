using EposCmd.Net.DeviceCmdSet.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPOS2_Controller
{
    public class EPOS2_Driver : IEPOS2_Driver
    {

        #region Importing Dll Methods from EPOSCmd

        [DllImport("EposCmd.dll")]
        private static extern IntPtr VCS_OpenDevice(string deviceName, string protocolStackName, string interfaceName, string portName, ref uint pErrorCode);

        [DllImport("EposCmd.dll")]
        private static extern int VCS_SetProtocolStackSettings(IntPtr keyHandle, uint baudrate, uint timeout, ref uint pErrorCode);

        [DllImport("EposCmd.dll")]
        private static extern int VCS_SetOperationMode(IntPtr keyHandle, ushort nodeId, sbyte operationMode, ref uint pErrorCode);

        [DllImport("EposCmd.dll")]
        private static extern int VCS_ActivateProfileVelocityMode(IntPtr KeyHandle, ushort NodeId, ref uint pErrorCode);

        [DllImport("EposCmd.dll")]
        private static extern int VCS_SetVelocityProfile(IntPtr KeyHandle, ushort NodeId, ushort ProfileAcceleration, ushort ProfileDeceleration, ref uint pErrorCode);

        [DllImport("EposCmd.dll")]
        private static extern int VCS_SetEnableState(IntPtr KeyHandle, ushort NodeId, ref uint pErrorCode);

        [DllImport("EposCmd.dll")]
        private static extern int VCS_MoveWithVelocity(IntPtr keyHandle, ushort Nodeid, int Target, ref uint pErrorCode);

        [DllImport("EposCmd.dll", EntryPoint = "VCS_HaltVelocityMovement")]
        private static extern int HaltVelocityMovement(IntPtr keyHandle, ushort nodeId, ref uint errorCode);

        [DllImport("EposCmd.dll", EntryPoint = "VCS_GetVelocityIs")]
        private static extern int VCS_GetVelocityIs(IntPtr KeyHandle, ushort NodeId, out long pVelocityIs, ref uint pErrorCode);

        [DllImport("EposCmd.dll")]
        private static extern int VCS_CloseDevice(IntPtr keyHandle, ref uint pErrorCode);

        [DllImport("EposCmd.dll", EntryPoint = "VCS_SetDisableState")]
        private static extern int VCS_SetDisableState(IntPtr KeyHandle, ushort NodeId, ref uint pErrorCode);

        #endregion

        #region Constant Values

        const string DEVICENAME = "EPOS2"; // Device name, as specified in the Maxon documentation
        const string PROTOCOLSTACKNAME = "MAXON_RS232"; // Protocol stack
        const string INTERFACENAME = "RS232"; // Interface name
        const sbyte OPERATIONMODE = 3; // Profile Velocity Mode (0x03)  

        private string _PortName; // Port name (adjust as needed)
        private uint _Baudrate = 9600; // Baudrate
        private uint _Timeout = 500; // Timeout in ms
        private ushort _NodeId; // Node ID             
        private IntPtr _KeyHandle;
        private uint _ErrorCode = 0;

        #endregion

        #region InterFace Methods

        public bool Connect(string Portname, uint BaudRate, uint Timeout, ushort NodeId)
        {
            _PortName = Portname;
            _Baudrate = BaudRate;
            _Timeout = Timeout;
            _NodeId = NodeId;

            _KeyHandle = OpenDevice(ref _ErrorCode);

            if (_KeyHandle == IntPtr.Zero)
            {
                throw new Exception($"Cannot make a connection. Check the 'node id , portname'. Error code: {_ErrorCode}");
            }

            if (SetProtocolStack(ref _ErrorCode) == 0)
            {
                CloseConnection(ref _ErrorCode);
                throw new Exception($"Failed to set protocol stack settings. Error code: {_ErrorCode}");
            }
            if (SetOperation(ref _ErrorCode) == 0)
            {
                CloseConnection(ref _ErrorCode);
                throw new Exception($"Failed to set operation mode settings. Error code: {_ErrorCode}");
            }
            if (ActivateOperationMode(ref _ErrorCode) == 0)
            {
                CloseConnection(ref _ErrorCode);
                throw new Exception($"Failed to ActivateOperationMode settings. Error code: {_ErrorCode}");
            }
            if (SetVelocityParameters(ref _ErrorCode) == 0)
            {
                CloseConnection(ref _ErrorCode);
                throw new Exception($"Failed to SetVelocityParameters settings. Error code: {_ErrorCode}");
            }

            return true;
        }

        public bool DisConnect()
        {
            if (CloseConnection(ref _ErrorCode) == 0)
            {
                throw new Exception($"Failed to Close the connection, Error Code = {_ErrorCode}");
            }
            return true;
        }

        public bool Enable()
        {
            int value = EnableDevice(ref _ErrorCode);
            if (value == 0)
            {
                throw new Exception($"failed to enable the device. ErrorCode = {_ErrorCode}");
            }
            return true;
        }

        public bool Disable()
        {
            if (DisableDevice(ref _ErrorCode) == 0)
            {
                throw new Exception($"Failed to Disable Device, Error Code = {_ErrorCode}");
            }
            return true;
        }

        public long GetActualVelocity()
        {
            long value = 0;
            if (GetVelocity(ref _ErrorCode, out value) == 0)
            {
                throw new Exception($"Failed to get actual velocity, Error Code = {_ErrorCode}");
            }
            return value;
        }

        public void Start(int RPM)
        {
            if (MoveWithVelocity(RPM, ref _ErrorCode) == 0)
            {
                throw new Exception($"Failed to Start the motor, Error Code = {_ErrorCode}");
            }
        }

        public void Stop()
        {
            if (HaltMovement(ref _ErrorCode) == 0)
            {
                throw new Exception($"Failed to Stop the motor, Error Code = {_ErrorCode}");
            }
        }

        #endregion

        #region Private Methods

        private IntPtr OpenDevice(ref uint errorCode)
        {
            IntPtr keyHandle = VCS_OpenDevice(DEVICENAME, PROTOCOLSTACKNAME, INTERFACENAME, _PortName, ref _ErrorCode);
            return keyHandle;
        }

        private int SetProtocolStack(ref uint errorCode)
        {
            int response = VCS_SetProtocolStackSettings(_KeyHandle, _Baudrate, _Timeout, ref _ErrorCode);
            return response;
        }

        private int SetOperation(ref uint errorcode)
        {
            int respons = VCS_SetOperationMode(_KeyHandle, _NodeId, OPERATIONMODE, ref errorcode);
            return respons;
        }

        private int ActivateOperationMode(ref uint errorcode)
        {
            int respons = VCS_ActivateProfileVelocityMode(_KeyHandle, _NodeId, ref errorcode);
            return respons;
        }

        public int SetVelocityParameters(ref uint errorcode, ushort AccelerationValue = 5000, ushort DecelerationValue = 5000)
        {
            int response = VCS_SetVelocityProfile(_KeyHandle, _NodeId, AccelerationValue, DecelerationValue, ref errorcode);
            return response;
        }

        private int EnableDevice(ref uint errorcode)
        {
            int response = VCS_SetEnableState(_KeyHandle, _NodeId, ref errorcode);
            return response;
        }

        private int MoveWithVelocity(int Target, ref uint errorcode)
        {
            int response = VCS_MoveWithVelocity(_KeyHandle, _NodeId, Target, ref errorcode);
            return response;
        }

        private int GetVelocity(ref uint errorcode, out long Velocity)
        {
            int response = VCS_GetVelocityIs(_KeyHandle, _NodeId, out Velocity, ref errorcode);
            return response;
        }

        private int HaltMovement(ref uint errorcode)
        {
            int response = HaltVelocityMovement(_KeyHandle, _NodeId, ref errorcode);
            return response;
        }

        private int DisableDevice(ref uint errorcode)
        {
            int response = VCS_SetDisableState(_KeyHandle, _NodeId, ref errorcode);
            return response;
        }

        private int CloseConnection(ref uint errorcode)
        {
            int response = VCS_CloseDevice(_KeyHandle, ref errorcode);
            return response;
        }

        #endregion
    }
}
