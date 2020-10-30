using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace FestTask.Application.Exceptions
{
    public class FluentValidationException : Exception
    {
        public IList<ValidationFailure> Errors { get; set; }

        public FluentValidationException(IList<ValidationFailure> errors)
        {
            Errors = errors;
        }
    }
}
