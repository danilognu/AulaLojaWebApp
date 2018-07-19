using AulaLojaWebApp.Entidades;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaLojaWebApp
{
    public class MyWebAppContext : DbContext 
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }

        public MyWebAppContext(DbContextOptions<MyWebAppContext> options):base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(prop => prop.Id);
            modelBuilder.Entity<Pedido>().HasKey(prop => prop.Id);
            modelBuilder.Entity<ItemPedido>().HasKey(prop => prop.Id);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

    }
}
