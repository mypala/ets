﻿using ResponseStates.Enums;
using ResponseStates.Extensions;

namespace ResponseStates.Models
{
    public class Status
    {
        public StateCode StateCode;
        public int Code { get; set; }
        public double SubCode { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }

        public Status()
        {
            StateCode = StateCode.OK;
            Code = StateCode.OK.GetStateCode();
            SubCode = StateCode.OK.GetSubStateCode();
            Message = StateCode.OK.GetMessage();
            Success = StateCode.OK.GetSuccess();
        }

        public Status(StateCode code)
        {
            StateCode = code;
            Code = code.GetStateCode();
            SubCode = code.GetSubStateCode();
            Message = code.GetMessage();
            Success = code.GetSuccess();
        }

        public Status(StateCode code, params object[] message)
        {
            StateCode = code;
            Code = code.GetStateCode();
            SubCode = code.GetSubStateCode();
            Message = code.GetMessage(message);
            Success = code.GetSuccess();
        }

        public Status(int code, string message, bool isSuccess = true)
        {
            Code = 220 + code;
            Message = message;
            Success = isSuccess;
        }
    }
}
