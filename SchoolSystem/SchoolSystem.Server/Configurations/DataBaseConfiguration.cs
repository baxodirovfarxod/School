using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolSystem.Dal;

namespace SchoolSystem.Server.Configurations;

public static class DataBaseConfiguration
{
    public static void Configuration(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<MainContext>(options =>
            options.UseSqlServer(connectionString));
    }
}
