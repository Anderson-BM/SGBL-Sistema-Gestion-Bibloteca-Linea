//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using SGBL.Infrastructure.Identity.Context;

//namespace SGBL.Infrastructure.Identity
//{
//    public static class ServiceRegistration
//    {
//        public static void AddIdentityLayer(this IServiceCollection services, IConfiguration configuration)
//        {
//            #region Contexts
//            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
//            {
//                services.AddDbContext<IdentityContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
//            }
//            else
//            {
//                services.AddDbContext<IdentityContext>(options =>
//                {
//                    options.EnableSensitiveDataLogging();
//                    options.UseSqlServer(configuration.GetConnectionString("IdentityConnection"),
//                    m => m.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName));

//                });
//            }
//            #endregion

//            #region Identity

//            #endregion
//        }
//    }
//}