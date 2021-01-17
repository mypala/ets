using ResponseStates.Enums;
using System;
using System.Collections.Generic;

namespace ResponseStates.Exceptions
{
    public class StateException : Exception
    {
        public StateCode StateCode { get; set; }

        public StateException()
        { }
        public StateException(StateCode stateCode)
        {
            StateCode = stateCode;
        }
        public StateException(string message) : base(message)
        {
            StateCode = StateCode.Error;
        }
        public StateException(string message, StateCode stateCode) : base(message)
        {
            StateCode = stateCode;
        }
    }
}
