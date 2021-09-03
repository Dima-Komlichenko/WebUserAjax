using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebUserAjax.Data.Entities;

namespace WebUserAjax.Data
{
    public class ApplicationDbContext : IdentityDbContext<ProjectUser>
    {

        public DbSet<WebUserAjax.Data.Entities.School.Group> Groups { get; set; }
        public DbSet<WebUserAjax.Data.Entities.School.Student> Students { get; set; }
        public DbSet<WebUserAjax.Data.Entities.School.Teacher> Teachers { get; set; }

        public DbSet<WebUserAjax.Data.Entities.Slider.SliderItem> SliderItem { get; set; }
        public DbSet<WebUserAjax.Data.Entities.Slider.SliderGroup> SliderGroup { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
