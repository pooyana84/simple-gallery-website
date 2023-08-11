using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GalleryWebsite.Models;

namespace GalleryWebsite.Data
{
    public class ImageContext : DbContext
    {
        public ImageContext (DbContextOptions<ImageContext> options)
            : base(options)
        {
        }

        public DbSet<GalleryWebsite.Models.Image> Image { get; set; } = default!;
    }
}
