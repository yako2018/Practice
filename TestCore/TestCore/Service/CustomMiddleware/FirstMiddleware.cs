using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestCore.Service.CustomMiddleware
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;

        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            
            //var sw = new Stopwatch();
            //sw.Start();
            //await _next(context);
            //var isHtml = context.Response.ContentType?.ToLower().Contains("text/html");
            //if (context.Response.StatusCode == 200 && isHtml.GetValueOrDefault())
            //{
            //    var body = context.Response.Body;
            //    using (var streamWriter = new StreamWriter(body))
            //    {
            //        var textHtml = string.Format(
            //            "<footer><div id='process'>Response Time {0} milliseconds.</div>",
            //            sw.ElapsedMilliseconds);
            //        streamWriter.Write(textHtml);
            //    }
            //}
            await context.Response.WriteAsync($"{nameof(FirstMiddleware)} in. \r\n");
            await _next(context);
            await context.Response.WriteAsync($"{nameof(FirstMiddleware)} out. \r\n");
        }
    }
}
