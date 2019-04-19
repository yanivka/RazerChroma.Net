using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net
{
    public class RazerApiException : Exception
    {

        public readonly NativeRazerApi.RzResult ErrorCode;
        public readonly string ErrorText;
        public readonly string FunctionName;

        private RazerApiException(NativeRazerApi.RzResult errorCode, string functionName, string message,  Exception innerException) : base(message, innerException)
        {
            this.ErrorText = GetErrorText(errorCode);
            this.ErrorCode = errorCode;
            this.FunctionName = functionName;
        }

        public static RazerApiException Create(NativeRazerApi.RzResult errorCode, string functionName, string message = null, Exception innerException = null)
        {
            return new RazerApiException(errorCode, functionName, message ?? $"an error occured in the Razer Chroma api {{{errorCode}}}, {GetErrorText(errorCode)}", innerException);
        }
        public static string GetErrorText(NativeRazerApi.RzResult errorCode)
        {
            switch (errorCode)
            {
                case NativeRazerApi.RzResult.Invalid:
                    return "Invalid";
                case NativeRazerApi.RzResult.Success:
                    return "Success";
                case NativeRazerApi.RzResult.AccessDenied:
                    return "Access denied";
                case NativeRazerApi.RzResult.InvalidHandle:
                    return "Invalid handle";
                case NativeRazerApi.RzResult.NotSupported:
                    return "Not supported";
                case NativeRazerApi.RzResult.InvalidParameter:
                    return "Invalid parameter";
                case NativeRazerApi.RzResult.ServiceNotActive:
                    return "The service has not been started";
                case NativeRazerApi.RzResult.SingleInstanceApp:
                    return "Cannot start more than one instance of the specified program";
                case NativeRazerApi.RzResult.DeviceNotConnected:
                    return "Device not connected";
                case NativeRazerApi.RzResult.NotFound:
                    return "Element not found";
                case NativeRazerApi.RzResult.RequestAborted:
                    return "Request aborted";
                case NativeRazerApi.RzResult.AlreadyInitialized:
                    return "An attempt was made to perform an initialization operation when initialization has already been completed";
                case NativeRazerApi.RzResult.ResourceDisabled:
                    return "Resource not available or disabled";
                case NativeRazerApi.RzResult.DeviceNotAvailable:
                    return "Device not available or supported";
                case NativeRazerApi.RzResult.NotValidState:
                    return "The group or resource is not in the correct state to perform the requested operation";
                case NativeRazerApi.RzResult.NoMoreItems:
                    return "No more items";
                case NativeRazerApi.RzResult.Failed:
                    return "General failure";
                default:
                    return "UNKNOWN";
            }

        }
    }
}
