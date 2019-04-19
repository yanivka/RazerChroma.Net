using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net
{
    public class NativeRazerApi : IDisposable
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

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_intptr(IntPtr windowHandle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_ref_deviceIntoType(Guid deviceId, out ChromaSDK.DeviceInfoType deviceInfo);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid(Guid effectId);

        private _delegate_rzresult _init;
        private _delegate_rzresult _unInit;
        private _delegate_rzresult _unregisterEventNotification;
        private _delegate_rzresult_intptr _registerEventNotification;
        private _delegate_rzresult_guid_ref_deviceIntoType _quertyDevice;
        private _delegate_rzresult_guid _deleteEffect;
        private _delegate_rzresult_guid _setEffect;

        public enum RzResult : uint
        {
            Invalid = 0xffffffff,
            Success=   0,
            AccessDenied  = 5,
            InvalidHandle  = 6,
            NotSupported  = 50,
            InvalidParameter =  87,
            ServiceNotActive =  1062,
            SingleInstanceApp =  1152,
            DeviceNotConnected =  1167,
            NotFound  = 1168,
            RequestAborted =  1235,
            AlreadyInitialized  = 1247,
            ResourceDisabled =  4309,
            DeviceNotAvailable =  4319,
            NotValidState  = 5023,
            NoMoreItems =  259,
            Failed  = 2147500037
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
            this._init = (_delegate_rzresult)Marshal.GetDelegateForFunctionPointer(_functionPointerInit, typeof(_delegate_rzresult));
            _functionPointerUnInit = NativeWin32.GetProcAddress(this._chromaSdkDll, "UnInit");
            this._unInit = (_delegate_rzresult)Marshal.GetDelegateForFunctionPointer(_functionPointerUnInit, typeof(_delegate_rzresult));
            _functionPointerRegisterEventNotification = NativeWin32.GetProcAddress(this._chromaSdkDll, "RegisterEventNotification");
            this._registerEventNotification = (_delegate_rzresult_intptr)Marshal.GetDelegateForFunctionPointer(_functionPointerRegisterEventNotification, typeof(_delegate_rzresult_intptr));
            _functionPointerUnRegisterEventNotification = NativeWin32.GetProcAddress(this._chromaSdkDll, "UnregisterEventNotification");
            this._unregisterEventNotification = (_delegate_rzresult)Marshal.GetDelegateForFunctionPointer(_functionPointerUnRegisterEventNotification, typeof(_delegate_rzresult));
            _functionPointerQueryDevice = NativeWin32.GetProcAddress(this._chromaSdkDll, "QueryDevice");
            this._quertyDevice = (_delegate_rzresult_guid_ref_deviceIntoType)Marshal.GetDelegateForFunctionPointer(_functionPointerQueryDevice, typeof(_delegate_rzresult_guid_ref_deviceIntoType));

            _functionPointerSetEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "Init");
            this._setEffect = (_delegate_rzresult_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerSetEffect, typeof(_delegate_rzresult_guid));
            _functionPointerDeleteEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "UnInit");
            this._deleteEffect = (_delegate_rzresult_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerDeleteEffect, typeof(_delegate_rzresult_guid));


            this.Init();
            Console.WriteLine(this.QueryDevice(ChromaSDK.Definitions.BlackWidowChroma).Connected);
        }

        public void SetEffect(Guid EffectId)
        {
            RzResult result = this._setEffect(EffectId);
            if (result != RzResult.Success) throw RazerApiException.Create(result, "SetEffect");
        }
        public void DeleteEffect(Guid EffectId)
        {
            RzResult result = this._deleteEffect(EffectId);
            if (result != RzResult.Success) throw RazerApiException.Create(result, "DeleteEffect");
        }
        public ChromaSDK.DeviceInfoType QueryDevice(Guid DeviceId)
        {
            RzResult result = this._quertyDevice(DeviceId, out ChromaSDK.DeviceInfoType returnValue);
            if (result != RzResult.Success) throw RazerApiException.Create(result, "QueryDevice");
            return returnValue;
        }
        public void RegisterEventNotification(IntPtr windowHandle)
        {
            RzResult result = this._registerEventNotification(windowHandle);
            if (result != RzResult.Success) throw RazerApiException.Create(result, "RegisterEventNotification");
        }
        public void UnregisterEventNotification()
        {
            RzResult result = this._unregisterEventNotification();
            if (result != RzResult.Success) throw RazerApiException.Create(result, "UnregisterEventNotification");
        }
        private void Init()
        {
            RzResult result = this._init();
            if (result != RzResult.Success) throw RazerApiException.Create(result, "Init");            
        }
        private void UnInit()
        {
            IsDisposed = true;
            RzResult result = this._unInit();
            if (result != RzResult.Success) throw RazerApiException.Create(result, "Init");
        }

        bool IsDisposed = false;
        public void Dispose()
        {
            this.UnInit();
        }
    }
}
