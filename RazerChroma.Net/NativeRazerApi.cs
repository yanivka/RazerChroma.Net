using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net
{
    public class NativeRazerApi
    {

        private IntPtr _chromaSdkDll;

        private IntPtr _functionPointerInit;
        private IntPtr _functionPointerUnInit;
        private IntPtr _functionPointerCreateEffect;
        private IntPtr _functionPointerCreateKeyboardEffect;
        private IntPtr _functionPointerCreateMouseEffect;
        private IntPtr _functionPointerCreateMousepadEffect;
        private IntPtr _functionPointerCreateKeypadEffect;
        private IntPtr _functionPointerCreateHeadsetEffect;
        private IntPtr _functionPointerCreateChromaLinkEffect;
        private IntPtr _functionPointerSetEffect;
        private IntPtr _functionPointerDeleteEffect;
        private IntPtr _functionPointerRegisterEventNotification;
        private IntPtr _functionPointerUnRegisterEventNotification;
        private IntPtr _functionPointerQueryDevice;

        private Func<RzResult> _init;
        private Func<RzResult> _unInit;


        public enum RzResult : long
        {
            RZRESULT_INVALID = -1,
            RZRESULT_SUCCESS=   0,
            RZRESULT_ACCESS_DENIED  = 5,
            RZRESULT_INVALID_HANDLE  = 6,
            RZRESULT_NOT_SUPPORTED  = 50,
            RZRESULT_INVALID_PARAMETER =  87,
            RZRESULT_SERVICE_NOT_ACTIVE =  1062,
            RZRESULT_SINGLE_INSTANCE_APP =  1152,
            RZRESULT_DEVICE_NOT_CONNECTED =  1167,
            RZRESULT_NOT_FOUND  = 1168,
            RZRESULT_REQUEST_ABORTED =  1235,
            RZRESULT_ALREADY_INITIALIZED  = 1247,
            RZRESULT_RESOURCE_DISABLED =  4309,
            RZRESULT_DEVICE_NOT_AVAILABLE =  4319,
            RZRESULT_NOT_VALID_STATE  = 5023,
            RZRESULT_NO_MORE_ITEMS =  259,
            RZRESULT_FAILED  = 2147500037
    }

        public NativeRazerApi()
        {
            if(Environment.Is64BitProcess)
            {
                _chromaSdkDll = NativeWin32.LoadLibrary("RzChromaSDK64.dll");
            }
            else
            {
                _chromaSdkDll = NativeWin32.LoadLibrary("RzChromaSDK.dll");
            }
            this.LoadFunctions();
        }
        private void LoadFunctions()
        {
            _functionPointerInit = NativeWin32.GetProcAddress(this._chromaSdkDll, "Init");

        }


        public void Init()
        {
            
        }
        public void UnInit()
        {

        }

    }
}
