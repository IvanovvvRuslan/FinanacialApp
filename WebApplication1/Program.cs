using Microsoft.EntityFrameworkCore;
using Task11.Data;
using Task11.Exceptions;
using Task11.Services;




namespace Task11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));


            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddScoped<IOperationTypeService, OperationTypeService>();
            builder.Services.AddScoped<IFinancialOperationService, FinancialOperationService>();
            builder.Services.AddScoped<IReportService, ReportService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseMiddleware<ErrorHandlingMiddleware>();  // Added middleware

            app.MapControllers();

            app.Run();
        }
    }

}
