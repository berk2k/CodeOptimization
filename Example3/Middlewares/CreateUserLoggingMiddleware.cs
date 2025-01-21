using Example3.Models;
using System.Text.Json;
using System.Text;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Example3.Middlewares
{
    public class CreateUserLoggingMiddleware : IMiddleware
    {
        private readonly ILogger<CreateUserLoggingMiddleware> logger;

        public CreateUserLoggingMiddleware(ILogger<CreateUserLoggingMiddleware> logger)
        {
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var controllerActionDescriptor = context
                                             .GetEndpoint()
                                             .Metadata
                                             .GetMetadata<ControllerActionDescriptor>();

            var controllerName = controllerActionDescriptor.ControllerName;
            var actionName = controllerActionDescriptor.ActionName;

            if(actionName.Equals("createUser",StringComparison.OrdinalIgnoreCase)
                && controllerName.Equals("user", StringComparison.OrdinalIgnoreCase))
            {
                context.Request.EnableBuffering();

                var userViewModel = await JsonSerializer.DeserializeAsync<UserViewModel>(context.Request.Body);

                logger.LogInformation($"User {userViewModel.FirstName} {userViewModel.LastName} is created.");
                context.Request.Body.Position = 0;
            }

            await next(context);

            //if (context.Request.Path.Value.Contains("CreateUser"))
            //{
            //    var req = context.Request;

            //    using var reader = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true);
            //    var bodyStr = reader.ReadToEnd();

            //    var userViewModel = JsonSerializer.Deserialize<UserViewModel>(bodyStr);

            //    logger.LogInformation($"User {userViewModel.FirstName} {userViewModel.LastName} is created.");
            //}
        }
    }
}
