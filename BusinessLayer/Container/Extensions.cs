using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationVules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentRepository>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationRepository>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideRepository>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsRepository>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementRepository>();
        }
        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();

        }
    }
}
