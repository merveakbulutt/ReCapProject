using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Text;

namespace Core.Extensions
{
    public class ValidationErrorDetails : ErrorDetails
    {
        public IEnumerable<ValidationFailure> Errors { get; set; }
    }
}
