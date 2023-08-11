using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GalleryWebsite.Data;
using System;
using System.Linq;

namespace GalleryWebsite.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ImageContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ImageContext>>()))
        {
            // Look for any movies.
            if (context.Image.Any())
            {
                return;   // DB has been seeded
            }
            context.Image.AddRange(
                new Image
                {
                    Location = "alley 1",
                    DateTime = DateTime.Parse("1989-2-1"),
                    Photographer = "pooya1",
                    Tags = "one"
                },
                new Image
                {
                    Location = "alley 2",
                    DateTime = DateTime.Parse("1989-2-2"),
                    Photographer = "pooya2",
                    Tags = "two"
                },
                new Image
                {
                    Location = "alley 3",
                    DateTime = DateTime.Parse("1989-2-3"),
                    Photographer = "pooya3",
                    Tags = "three"
                },
                new Image
                {
                    Location = "alley 4",
                    DateTime = DateTime.Parse("1989-2-4"),
                    Photographer = "pooya4",
                    Tags = "four"
                }
            );
            context.SaveChanges();
        }
    }
}