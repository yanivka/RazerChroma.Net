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

        #region NativeFunctionPointer
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
        #endregion

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_intptr(IntPtr windowHandle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_ref_deviceIntoType(Guid deviceId, out ChromaSDK.DeviceInfoType deviceInfo);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid(Guid effectId);

        #region CreateEffectDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_0_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.Blinking effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_1_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.Breathing effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_2_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.Custom effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_3_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.NoEffect effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_4_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.Reactive effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_5_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.SpectrumCycling effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_6_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.StarLight effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_7_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.Static effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegate_rzresult_guid_effectType_8_out_guid(Guid deviceId, ChromaSDK.Definitions.EffectType effectType, ref ChromaSDK.Effects.Wave effect, out Guid effectId);
        #endregion
        #region CreateKeyboardEffectDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateKeyboardEffect0(Keyboard.Definitions.EffectType effectType, ref Keyboard.Effects.Breathing effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]                                                                     
        private delegate RzResult _delegateCreateKeyboardEffect1(Keyboard.Definitions.EffectType effectType, ref Keyboard.Effects.Custom effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]                                                                     
        private delegate RzResult _delegateCreateKeyboardEffect2(Keyboard.Definitions.EffectType effectType, ref Keyboard.Effects.CustomKey effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]                                                                     
        private delegate RzResult _delegateCreateKeyboardEffect3(Keyboard.Definitions.EffectType effectType, ref Keyboard.Effects.Reactive effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]                                                                     
        private delegate RzResult _delegateCreateKeyboardEffect4(Keyboard.Definitions.EffectType effectType, ref Keyboard.Effects.StarLight effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]                                                                     
        private delegate RzResult _delegateCreateKeyboardEffect5(Keyboard.Definitions.EffectType effectType, ref Keyboard.Effects.Static effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]                                                                     
        private delegate RzResult _delegateCreateKeyboardEffect6(Keyboard.Definitions.EffectType effectType, ref Keyboard.Effects.Wave effect, out Guid effectId);
        #endregion
        #region CreateMouseEffectDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect0(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.Blinking effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect1(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.Breathing effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect2(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.Custom effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect3(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.Custom2 effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect4(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.NoEffect effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect5(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.Reactive effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect6(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.Spectrumcycling effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect7(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.Static effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMouseEffect8(Mouse.Definitions.EffectType effectType, ref Mouse.Effects.Wave effect, out Guid effectId);
        #endregion
        #region CreateMousePadEffectDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMousePadEffect0(MousePad.Definitions.EffectType effectType, ref MousePad.Effects.Breathing effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMousePadEffect1(MousePad.Definitions.EffectType effectType, ref MousePad.Effects.Custom effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMousePadEffect2(MousePad.Definitions.EffectType effectType, ref MousePad.Effects.Static effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateMousePadEffect3(MousePad.Definitions.EffectType effectType, ref MousePad.Effects.Wave effect, out Guid effectId);
        #endregion
        #region CreateKeyPadEffectDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateKeyPadEffect0(KeyPad.Definitions.EffectType effectType, ref KeyPad.Effects.Breathing effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateKeyPadEffect1(KeyPad.Definitions.EffectType effectType, ref KeyPad.Effects.Custom effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateKeyPadEffect2(KeyPad.Definitions.EffectType effectType, ref KeyPad.Effects.Reactive effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateKeyPadEffect3(KeyPad.Definitions.EffectType effectType, ref KeyPad.Effects.Static effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateKeyPadEffect4(KeyPad.Definitions.EffectType effectType, ref KeyPad.Effects.Wave effect, out Guid effectId);
        #endregion
        #region CreateChromaLinkEffectDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateChromaLinkEffect0(ChromaLink.Definitions.EffectType effectType, ref ChromaLink.Effects.Custom effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateChromaLinkEffect1(ChromaLink.Definitions.EffectType effectType, ref ChromaLink.Effects.Static effect, out Guid effectId);
        #endregion
        #region CreateHeadSetEffectDelegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateHaedsetEffect0(HeadSet.Definitions.EffectType effectType, ref HeadSet.Effects.Breathing effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateHaedsetEffect1(HeadSet.Definitions.EffectType effectType, ref HeadSet.Effects.Custom effect, out Guid effectId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate RzResult _delegateCreateHaedsetEffect2(HeadSet.Definitions.EffectType effectType, ref HeadSet.Effects.Static effect, out Guid effectId);
        #endregion

        private _delegate_rzresult _init;
        private _delegate_rzresult _unInit;
        private _delegate_rzresult _unregisterEventNotification;
        private _delegate_rzresult_intptr _registerEventNotification;
        private _delegate_rzresult_guid_ref_deviceIntoType _quertyDevice;
        private _delegate_rzresult_guid _deleteEffect;
        private _delegate_rzresult_guid _setEffect;

        #region CraeteEffectFunctions
        private _delegate_rzresult_guid_effectType_0_out_guid _createEffect0;
        private _delegate_rzresult_guid_effectType_1_out_guid _createEffect1;
        private _delegate_rzresult_guid_effectType_2_out_guid _createEffect2;
        private _delegate_rzresult_guid_effectType_3_out_guid _createEffect3;
        private _delegate_rzresult_guid_effectType_4_out_guid _createEffect4;
        private _delegate_rzresult_guid_effectType_5_out_guid _createEffect5;
        private _delegate_rzresult_guid_effectType_6_out_guid _createEffect6;
        private _delegate_rzresult_guid_effectType_7_out_guid _createEffect7;
        private _delegate_rzresult_guid_effectType_8_out_guid _createEffect8;
        #endregion
        #region CraeteKeyboardEffectFunctions
        private _delegateCreateKeyboardEffect0 _createKeyboardEffect0;
        private _delegateCreateKeyboardEffect1 _createKeyboardEffect1;
        private _delegateCreateKeyboardEffect2 _createKeyboardEffect2;
        private _delegateCreateKeyboardEffect3 _createKeyboardEffect3;
        private _delegateCreateKeyboardEffect4 _createKeyboardEffect4;
        private _delegateCreateKeyboardEffect5 _createKeyboardEffect5;
        private _delegateCreateKeyboardEffect6 _createKeyboardEffect6;
        #endregion
        #region CraeteMouseEffectFunctions
        private _delegateCreateMouseEffect0 _createMouseEffect0;
        private _delegateCreateMouseEffect1 _createMouseEffect1;
        private _delegateCreateMouseEffect2 _createMouseEffect2;
        private _delegateCreateMouseEffect3 _createMouseEffect3;
        private _delegateCreateMouseEffect4 _createMouseEffect4;
        private _delegateCreateMouseEffect5 _createMouseEffect5;
        private _delegateCreateMouseEffect6 _createMouseEffect6;
        private _delegateCreateMouseEffect7 _createMouseEffect7;
        private _delegateCreateMouseEffect8 _createMouseEffect8;
        #endregion
        #region CraeteMousePadEffectFunctions
        private _delegateCreateMousePadEffect0 _createMousePadEffect0;
        private _delegateCreateMousePadEffect1 _createMousePadEffect1;
        private _delegateCreateMousePadEffect2 _createMousePadEffect2;
        private _delegateCreateMousePadEffect3 _createMousePadEffect3;
        #endregion
        #region CraeteKeyPadEffectFunctions
        private _delegateCreateKeyPadEffect0 _createKeyPadEffect0;
        private _delegateCreateKeyPadEffect1 _createKeyPadEffect1;
        private _delegateCreateKeyPadEffect2 _createKeyPadEffect2;
        private _delegateCreateKeyPadEffect3 _createKeyPadEffect3;
        private _delegateCreateKeyPadEffect4 _createKeyPadEffect4;
        #endregion
        #region CraeteChromaLinkEffectFunctions
        private _delegateCreateChromaLinkEffect0 _createChromaLinkEffect0;
        private _delegateCreateChromaLinkEffect1 _createChromaLinkEffect1;
        #endregion
        #region CraeteHeadSetEffectFunctions
        private _delegateCreateHaedsetEffect0 _createHeadSetEffect0;
        private _delegateCreateHaedsetEffect1 _createHeadSetEffect1;
        private _delegateCreateHaedsetEffect2 _createHeadSetEffect2;
        #endregion
        
        public enum RzResult : uint
        {
            Invalid = 0xffffffff,
            Success = 0,
            AccessDenied = 5,
            InvalidHandle = 6,
            NotSupported = 50,
            InvalidParameter = 87,
            ServiceNotActive = 1062,
            SingleInstanceApp = 1152,
            DeviceNotConnected = 1167,
            NotFound = 1168,
            RequestAborted = 1235,
            AlreadyInitialized = 1247,
            ResourceDisabled = 4309,
            DeviceNotAvailable = 4319,
            NotValidState = 5023,
            NoMoreItems = 259,
            Failed = 2147500037
        }
        public NativeRazerApi()
        {
            if (Environment.Is64BitProcess)
            {
                _chromaSdkDll = NativeWin32.LoadLibrary("RzChromaSDK64.dll");
            }
            else
            {
                _chromaSdkDll = NativeWin32.LoadLibrary("RzChromaSDK.dll");
            }
            this.LoadNativeFunctions();
            this.LoadDelegateFunctions();
            this.Init();
        }
        private void LoadDelegateFunctions()
        {
            this._init = (_delegate_rzresult)Marshal.GetDelegateForFunctionPointer(_functionPointerInit, typeof(_delegate_rzresult));
            this._unInit = (_delegate_rzresult)Marshal.GetDelegateForFunctionPointer(_functionPointerUnInit, typeof(_delegate_rzresult));
            this._registerEventNotification = (_delegate_rzresult_intptr)Marshal.GetDelegateForFunctionPointer(_functionPointerRegisterEventNotification, typeof(_delegate_rzresult_intptr));
            this._unregisterEventNotification = (_delegate_rzresult)Marshal.GetDelegateForFunctionPointer(_functionPointerUnRegisterEventNotification, typeof(_delegate_rzresult));
            this._quertyDevice = (_delegate_rzresult_guid_ref_deviceIntoType)Marshal.GetDelegateForFunctionPointer(_functionPointerQueryDevice, typeof(_delegate_rzresult_guid_ref_deviceIntoType));
            this._setEffect = (_delegate_rzresult_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerSetEffect, typeof(_delegate_rzresult_guid));
            this._deleteEffect = (_delegate_rzresult_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerDeleteEffect, typeof(_delegate_rzresult_guid));

            this._createEffect0 = (_delegate_rzresult_guid_effectType_0_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_0_out_guid));
            this._createEffect1 = (_delegate_rzresult_guid_effectType_1_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_1_out_guid));
            this._createEffect2 = (_delegate_rzresult_guid_effectType_2_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_2_out_guid));
            this._createEffect3 = (_delegate_rzresult_guid_effectType_3_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_3_out_guid));
            this._createEffect4 = (_delegate_rzresult_guid_effectType_4_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_4_out_guid));
            this._createEffect5 = (_delegate_rzresult_guid_effectType_5_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_5_out_guid));
            this._createEffect6 = (_delegate_rzresult_guid_effectType_6_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_6_out_guid));
            this._createEffect7 = (_delegate_rzresult_guid_effectType_7_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_7_out_guid));
            this._createEffect8 = (_delegate_rzresult_guid_effectType_8_out_guid)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateEffect, typeof(_delegate_rzresult_guid_effectType_8_out_guid));

            this._createKeyboardEffect0 = (_delegateCreateKeyboardEffect0)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeyboardEffect, typeof(_delegateCreateKeyboardEffect0));
            this._createKeyboardEffect1 = (_delegateCreateKeyboardEffect1)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeyboardEffect, typeof(_delegateCreateKeyboardEffect1));
            this._createKeyboardEffect2 = (_delegateCreateKeyboardEffect2)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeyboardEffect, typeof(_delegateCreateKeyboardEffect2));
            this._createKeyboardEffect3 = (_delegateCreateKeyboardEffect3)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeyboardEffect, typeof(_delegateCreateKeyboardEffect3));
            this._createKeyboardEffect4 = (_delegateCreateKeyboardEffect4)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeyboardEffect, typeof(_delegateCreateKeyboardEffect4));
            this._createKeyboardEffect5 = (_delegateCreateKeyboardEffect5)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeyboardEffect, typeof(_delegateCreateKeyboardEffect5));
            this._createKeyboardEffect6 = (_delegateCreateKeyboardEffect6)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeyboardEffect, typeof(_delegateCreateKeyboardEffect6));

            this._createMouseEffect0 = (_delegateCreateMouseEffect0)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect0));
            this._createMouseEffect1 = (_delegateCreateMouseEffect1)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect1));
            this._createMouseEffect2 = (_delegateCreateMouseEffect2)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect2));
            this._createMouseEffect3 = (_delegateCreateMouseEffect3)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect3));
            this._createMouseEffect4 = (_delegateCreateMouseEffect4)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect4));
            this._createMouseEffect5 = (_delegateCreateMouseEffect5)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect5));
            this._createMouseEffect6 = (_delegateCreateMouseEffect6)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect6));
            this._createMouseEffect7 = (_delegateCreateMouseEffect7)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect7));
            this._createMouseEffect8 = (_delegateCreateMouseEffect8)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMouseEffect, typeof(_delegateCreateMouseEffect8));

            this._createMousePadEffect0 = (_delegateCreateMousePadEffect0)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMousepadEffect, typeof(_delegateCreateMousePadEffect0));
            this._createMousePadEffect1 = (_delegateCreateMousePadEffect1)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMousepadEffect, typeof(_delegateCreateMousePadEffect1));
            this._createMousePadEffect2 = (_delegateCreateMousePadEffect2)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMousepadEffect, typeof(_delegateCreateMousePadEffect2));
            this._createMousePadEffect3 = (_delegateCreateMousePadEffect3)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateMousepadEffect, typeof(_delegateCreateMousePadEffect3));

            this._createKeyPadEffect0 = (_delegateCreateKeyPadEffect0)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeypadEffect, typeof(_delegateCreateKeyPadEffect0));
            this._createKeyPadEffect1 = (_delegateCreateKeyPadEffect1)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeypadEffect, typeof(_delegateCreateKeyPadEffect1));
            this._createKeyPadEffect2 = (_delegateCreateKeyPadEffect2)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeypadEffect, typeof(_delegateCreateKeyPadEffect2));
            this._createKeyPadEffect3 = (_delegateCreateKeyPadEffect3)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeypadEffect, typeof(_delegateCreateKeyPadEffect3));
            this._createKeyPadEffect4 = (_delegateCreateKeyPadEffect4)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateKeypadEffect, typeof(_delegateCreateKeyPadEffect4));

            this._createChromaLinkEffect0 = (_delegateCreateChromaLinkEffect0)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateChromaLinkEffect, typeof(_delegateCreateChromaLinkEffect0));
            this._createChromaLinkEffect1 = (_delegateCreateChromaLinkEffect1)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateChromaLinkEffect, typeof(_delegateCreateChromaLinkEffect1));

            this._createHeadSetEffect0 = (_delegateCreateHaedsetEffect0)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateHeadsetEffect, typeof(_delegateCreateHaedsetEffect0));
            this._createHeadSetEffect1 = (_delegateCreateHaedsetEffect1)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateHeadsetEffect, typeof(_delegateCreateHaedsetEffect1));
            this._createHeadSetEffect2 = (_delegateCreateHaedsetEffect2)Marshal.GetDelegateForFunctionPointer(_functionPointerCreateHeadsetEffect, typeof(_delegateCreateHaedsetEffect2));

        }
        private void LoadNativeFunctions()
        {
            _functionPointerInit = NativeWin32.GetProcAddress(this._chromaSdkDll, "Init");
            _functionPointerUnInit = NativeWin32.GetProcAddress(this._chromaSdkDll, "UnInit");
            _functionPointerRegisterEventNotification = NativeWin32.GetProcAddress(this._chromaSdkDll, "RegisterEventNotification");
            _functionPointerUnRegisterEventNotification = NativeWin32.GetProcAddress(this._chromaSdkDll, "UnregisterEventNotification");
            _functionPointerQueryDevice = NativeWin32.GetProcAddress(this._chromaSdkDll, "QueryDevice");
            _functionPointerSetEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "SetEffect");
            _functionPointerDeleteEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "DeleteEffect");
            _functionPointerCreateEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "CreateEffect");
            _functionPointerCreateKeyboardEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "CreateKeyboardEffect");
            _functionPointerCreateMouseEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "CreateMouseEffect");
            _functionPointerCreateMousepadEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "CreateMousepadEffect");
            _functionPointerCreateKeypadEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "CreateKeypadEffect");
            _functionPointerCreateHeadsetEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "CreateHeadsetEffect");
            _functionPointerCreateChromaLinkEffect = NativeWin32.GetProcAddress(this._chromaSdkDll, "CreateChromaLinkEffect");
        }
        internal void SetEffect(Guid EffectId)
        {
            RzResult result = this._setEffect(EffectId);
            if (result != RzResult.Success) throw RazerApiException.Create(result, "SetEffect");
        }
        internal void DeleteEffect(Guid EffectId)
        {
            RzResult result = this._deleteEffect(EffectId);
            if (result != RzResult.Success) throw RazerApiException.Create(result, "DeleteEffect");
        }
        public Guid[] GetAllSupportedDevices()
        {
            return new Guid[]
            {
                      ChromaSDK.Definitions.BlackWidowChroma,
                      ChromaSDK.Definitions.BlackWidowChromaTe ,
                      ChromaSDK.Definitions.DeathStalkerChroma,
                      ChromaSDK.Definitions.OverwatchKeyboard ,
                      ChromaSDK.Definitions.BlackwidowXChroma ,
                      ChromaSDK.Definitions.BlackwidowXTechroma ,
                      ChromaSDK.Definitions.Ornatachroma ,
                      ChromaSDK.Definitions.BladeStealth ,
                      ChromaSDK.Definitions.Blade,
                      ChromaSDK.Definitions.BladePro
            };
        }
        public ChromaSDK.DeviceInfoType QueryDevice(Guid DeviceId)
        {
            RzResult result = this._quertyDevice(DeviceId, out ChromaSDK.DeviceInfoType returnValue);
            if (result != RzResult.Success) throw RazerApiException.Create(result, "QueryDevice");
            return returnValue;
        }
        public ChromaSDK.DeviceInfoType TryQueryDevice(Guid DeviceId, out bool Success)
        {
            RzResult result = this._quertyDevice(DeviceId, out ChromaSDK.DeviceInfoType returnValue);
            if (result != RzResult.Success)
            {
                Success = false;
                return new ChromaSDK.DeviceInfoType();
            }
            else
            {
                Success = true;
                return returnValue;
            }
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
            if(!IsDisposed)
            {
                IsDisposed = true;
                RzResult result = this._unInit();
                if (result != RzResult.Success) throw RazerApiException.Create(result, "Init");
            }          
        }
        bool IsDisposed = false;
        public void Dispose()
        {
            this.UnInit();
        }


        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.Blinking effect) { RzResult result = this._createEffect0(deviceId, ChromaSDK.Definitions.EffectType.Breathing, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.Breathing effect) { RzResult result = this._createEffect1(deviceId, ChromaSDK.Definitions.EffectType.Breathing, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.Custom effect) { RzResult result = this._createEffect2(deviceId, ChromaSDK.Definitions.EffectType.Custom, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.NoEffect effect) { RzResult result = this._createEffect3(deviceId, ChromaSDK.Definitions.EffectType.None, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.Reactive effect) { RzResult result = this._createEffect4(deviceId, ChromaSDK.Definitions.EffectType.Reactive, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.SpectrumCycling effect) { RzResult result = this._createEffect5(deviceId, ChromaSDK.Definitions.EffectType.SpectrumCycling, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.StarLight effect) { RzResult result = this._createEffect6(deviceId, ChromaSDK.Definitions.EffectType.Invaild, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.Static effect) { RzResult result = this._createEffect7(deviceId, ChromaSDK.Definitions.EffectType.Static, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateEffect(Guid deviceId, ChromaSDK.Effects.Wave effect) { RzResult result = this._createEffect8(deviceId, ChromaSDK.Definitions.EffectType.Wave, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateEffect"); }

        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateKeyboardEffect(Keyboard.Effects.Breathing effect){RzResult result = this._createKeyboardEffect0(Keyboard.Definitions.EffectType.Static, ref effect, out Guid effectId);return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeyboardEffect");}
        public Effect CreateKeyboardEffect(Keyboard.Effects.Custom effect) { RzResult result = this._createKeyboardEffect1(Keyboard.Definitions.EffectType.Custom, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeyboardEffect"); }
        public Effect CreateKeyboardEffect(Keyboard.Effects.CustomKey effect) { RzResult result = this._createKeyboardEffect2(Keyboard.Definitions.EffectType.Custom_key, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeyboardEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateKeyboardEffect(Keyboard.Effects.Reactive effect) { RzResult result = this._createKeyboardEffect3(Keyboard.Definitions.EffectType.Reactive, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeyboardEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateKeyboardEffect(Keyboard.Effects.StarLight effect) { RzResult result = this._createKeyboardEffect4(Keyboard.Definitions.EffectType.Invalid, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeyboardEffect"); }
        public Effect CreateKeyboardEffect(Keyboard.Effects.Static effect) { RzResult result = this._createKeyboardEffect5(Keyboard.Definitions.EffectType.Static, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeyboardEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateKeyboardEffect(Keyboard.Effects.Wave effect) { RzResult result = this._createKeyboardEffect6(Keyboard.Definitions.EffectType.Wave, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeyboardEffect"); }

        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateMouseEffect(Mouse.Effects.Blinking effect) { RzResult result = this._createMouseEffect0(Mouse.Definitions.EffectType.Blinking, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateMouseEffect(Mouse.Effects.Breathing effect) { RzResult result = this._createMouseEffect1(Mouse.Definitions.EffectType.Breathing, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateMouseEffect(Mouse.Effects.Custom effect) { RzResult result = this._createMouseEffect2(Mouse.Definitions.EffectType.Custom, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }
        public Effect CreateMouseEffect(Mouse.Effects.Custom2 effect) { RzResult result = this._createMouseEffect3(Mouse.Definitions.EffectType.Custom2, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateMouseEffect(Mouse.Effects.NoEffect effect) { RzResult result = this._createMouseEffect4(Mouse.Definitions.EffectType.None, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateMouseEffect(Mouse.Effects.Reactive effect) { RzResult result = this._createMouseEffect5(Mouse.Definitions.EffectType.Reactive, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateMouseEffect(Mouse.Effects.Spectrumcycling effect) { RzResult result = this._createMouseEffect6(Mouse.Definitions.EffectType.Spectrumcycling, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }
        public Effect CreateMouseEffect(Mouse.Effects.Static effect) { RzResult result = this._createMouseEffect7(Mouse.Definitions.EffectType.Static, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateMouseEffect(Mouse.Effects.Wave effect) { RzResult result = this._createMouseEffect8( Mouse.Definitions.EffectType.Wave, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMouseEffect"); }

        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateMousepadEffect(MousePad.Effects.Breathing effect) { RzResult result = this._createMousePadEffect0(MousePad.Definitions.EffectType.Breathing, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMousepadEffect"); }
        public Effect CreateMousepadEffect(MousePad.Effects.Custom effect) { RzResult result = this._createMousePadEffect1(MousePad.Definitions.EffectType.Custom, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMousepadEffect"); }
        public Effect CreateMousepadEffect(MousePad.Effects.Static effect) { RzResult result = this._createMousePadEffect2(MousePad.Definitions.EffectType.Static, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMousepadEffect"); }
        public Effect CreateMousepadEffect(MousePad.Effects.Wave effect) { RzResult result = this._createMousePadEffect3(MousePad.Definitions.EffectType.Wave, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateMousepadEffect"); }

        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateKeypadEffect(KeyPad.Effects.Breathing effect) { RzResult result = this._createKeyPadEffect0(KeyPad.Definitions.EffectType.Breathing, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeypadEffect"); }
        public Effect CreateKeypadEffect(KeyPad.Effects.Custom effect) { RzResult result = this._createKeyPadEffect1(KeyPad.Definitions.EffectType.Custom, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeypadEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateKeypadEffect(KeyPad.Effects.Reactive effect) { RzResult result = this._createKeyPadEffect2(KeyPad.Definitions.EffectType.Reactive, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeypadEffect"); }
        public Effect CreateKeypadEffect(KeyPad.Effects.Static effect) { RzResult result = this._createKeyPadEffect3(KeyPad.Definitions.EffectType.Static, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeypadEffect"); }
        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateKeypadEffect(KeyPad.Effects.Wave effect) { RzResult result = this._createKeyPadEffect4(KeyPad.Definitions.EffectType.Wave, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateKeypadEffect"); }

        public Effect CreateChromaLinkEffect(ChromaLink.Effects.Custom effect) { RzResult result = this._createChromaLinkEffect0(ChromaLink.Definitions.EffectType.CHROMA_CUSTOM, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateChromaLinkEffect"); }
        public Effect CreateChromaLinkEffect(ChromaLink.Effects.Static effect) { RzResult result = this._createChromaLinkEffect1(ChromaLink.Definitions.EffectType.CHROMA_STATIC, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateChromaLinkEffect"); }

        [Obsolete("This effect is no longer support by Razer Chroma SDK 2.13", true)]
        public Effect CreateHeadSetEffect(HeadSet.Effects.Breathing effect) { RzResult result = this._createHeadSetEffect0(HeadSet.Definitions.EffectType.Breathing, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateHeadSetEffect"); }
        public Effect CreateHeadSetEffect(HeadSet.Effects.Custom effect) { RzResult result = this._createHeadSetEffect1(HeadSet.Definitions.EffectType.Custom, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateHeadSetEffect"); }
        public Effect CreateHeadSetEffect(HeadSet.Effects.Static effect) { RzResult result = this._createHeadSetEffect2(HeadSet.Definitions.EffectType.Static, ref effect, out Guid effectId); return (result == RzResult.Success) ? new Effect(this, effectId) : throw RazerApiException.Create(result, "CreateHeadSetEffect"); }

    }
}
