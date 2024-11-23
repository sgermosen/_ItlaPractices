using ExpressTaste.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Extensions
{
    public static class ResponseExtensions
    {
        public static ApiResponse<T> ToApiResponse<T>(this T data, bool success = true, string message = null)
        {
            return new ApiResponse<T>
            {
                Success = success,
                Message = message,
                Data = data,
                Errors = null
            };
        }

        public static ApiResponse<T> ToErrorResponse<T>(this string errorMessage)
        {
            return new ApiResponse<T>
            {
                Success = false,
                Message = errorMessage,
                Data = default,
                Errors = new List<string> { errorMessage }
            };
        }
    }
}
