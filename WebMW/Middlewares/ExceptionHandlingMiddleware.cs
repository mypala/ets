using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ResponseStates.Enums;
using ResponseStates.Exceptions;
using ResponseStates.Extensions;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMW.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public async Task Invoke(HttpContext context, IWebHostEnvironment env)
        {
            try
            {
                await _next(context);
            }
            catch (StateException ex)
            {
                await HandleExceptionAsync(context, ex, env);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, env);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, StateException exception, IWebHostEnvironment env)
        {
            var status = new ResponseState(exception.StateCode);

            //LOGLAMA İŞLEMİ YAPILACAK

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = status.Status.StateCode.GetStateCode();
            return context.Response.WriteAsync(status.ToString());
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, IWebHostEnvironment env)
        {
            var status = new ResponseState(StateCode.UnexpectedError);

            //LOGLAMA İŞLEMİ YAPILACAK

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = status.Status.StateCode.GetStateCode();
            return context.Response.WriteAsync(status.ToString());
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
