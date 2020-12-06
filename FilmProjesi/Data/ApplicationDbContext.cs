using System;
using System.Collections.Generic;
using System.Text;
using FilmProjesi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmProjesi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Film> Film { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
