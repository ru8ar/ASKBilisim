using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Root
{
    public class CompositionRoot
    {

        public CompositionRoot() { }

        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddScoped<ProjectContext>();

            services.AddScoped(typeof(ICustomerCommentImageService), typeof(CustomerCommentImageService));
            services.AddScoped(typeof(ICustomerCommentService), typeof(CustomerCommentService));
            services.AddScoped(typeof(ICustomerMessageService), typeof(CustomerMessageService));
            services.AddScoped(typeof(IOfferService), typeof(OfferService));
            services.AddScoped(typeof(IProjectCategoryService), typeof(ProjectCategoryService));
            services.AddScoped(typeof(IProjectImageService), typeof(ProjectImageService));
            services.AddScoped(typeof(IProjectMobileImageService), typeof(ProjectMobileImageService));
            services.AddScoped(typeof(IProjectRequestArticleService), typeof(ProjectRequestArticleService));
            services.AddScoped(typeof(IProjectResultArticleService), typeof(ProjectResultArticleService));
            services.AddScoped(typeof(IProjectService), typeof(ProjectService));
            services.AddScoped(typeof(IReferenceImageService), typeof(ReferenceImageService));
            services.AddScoped(typeof(IReferenceService), typeof(ReferenceService));

            services.AddDbContext<ProjectContext>(options => options.UseSqlServer
                ("server= DESKTOP-OQ7MB96 ;database=AskBilisimCodeFirst ;MultipleActiveResultSets = true", x => x.MigrationsAssembly("UI")));
        }
    }
}