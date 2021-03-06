using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PTIT.B17DCCN490.PTTK_DBCLPM.Models;
using PTIT.B17DCCN490.PTTK_DBCLPM.Models.DAO;
using PTIT.B17DCCN490.PTTK_DBCLPM.Models.DAO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTIT.B17DCCN490.PTTK_DBCLPM
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddSession();
            services.AddRazorPages();
            services.AddScoped(typeof(IBaseDAO<>), typeof(BaseDAO<>));
            services.AddScoped<ISuKienDAO, SuKienDAO>();
            services.AddScoped<ITranDauDAO, TranDauDAO>();
            services.AddScoped<ILoaiVongDauDAO, LoaiVongDauDAO>();
            services.AddScoped<ILoaiSuKienDAO, LoaiSuKienDAO>();
            services.AddScoped<ICauThuDAO, CauThuDAO>();
            services.AddScoped<IBXHCauThuBanThangDAO, BXHCauThuBanThangDAO>();
            services.AddScoped<IBXHDAO, BXHDAO>();
            services.AddScoped<ICauThuDoiBongTranDauDAO, CauThuDoiBongTranDauDAO>();
            services.AddScoped<IGiaiDauDAO, GiaiDauDAO>();
            services.AddScoped<ITranDauDAO, TranDauDAO>();
            services.AddScoped<IBanToChucDAO, BanToChucDAO>();
            services.AddScoped<IVongDauDAO, VongDauDAO>();
            services.AddScoped<IDoiBongGiaiDauDAO, DoiBongGiaiDauDAO>();
            services.AddScoped<IDoiBongDAO, DoiBongDAO>();
            services.AddScoped<IBangDauDAO, BangDauDAO>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/BanToChuc/DangNhap";
            });

            services.AddAuthorization();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Loi");
            }

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials());
            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=TrangChu}/{action=Index}"
                );
            });
        }
    }
}
