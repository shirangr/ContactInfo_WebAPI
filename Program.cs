using Microsoft.EntityFrameworkCore;
using ContactInfo_WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapControllers();

app.Run();

//Using swagger
//namespace ContactInfo_WebAPI
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            //add Services
//            builder.Services.AddControllers();
//            builder.Services.AddEndpointsApiExplorer();
//            builder.Services.AddSwaggerGen();

//            var app = builder.Build();

//            if (app.Environment.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI();
//            }

//            app.UseHttpsRedirection();

//            app.UseAuthorization();

//            app.MapControllers();

//            app.Run();
//        }
//    }

//}