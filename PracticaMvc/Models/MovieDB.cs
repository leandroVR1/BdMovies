using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace PracticaMvc.Models
{
    public class MovieDB
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime Date { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {
        }
        public DbSet<MovieDB> MovieDBs { get; set; }
    }
}
