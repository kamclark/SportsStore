using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{

    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "AULA Keyboard",
                        Description = "Solid mechanical keyboard.",
                        Category = "Input/Output Devices",
                        Price = 39.95m
                    },
                    new Product
                    {
                        Name = "Dell Keyboard",
                        Description = "Dude, you got a Dell......keyboard!",
                        Category = "Input/Output Devices",
                        Price = 29.99m
                    },
                    new Product
                    {
                        Name = "Viewsonic Display",
                        Description = "27 inches of vibrant color and display.",
                        Category = "Monitors",
                        Price = 289
                    },
                    new Product
                    {
                        Name = "ASUS Display",
                        Description = "A movie theater couldn't be more immersive.",
                        Category = "Monitors",
                        Price = 489
                    },
                    new Product
                    {
                        Name = "Viewsonic Display",
                        Description = "27 inches of vibrant color and display.",
                        Category = "Monitors",
                        Price = 289.99m
                    },
                    new Product
                    {
                        Name = "Monoprice HDMI Cable",
                        Description = "Nothing much here, just a cable.",
                        Category = "Accessories",
                        Price = 7
                    },
                    new Product
                    {
                        Name = "Griffin HDMI Cable",
                        Description = "Nothing much here, just a more expensive cable.",
                        Category = "Accessories",
                        Price = 9.50m
                    },
                    new Product
                    {
                        Name = "Middleware Motherboard",
                        Description = "Middle of the road, midmarket motherboard, man.",
                        Category = "Motherboards",
                        Price = 199
                    },
                    new Product
                    {
                        Name = "Dragonscale ATX Tower",
                        Description = "It looks like something out of Morrowind.",
                        Category = "Pesonal Computer Towers",
                        Price = 300
                    }
                );
                context.SaveChanges();
            }
        }
    }
}