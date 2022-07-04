﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Oferton.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oferton.WebExceptionsPresenter
{
    public class GeneralExceptionHandler : ExceptionHandlerBase, IExceptionHandler
    {
        public Task Handle(ExceptionContext context)
        {
            var Exception = context.Exception as GeneralException;
            return SetResult(context, StatusCodes.Status500InternalServerError,
                Exception.Message, Exception.Detail);
        }
    }
}
