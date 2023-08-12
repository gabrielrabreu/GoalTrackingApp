﻿using WebApi.Scope.Filters;

namespace WebApi.Scope.Extensions
{
    public static class ControllersServiceCollectionExtensions
    {
        public static void AddCustomControllers(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(SessionActionFilter));
            }).AddNewtonsoftJson();
        }
    }
}
