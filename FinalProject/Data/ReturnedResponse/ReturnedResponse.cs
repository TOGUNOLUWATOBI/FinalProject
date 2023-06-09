﻿using FinalProject.Data.Enum;
using System.Globalization;

namespace FinalProject.Data.ReturnedResponse
{
    public class ReturnedResponse
    {
        public static ApiResponse SuccessResponse(string message, object data, string statusCode)
        {
            var apiResp = new ApiResponse();
            apiResp.Data = data;
            apiResp.Status = Status.Successful.ToString();
            apiResp.Code = 200;
            apiResp.Message = message;
            
            return apiResp;
        }

        public static ApiResponse ErrorResponse(string message, object data, string statusCode)
        {
            var apiResp = new ApiResponse();
            apiResp.Data = data;
            apiResp.Status = Status.UnSuccessful.ToString();
            apiResp.Code = 400;
            apiResp.Message = message;
            return apiResp;
        }
    }
}
