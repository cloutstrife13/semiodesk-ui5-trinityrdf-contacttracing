using ContactTracingGraph.Configurations;
using Microsoft.AspNet.OData.Batch;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ContactTracingGraph
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Adds the relevant dependencies such as Newtonsoft.Json, Trinity and OData to the container. 
            services.AddControllers().AddNewtonsoftJson();
            services.AddOData();

            services.AddScoped<DbContext>();
            DbContext virtuoso = new DbContext();
            virtuoso.Initialise();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            // The following lines enable OData and its batching capabilities for HTTP routing.
            app.UseODataBatching();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
                endpoints.Select().Expand().Filter().OrderBy().MaxTop(10).Count();
                endpoints.MapODataRoute("odata", "odata", ODataConfig.GetEdmModel(), new DefaultODataBatchHandler());
            });
        }
    }
}
