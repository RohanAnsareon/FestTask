using FestTask.Application.Exceptions;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using System.Linq;

namespace FestTask.Api.Interceptors
{
    public class FluentValidationExceptionIntercepter : IValidatorInterceptor
    {
        public IValidationContext BeforeMvcValidation(ControllerContext controllerContext, IValidationContext validationContext)
        {
            return validationContext;
        }

        public ValidationResult AfterMvcValidation(ControllerContext controllerContext, IValidationContext commonContext, ValidationResult result)
        {
            if (result.Errors.Any())
            {
                throw new FluentValidationException(result.Errors);
            }

            return result;
        }
    }
}
