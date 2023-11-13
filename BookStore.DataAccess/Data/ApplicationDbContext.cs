using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.Data
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Mystery", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Fantasy", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Romance", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Thriller", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Comedy", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Horror", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Adventure", DisplayOrder = 10 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Solution",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                },
                new Company
                {
                    Id = 4,
                    Name = "Innovate Tech",
                    StreetAddress = "456 Innovate St",
                    City = "Techville",
                    PostalCode = "98765",
                    State = "CA",
                    PhoneNumber = "1234567890"
                },
                    new Company
                    {
                        Id = 5,
                        Name = "Digital Solutions Inc.",
                        StreetAddress = "789 Digital Ave",
                        City = "Code City",
                        PostalCode = "54321",
                        State = "CA",
                        PhoneNumber = "9876543210"
                    },
                    new Company
                    {
                        Id = 6,
                        Name = "Future Innovations",
                        StreetAddress = "101 Future Blvd",
                        City = "Futropolis",
                        PostalCode = "12345",
                        State = "NY",
                        PhoneNumber = "5556667777"
                    }
                );


            modelBuilder.Entity<Product>().HasData(
                 new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1
                },
                    new Product
                    {
                        Id = 2,
                        Title = "Dark Skies",
                        Author = "Nancy Hoover",
                        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                        ISBN = "CAW777777701",
                        ListPrice = 40,
                        Price = 30,
                        Price50 = 25,
                        Price100 = 20,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Vanish in the Sunset",
                        Author = "Julian Button",
                        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                        ISBN = "RITO5555501",
                        ListPrice = 55,
                        Price = 50,
                        Price50 = 40,
                        Price100 = 35,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Cotton Candy",
                        Author = "Abby Muscles",
                        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                        ISBN = "WS3333333301",
                        ListPrice = 70,
                        Price = 65,
                        Price50 = 60,
                        Price100 = 55,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Rock in the Ocean",
                        Author = "Ron Parker",
                        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                        ISBN = "SOTJ1111111101",
                        ListPrice = 30,
                        Price = 27,
                        Price50 = 25,
                        Price100 = 20,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Leaves and Wonders",
                        Author = "Laura Phantom",
                        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                        ISBN = "FOT000000001",
                        ListPrice = 25,
                        Price = 23,
                        Price50 = 22,
                        Price100 = 20,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 7,
                        Title = "Time Traveler's Guide",
                        Author = "Einstein Smart",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "TIMETRAV001",
                        ListPrice = 120,
                        Price = 110,
                        Price50 = 105,
                        Price100 = 100,
                        CategoryId = 4
                    },
                    new Product
                    {
                        Id = 8,
                        Title = "Code Breaker",
                        Author = "Cyber Coder",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "CODEBRK002",
                        ListPrice = 50,
                        Price = 45,
                        Price50 = 40,
                        Price100 = 35,
                        CategoryId = 5
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "Virtual Reality World",
                        Author = "VR Master",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "VRWORLD003",
                        ListPrice = 80,
                        Price = 75,
                        Price50 = 70,
                        Price100 = 65,
                        CategoryId = 6
                    },
                    new Product
                    {
                        Id = 10,
                        Title = "Mystery in the Stars",
                        Author = "Galactic Explorer",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "STARMYST004",
                        ListPrice = 65,
                        Price = 60,
                        Price50 = 55,
                        Price100 = 50,
                        CategoryId = 7
                    },
                    new Product
                    {
                        Id = 11,
                        Title = "Robot Revolution",
                        Author = "Tech Guru",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "ROBOTREV005",
                        ListPrice = 95,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 8
                    },
                    new Product
                    {
                        Id = 12,
                        Title = "Tech Marvels",
                        Author = "Marvel Tech",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "TECHMRVL012",
                        ListPrice = 75,
                        Price = 70,
                        Price50 = 65,
                        Price100 = 60,
                        CategoryId = 9
                    },
                    new Product
                    {
                        Id = 13,
                        Title = "Future Fusion",
                        Author = "Fusionist",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "FUTRFUSION013",
                        ListPrice = 85,
                        Price = 80,
                        Price50 = 75,
                        Price100 = 70,
                        CategoryId = 10
                    },
                    new Product
                    {
                        Id = 14,
                        Title = "Cybernetic Symphony",
                        Author = "Cyber Composer",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "CYBERSYMPH014",
                        ListPrice = 95,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 4
                    },
                    new Product
                    {
                        Id = 15,
                        Title = "Robo Revolution",
                        Author = "Robo Engineer",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "ROBOREV015",
                        ListPrice = 110,
                        Price = 100,
                        Price50 = 95,
                        Price100 = 90,
                        CategoryId = 5
                    },
                    new Product
                    {
                        Id = 16,
                        Title = "Quantum Quest",
                        Author = "Quantum Explorer",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "QUANTUMQ16",
                        ListPrice = 130,
                        Price = 120,
                        Price50 = 115,
                        Price100 = 110,
                        CategoryId = 6
                    },
                    new Product
                    {
                        Id = 17,
                        Title = "Digital Delight",
                        Author = "Digital Artist",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "DIGIDELIGHT17",
                        ListPrice = 60,
                        Price = 55,
                        Price50 = 50,
                        Price100 = 45,
                        CategoryId = 7
                    },
                    new Product
                    {
                        Id = 18,
                        Title = "Tech Treasure",
                        Author = "Tech Explorer",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "TECHTREASURE18",
                        ListPrice = 80,
                        Price = 75,
                        Price50 = 70,
                        Price100 = 65,
                        CategoryId = 8
                    },
                    new Product
                    {
                        Id = 19,
                        Title = "Future Formulas",
                        Author = "Formula Scientist",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "FUTFORMULAS19",
                        ListPrice = 100,
                        Price = 95,
                        Price50 = 90,
                        Price100 = 85,
                        CategoryId = 9
                    },
                    new Product
                    {
                        Id = 20,
                        Title = "Code Conundrum",
                        Author = "Code Puzzle Master",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla facilisi. Integer ac tincidunt libero.",
                        ISBN = "CODECONUNDRUM20",
                        ListPrice = 65,
                        Price = 60,
                        Price50 = 55,
                        Price100 = 50,
                        CategoryId = 10
                    }
                );
        }
    }
}