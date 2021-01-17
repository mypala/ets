using ResponseStates.Enums;
using System;
using System.Collections.Generic;

namespace ResponseStates.Exceptions
{
    public class ValidationException : Exception
    {
        public StateCode StateCode { get; set; }

        public Dictionary<string, string> ValidationErrors { get; set; }

        public ValidationException(Dictionary<string, string> validationErrors)
        {
            StateCode = StateCode.ValidationError;
            ValidationErrors = validationErrors;
        }
        public ValidationException(string message) : base(message)
        { }
    }
}
