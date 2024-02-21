﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
           services.AddScoped<IServiceService, ServiceManager>();
           services.AddScoped<IServiceDal, EfServiceDal>();
           services.AddScoped<ITeamService, TeamManager>();
           services.AddScoped<ITeamDal, EfTeamDal>();
           services.AddScoped<IAnnouncementService, AnnouncementManager>();
           services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
           services.AddScoped<IImageService, ImageManager>();
           services.AddScoped<IImageDal, EfImageDal>();
           services.AddScoped<IAddressService, AddressManager>();
           services.AddScoped<IAddressDal, EfAddressDal>();
           services.AddScoped<IContactService, ContactManager>();
           services.AddScoped<IContactDal, EfContactDal>();
           services.AddScoped<ISocialMediaService, SocialMediaManager>();
           services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
           services.AddScoped<IAboutService, AboutManager>();
           services.AddScoped<IAboutDal, EfAboutDal>();
           services.AddScoped<IAdminService, AdminManager>();
           services.AddScoped<IAdminDal, EfAdminDal>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IContactService, ContactManager>();
        }
    }
}
