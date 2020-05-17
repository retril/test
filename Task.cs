using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace task1.Models
{
    public partial class Item
    {
        public Item() { }
        public Item(int? id)
        {
            Itemid = id;
        }
        public int? Itemid{get;set;}
        public DateTime? Data { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public int? Complete { get; set; }
    }

    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("tasks", "tasks");
            builder.HasKey(x=>x.Itemid);
            builder.Property(x => x.Data).HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.Title).HasColumnType("nvarchar(64)").IsRequired();
            builder.Property(x => x.Discription).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.Complete).HasColumnType("int(3)").IsRequired();
            builder.Property(x => x.Itemid).HasColumnType("int").IsRequired().HasDefaultValueSql("NEXT VALUE FOR [Sequences].[Itemid]");         
        }
    }

    public class ItemsDbContext : DbContext
    {
        public ItemsDbContext(DbContextOptions<ItemsDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ItemConfiguration());
            base.OnModelCreating(builder);
        }
        public DbSet<Item> Items { get; set; }
    }



    
}
