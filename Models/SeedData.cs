using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CardDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CardDbContext>>()))
            {
                if (context == null || context.BaseballCards == null)
                {
                    throw new ArgumentNullException("Null RazorPagesCardDbContext");
                }

                // Look for any movies.
                if (context.BaseballCards.Any())
                {
                    return;   // DB has been seeded
                }

                context.BaseballCards.AddRange(
                    new BaseballCard
                    {
                        Name = "Shohei Ohtani",
                        CardPackage = "2018 Bowman's Best",
                        CardType = "RookieCard Superfactors",
                        CardNumber = "#US285",
                        CardCondition = "10",
                        Price = 425000M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "Jimbo.3314"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Mike Trout",
                        CardPackage = "2011 Topps Update",
                        CardType = "Diamond Anniversary",
                        CardNumber = "#US175",
                        CardCondition = "10",
                        Price = 25000M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "Frank8734"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Fernando Tatis Jr.",
                        CardPackage = "2019 Bowman Chrome",
                        CardType = "Nat'L Conv. -Red Ref.",
                        CardNumber = "#BNRFTJ",
                        CardCondition = "10",
                        Price = 65000M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "User1282"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Bryce Harper",
                        CardPackage = "2012 Bowman Chrome",
                        CardType = "Red Refractors",
                        CardNumber = "#214",
                        CardCondition = "9.5",
                        Price = 15000M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "BaseballLover71"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Juan Soto",
                        CardPackage = "2018 Topps Update",
                        CardType = "Batting-Gold",
                        CardNumber = "#US300",
                        CardCondition = "10",
                        Price = 7000M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "SotoFanBase13"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Mookie Betts",
                        CardPackage = "2014 Bowman's Prospects",
                        CardType = "Chrome",
                        CardNumber = "#BCP109",
                        CardCondition = "10",
                        Price = 1200M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "ILikeBaseball"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Jacob DeGrom",
                        CardPackage = "2014 Bowman Chrome",
                        CardType = "Chrome-Orange Wave Ref.",
                        CardNumber = "#BCP73",
                        CardCondition = "10",
                        Price = 1500M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "AstrosRule"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Vladimir Guerrero Jr.",
                        CardPackage = "Generational Icons",
                        CardType = "Rookie Card",
                        CardNumber = "Unk.",
                        CardCondition = "Ungraded",
                        Price = 600M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "YankeesAllTheWay"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Freddie Freeman",
                        CardPackage = "2007 Bowman Chrome",
                        CardType = "DP & Pros. - XFactors",
                        CardNumber = "#BDPP12",
                        CardCondition = "10",
                        Price = 2500M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "Troller34"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Ronald Acuna",
                        CardPackage = "2017 Bowman Chrome",
                        CardType = "Prospects -Chrome -Ref.",
                        CardNumber = "#BCP127",
                        CardCondition = "10",
                        Price = 2159.99M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "WashingtonState264"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Aaron Judge",
                        CardPackage = "2017 Topps Now",
                        CardType = "Black Label",
                        CardNumber = "#696",
                        CardCondition = "10",
                        Price = 7500M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "User9247"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Max Scherzer",
                        CardPackage = "2022 Topps Update",
                        CardType = "Silver Pack",
                        CardNumber = "#T87C-43",
                        CardCondition = "10",
                        Price = 2500M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "WhoLikesTheRoyals68"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Trea Turner",
                        CardPackage = "2022 Topps Chrome",
                        CardType = "Superfactor Wow",
                        CardNumber = "#190",
                        CardCondition = "Ungraded",
                        Price = 2999M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "TimWasHere"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Carlos Correa",
                        CardPackage = "2018 Topps Inception",
                        CardType = "Gld. Inscrpt.",
                        CardNumber = "#SS-CC",
                        CardCondition = "9",
                        Price = 12000M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "MaddenIsAwesome245"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Jose Ramirez",
                        CardPackage = "2014 Topps",
                        CardType = "1st Edition",
                        CardNumber = "#424",
                        CardCondition = "9",
                        Price = 8999M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "UmpireIsMe0987"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Gerrit Cole",
                        CardPackage = "2013 Panini Prizm",
                        CardType = "Prizm",
                        CardNumber = "#239",
                        CardCondition = "10",
                        Price = 3500M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "User520"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Babe Ruth",
                        CardPackage = "2022 Topps Pristine",
                        CardType = "SuperFactors",
                        CardNumber = "#190",
                        CardCondition = "10",
                        Price = 30000M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "BaseSteeler"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Willie Mays",
                        CardPackage = "1951 Bowman",
                        CardType = "-No Title-",
                        CardNumber = "#305",
                        CardCondition = "2",
                        Price = 7925M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "DannyIsAFreak667"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Ty Cobb",
                        CardPackage = "T206 Sweet Caporal",
                        CardType = "Bat Off Shoulder",
                        CardNumber = "Unk.",
                        CardCondition = "4",
                        Price = 18300M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "ILoveMcDonalds12345"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Jose Altuve",
                        CardPackage = "2021 Topps Tribute",
                        CardType = "Autograph Patches",
                        CardNumber = "#JA",
                        CardCondition = "10",
                        Price = 3500M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "User52036"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Kris Bryant",
                        CardPackage = "2014 Bowman Chrome",
                        CardType = "Auto Pros -Black Wave Ref.",
                        CardNumber = "#KB",
                        CardCondition = "10",
                        Price =25000M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "BatBreaker120"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Joey Votto",
                        CardPackage = "2021 Topps Now",
                        CardType = "Red Parallel",
                        CardNumber = "#563",
                        CardCondition = "4",
                        Price = 285M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "HatCapper12"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Walker Buehler",
                        CardPackage = "2015 Bowman Chrome",
                        CardType = "Draft Picks Auto",
                        CardNumber = "#BCAWB",
                        CardCondition = "10",
                        Price = 1974.99M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "SmoothSlider123"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Manny Machado",
                        CardPackage = "2010 Bowman Chrome",
                        CardType = "Prospect Autographs",
                        CardNumber = "Unk.",
                        CardCondition = "9.5",
                        Price = 550M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "User82643"}
                        }
                    },

                    new BaseballCard
                    {
                        Name = "Kyle Tucker",
                        CardPackage = "2014 Bowman",
                        CardType = "Pros -Chrome -Red Ref.",
                        CardNumber = "#BCP28",
                        CardCondition = "10",
                        Price = 500M,
                        Owners = new List<Owner>
                        {
                            new Owner {Ownership = "TheShow688"}
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}