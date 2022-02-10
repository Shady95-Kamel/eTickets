using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbIntializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName="Actor 1",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                        },
                        new Actor()
                        {
                            FullName="Actor 2",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-2.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                        },
                         new Actor()
                         {
                            FullName="Actor 3",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-3.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                         },
                          new Actor()
                          {
                            FullName="Actor 4",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-4.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                          },
                           new Actor()
                           {
                            FullName="Actor 5",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-5.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                           },
                    });
                    context.SaveChanges();
                }

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Producer 1",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-1.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                        },
                         new Producer()
                        {
                            FullName="Producer 2",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                        },
                          new Producer()
                        {
                            FullName="Producer 3",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-3.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                        },
                           new Producer()
                        {
                            FullName="Producer 4",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-4.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                        },
                            new Producer()
                        {
                            FullName="Producer 5",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-5.jpeg",
                            Bio="This Is The Bio Of The Second Actor"
                        },

                    });
                    context.SaveChanges();
                }

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema 1",
                            Logo="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This Is The Description Of The First Cienma"
                        },
                         new Cinema()
                        {
                            Name="Cinema 2",
                            Logo="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="This Is The Description Of The First Cienma"
                        },
                          new Cinema()
                        {
                            Name="Cinema 3",
                            Logo="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="This Is The Description Of The First Cienma"
                        },
                           new Cinema()
                        {
                            Name="Cinema 4",
                            Logo="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description="This Is The Description Of The First Cienma"
                        },
                            new Cinema()
                        {
                            Name="Cinema 5",
                            Logo="http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description="This Is The Description Of The First Cienma"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name="Ghost",
                            ImageURL="http://dotnethow.net/images/movies/movie-4.jpeg",
                            Description="This Is The Ghost Movie Description",
                            Price=39.50,
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemId=4,
                            ProducerId=4,
                            MovieCategory=MovieCategory.Horror
                        },
                         new Movie()
                        {
                            Name="Life",
                            ImageURL="http://dotnethow.net/images/movies/movie-3.jpeg",
                            Description="This Is The Life Movie Description",
                            Price=39.50,
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(10),
                            CinemId=3,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Documentray
                        },
                        new Movie()
                        {
                            Name="Scoop",
                            ImageURL="http://dotnethow.net/images/movies/movie-7.jpeg",
                            Description="This Is The Scoop Movie Description",
                            Price=39.50,
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-2),
                            CinemId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Cartoon
                        },
                         new Movie()
                        {
                            Name="Cold Soles",
                            ImageURL="http://dotnethow.net/images/movies/movie-8.jpeg",
                            Description="This Is The Cold Soles Movie Description",
                            Price=39.50,
                            StartDate=DateTime.Now.AddDays(3),
                            EndDate=DateTime.Now.AddDays(20),
                            CinemId=1,
                            ProducerId=5,
                            MovieCategory=MovieCategory.Drama
                        },
                          new Movie()
                        {
                            Name="Race",
                            ImageURL="http://dotnethow.net/images/movies/movie-6.jpeg",
                            Description="This Is The Race Movie Description",
                            Price=39.50,
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-5),
                            CinemId=1,
                            ProducerId=2,
                            MovieCategory=MovieCategory.Documentray
                        },
                             new Movie()
                        {
                            Name="The Shawshank Redemption",
                            ImageURL="http://dotnethow.net/images/movies/movie-1.jpeg",
                            Description="This Is The Shawshank Redemption Movie Description",
                            Price=39.50,
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(3),
                            CinemId=1,
                            ProducerId=1,
                            MovieCategory=MovieCategory.Action
                        },

                    });
                    context.SaveChanges();
                }

                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie> {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=3
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=3
                        },
                        new Actor_Movie()
                        { 
                            ActorId=1,
                            MovieId=4
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=7
                        },
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=7
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=8
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=8
                        },
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=8
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=7
                        },
                        new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=7
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=6
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=6
                        },
                        new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=6
                        },
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=5
                        },
                        new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=5
                        },
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=5
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=4
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
