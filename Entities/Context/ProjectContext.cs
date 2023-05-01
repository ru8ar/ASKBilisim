using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entities.Context
{
    public class ProjectContext : IdentityDbContext<User>
    {
        public ProjectContext()
        {

        }
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) 
        {

        }
        public virtual DbSet<CustomerMessaage> CustomerComments { get; set; }
        public virtual DbSet<CustomerCommentImage> CustomerCommentImages { get; set; }
        public virtual DbSet<CustomerMessage> CustomerMessages { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectCategory> ProjectCategoris { get; set; }
        public virtual DbSet<ProjectImage> ProjectImages { get; set; }
        public virtual DbSet<ProjectMobileImage> ProjectMobileImages { get; set; }
        public virtual DbSet<ProjectRequestArticle> ProjectRequestArticles { get; set; }
        public virtual DbSet<ProjectResultArticle> ProjectResultArticles { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<ReferenceImage> ReferenceImages { get; set; }
        public virtual DbSet<User> Users { get; set; }



    }
}
