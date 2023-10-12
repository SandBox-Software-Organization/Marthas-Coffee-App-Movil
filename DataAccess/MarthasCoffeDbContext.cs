using Marthas_Coffee_App_Movil.Modelos;
using Marthas_Coffee_App_Movil.Utilidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marthas_Coffee_App_Movil.DataAccess
{
    public class MarthasCoffeDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDb = $"Filename={ConexionDB.DevolverRuta("MarthasCoffe.db")}";
            optionsBuilder.UseSqlite(conexionDb);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(c => c.IdCategoria);
                entity.Property(c => c.IdCategoria).IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.HasKey(c => c.IdDireccion);
                entity.Property(c => c.IdDireccion).IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Tarjeta>(entity =>
            {
                entity.HasKey(c => c.IdTarjeta);
                entity.Property(c => c.IdTarjeta).IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Producto>(entity => {
                entity.HasKey(c => c.IdProducto);
                entity.Property(c => c.IdProducto).IsRequired().ValueGeneratedOnAdd();
                entity.HasOne(c => c.RefCategoria).WithMany(p => p.Productos)
                .HasForeignKey(p => p.IdCategoria);
            });

            modelBuilder.Entity<Compra>(entity => {
                entity.HasKey(c => c.IdCompra);
                entity.Property(c => c.IdCompra).IsRequired().ValueGeneratedOnAdd();
                entity.HasOne(c => c.RefDireccion).WithMany(p => p.Compras)
                .HasForeignKey(p => p.IdDireccion);
                entity.HasOne(c => c.RefTarjeta).WithMany(p => p.Compras)
                .HasForeignKey(p => p.IdTarjeta);
            });


            modelBuilder.Entity<DetalleCompra>(entity => {
                entity.HasKey(c => c.IdDetalleCompra);
                entity.Property(c => c.IdDetalleCompra).IsRequired().ValueGeneratedOnAdd();
                entity.HasOne(c => c.RefCompra).WithMany(p => p.RefDetalleCompra)
                .HasForeignKey(p => p.IdCompra);
                entity.HasOne(c => c.RefProducto).WithMany(p => p.RefDetalleCompra)
               .HasForeignKey(p => p.IdProducto);
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(c => c.IdCarrito);
                entity.Property(c => c.IdCarrito).IsRequired().ValueGeneratedOnAdd();
            });


            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { IdCategoria = 1, Descripcion = "Bebidas", Imagen = "calientesbebida1capuchino.png" },
                new Categoria { IdCategoria = 2, Descripcion = "Platillos", Imagen = "sushi.png" },
                new Categoria { IdCategoria = 3, Descripcion = "Bocadillos", Imagen = "gomitas.png" },
                new Categoria { IdCategoria = 4, Descripcion = "Postres", Imagen = "pie.png" }
                
                );

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    IdProducto = 1,
                    Nombre = "Horchata",
                    Descripcion = "------- ----------- ----------------------------------- -----",
                    IdCategoria = 1,
                    Precio = 0.50M,
                    Imagen = "horchata.png"
                },
                new Producto
                {
                    IdProducto = 2,
                    Nombre = "Frape",
                    Descripcion = "---- ------------------- -------------------------- ----------",
                    IdCategoria = 1,
                    Precio = 2.0M,
                    Imagen = "frape.png"
                },
                new Producto
                {
                    IdProducto = 3,
                    Nombre = "Limonada",
                    Descripcion = "-------------- ----------------------- ------------------- --",
                    IdCategoria = 1,
                    Precio = 3000,
                    Imagen = "prod3.jpg"
                },
                new Producto
                {
                    IdProducto = 4,
                    Nombre = "Capuchino",
                    Descripcion = "---------- ------------------ ----------------------------- -----",
                    IdCategoria = 1,
                    Precio = 3200,
                    Imagen = "prod4.jpg"
                }
                );
        }


    }
}

    

