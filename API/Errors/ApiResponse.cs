using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatisCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatisCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A Bad request, you have made",
                401 => "Authorized you are NOT",
                403 => "Forbidden from doing this, you are",
                404 => "Resource found Not",
                500 => "Errors the path to the Dark Side are",
                _ => null
            };
        }
    }
}
