﻿using Microsoft.AspNetCore.Mvc.Filters;
using WebApi.Models.Repositories;
using WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace WebApi.Filters.ActionFilters
{
    public class Shirt_ValidateCreateShirtFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var shirt = context.ActionArguments["shirt"] as Shirt;

            if(shirt == null)
            {
                context.ModelState.AddModelError("Shirt", "Shirt object is null");
                var problemDetails = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status400BadRequest
                };
                context.Result = new BadRequestObjectResult(problemDetails);
            }

            var existingShirt = ShirtRepository.GetShirtByProperties(shirt.Brand, shirt.Gender, shirt.Color, shirt.Size);

            if(existingShirt != null)
            {
                context.ModelState.AddModelError("Shirt", "Shirt is exist");
                var problemDetails = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status400BadRequest
                };
                context.Result = new BadRequestObjectResult(problemDetails);
            }
        }
    }
}
