using AutoMapper;
using FestTask.Api.Filters;
using FestTask.Api.HttpDelegates;
using FestTask.Api.Interceptors;
using FestTask.Application.Options;
using FestTask.Application.Services;
using FestTask.Application.Services.Abstractions;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using System.Text.Json.Serialization;

namespace FestTask.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Fest Weather App", Version = "v1" });

                var filePath = Path.Combine(System.AppContext.BaseDirectory, "FestTask.Api.xml");
                c.IncludeXmlComments(filePath);
            });
            #endregion

            services.Configure<WeatherMapApiOptions>(Configuration.GetSection("WeatherMapApi"));

            services.Configure<TimeZoneApiOptions>(Configuration.GetSection("TimeZoneApi"));

            services.AddScoped<WeatherHttpDelegate>();

            services.AddScoped<TimeZoneHttpDelegate>();

            services.AddScoped<IValidatorInterceptor, FluentValidationExceptionIntercepter>();

            services.AddHttpClient<IWeatherService, WeatherService>(c =>
            {
                c.BaseAddress = new Uri(Configuration.GetSection("WeatherMapApi")["BaseUrl"]);
            }).AddHttpMessageHandler<WeatherHttpDelegate>();

            services.AddHttpClient<ITimeZoneService, TimeZoneService>(c =>
            {
                c.BaseAddress = new Uri(Configuration.GetSection("TimeZoneApi")["BaseUrl"]);
            }).AddHttpMessageHandler<TimeZoneHttpDelegate>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddCors(options =>
            {
                options.AddPolicy("AngularClient", builder =>
                {
                    builder.WithOrigins("http://localhost:4200");
                });
            });


            services.AddControllers(options => options.Filters.Add<BadRequestExceptionFilter>())
                .AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<Startup>())
                .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Fest Weather Api");
                });

                app.UseCors("AngularClient");
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
