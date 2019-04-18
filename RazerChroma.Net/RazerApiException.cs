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

        private RazerApiException(NativeRazerApi.RzResult errorCode, string message,  Exception innerException) : base(message, innerException)
        {
            this.ErrorText = GetErrorText(errorCode);
            this.ErrorCode = errorCode;      
        }

        public static RazerApiException Create(NativeRazerApi.RzResult errorCode, string message = null, Exception innerException = null)
        {
            return new RazerApiException(errorCode, message ?? $"an error occured in the Razer Chroma api {{{errorCode}}}, {GetErrorText(errorCode)}", innerException);
        }
        public static string GetErrorText(NativeRazerApi.RzResult errorCode)
        {
            switch (errorCode)
            {
                case NativeRazerApi.RzResult.RZRESULT_INVALID:
                    return "Invalid";
                case NativeRazerApi.RzResult.RZRESULT_SUCCESS:
                    return "Success";
                case NativeRazerApi.RzResult.RZRESULT_ACCESS_DENIED:
                    return "Access denied";
                case NativeRazerApi.RzResult.RZRESULT_INVALID_HANDLE:
                    return "Invalid handle";
                case NativeRazerApi.RzResult.RZRESULT_NOT_SUPPORTED:
                    return "Not supported";
                case NativeRazerApi.RzResult.RZRESULT_INVALID_PARAMETER:
                    return "Invalid parameter";
                case NativeRazerApi.RzResult.RZRESULT_SERVICE_NOT_ACTIVE:
                    return "The service has not been started";
                case NativeRazerApi.RzResult.RZRESULT_SINGLE_INSTANCE_APP:
                    return "Cannot start more than one instance of the specified program";
                case NativeRazerApi.RzResult.RZRESULT_DEVICE_NOT_CONNECTED:
                    return "Device not connected";
                case NativeRazerApi.RzResult.RZRESULT_NOT_FOUND:
                    return "Element not found";
                case NativeRazerApi.RzResult.RZRESULT_REQUEST_ABORTED:
                    return "Request aborted";
                case NativeRazerApi.RzResult.RZRESULT_ALREADY_INITIALIZED:
                    return "An attempt was made to perform an initialization operation when initialization has already been completed";
                case NativeRazerApi.RzResult.RZRESULT_RESOURCE_DISABLED:
                    return "Resource not available or disabled";
                case NativeRazerApi.RzResult.RZRESULT_DEVICE_NOT_AVAILABLE:
                    return "Device not available or supported";
                case NativeRazerApi.RzResult.RZRESULT_NOT_VALID_STATE:
                    return "The group or resource is not in the correct state to perform the requested operation";
                case NativeRazerApi.RzResult.RZRESULT_NO_MORE_ITEMS:
                    return "No more items";
                case NativeRazerApi.RzResult.RZRESULT_FAILED:
                    return "General failure";
                default:
                    return "UNKNOWN";
            }

        }
    }
}
