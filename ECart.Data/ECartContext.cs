using ECart.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECart.Data
{
    public class ECartContext : DbContext
    {
        public ECartContext(DbContextOptions<ECartContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<HomePageHeading> HomePageHeadings { get; set; }
        public DbSet<HomePageProduct> HomePageProducts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ProductRatingReview> ProductRatingReviews { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SiteSetting> SiteSettings { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ShippingPincode> ShippingPincodes { get; set; }
        public DbSet<ShippingPincodeSlab> ShippingPincodeSlabs { get; set; }
        public DbSet<PaymentOrder> PaymentOrders { get; set; }
    }
}
