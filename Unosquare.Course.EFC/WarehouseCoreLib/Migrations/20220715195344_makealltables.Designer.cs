﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseCoreLib;

#nullable disable

namespace WarehouseCoreLib.Migrations
{
    [DbContext(typeof(DevSQLWarehouseDBContext))]
    [Migration("20220715195344_makealltables")]
    partial class makealltables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductWarehouseInfo", b =>
                {
                    b.Property<int>("productsid")
                        .HasColumnType("int");

                    b.Property<int>("warehouseInfoid")
                        .HasColumnType("int");

                    b.HasKey("productsid", "warehouseInfoid");

                    b.HasIndex("warehouseInfoid");

                    b.ToTable("ProductWarehouseInfo");
                });

            modelBuilder.Entity("WarehouseModels.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mattel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Marvel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Nintento"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sony"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Microsot"
                        });
                });

            modelBuilder.Entity("WarehouseModels.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("ageRestriction")
                        .HasColumnType("int");

                    b.Property<int>("companyId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("imageIurl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(9,2)");

                    b.Property<int>("storeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("companyId");

                    b.HasIndex("storeid");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ageRestriction = 5,
                            companyId = 1,
                            description = "Owen & Blue Jurassic World Dominion Extreme Damage",
                            imageIurl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcThvns4l8crE59d-onYVPiLEtmaU0nrBCmkq081nXaQEwSGZZZd-7fX37uoC_yvMnewMadxheOl4lwTy7HPBbzLZMgLUTT-dtt1jy9EwoHYnBSoptPQpY7UlA",
                            name = "Jurassic World Dominion Extreme Damage",
                            price = 619.4m,
                            storeid = 3
                        },
                        new
                        {
                            id = 2,
                            ageRestriction = 2,
                            companyId = 1,
                            description = "Toy Story Buzz Vuelo Espacial",
                            imageIurl = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcRqYWqWbYTWEuI-d5Y4RB8UrFldHMpdkCfoqmv7CJYijolQfcy-Vbo1af2-a8KAK-jkf6PRDICytGtQ3TSjjxLpMw3i-aje0NfwqiW69WaG4R2hzaMGkvx1JA",
                            name = "Toy Story Buzz Vuelo Espacial",
                            price = 459.35m,
                            storeid = 5
                        },
                        new
                        {
                            id = 3,
                            ageRestriction = 6,
                            companyId = 1,
                            description = "Juguete Mattel Masters of the Universe Skelegod",
                            imageIurl = "https://res.cloudinary.com/walmart-labs/image/upload/w_960,dpr_auto,f_auto,q_auto:best/mg/gm/1p/images/product-images/img_large/00088796197992l.jpg",
                            name = "Juguete Mattel Masters of the Universe Skelegod",
                            price = 499.2m,
                            storeid = 1
                        },
                        new
                        {
                            id = 4,
                            ageRestriction = 10,
                            companyId = 2,
                            description = "FIGLot ZD Toys Marvel Iron Man Mark 3 Mark III Figura de acción de 7",
                            imageIurl = "https://m.media-amazon.com/images/I/51AEF32Dz+L._AC_SX300_SY300_.jpg",
                            name = "Iron Man Mark 3 Mark III Figura de acción",
                            price = 663.17m,
                            storeid = 4
                        },
                        new
                        {
                            id = 5,
                            ageRestriction = 10,
                            companyId = 2,
                            description = "Marvel Legends Spiderman Symbiote",
                            imageIurl = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcSKflghUkO7J_HIxgObXMQWXVQY8qQR9cR-8vKD8shg4QL3nqCoCD_1wOnHkIDOsaglMA1ClkjGfMtC8xJQ14LYqCDhDe7KqPa_cxZAFSDKTnFcbvqIEKgMWA",
                            name = "Spiderman Symbiote Marvel Legends ",
                            price = 599m,
                            storeid = 2
                        },
                        new
                        {
                            id = 6,
                            ageRestriction = 15,
                            companyId = 2,
                            description = "Thanos Avengers Endgame Hot Toys",
                            imageIurl = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcSwN3z4us5tzBooLkPyU9McTRMpav6kbHBcDeW1kaePEhRrhd3eDlYtUqzaljLBct5l-iAYeWhdNN1jj02sXS3XmJCPwRjNLlDX-8yhdjXtKzpnUfKb1iOIgA",
                            name = "Thanos Avengers Endgame Hot Toys",
                            price = 1580.74m,
                            storeid = 1
                        },
                        new
                        {
                            id = 7,
                            ageRestriction = 15,
                            companyId = 3,
                            description = "Nintendo NES Classic Mini Consola, color Gris - Classics Edition",
                            imageIurl = "https://m.media-amazon.com/images/I/81s7B+Als-L._AC_SX679_.jpg",
                            name = "NES Classic Mini Consola",
                            price = 4997m,
                            storeid = 3
                        },
                        new
                        {
                            id = 8,
                            ageRestriction = 15,
                            companyId = 3,
                            description = "Nintendo Switch Lite -Turquesa",
                            imageIurl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSZUB1F7Ft-CQ2OpC7LyrPKg7GYYWfKulXAKDmIveVHsXbfdw-q6YycSDHDxiQjb1tXXckHkI3qraIaaHhuaVO-kaK1G8UOenP7AaqciGDa",
                            name = "Nintendo Switch Lite -Turquesa",
                            price = 5489m,
                            storeid = 3
                        },
                        new
                        {
                            id = 9,
                            ageRestriction = 15,
                            companyId = 4,
                            description = "Control Inalámbrico Dualsense Cosmic Red - Playstation 5",
                            imageIurl = "https://m.media-amazon.com/images/I/71-2sMke9uS._AC_SX679_.jpg",
                            name = "Control Inalámbrico Dualsense Cosmic Red ",
                            price = 1390m,
                            storeid = 1
                        },
                        new
                        {
                            id = 10,
                            ageRestriction = 5,
                            companyId = 4,
                            description = "Bocina sony srs-xp500",
                            imageIurl = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcRrEnuy_6KtpBKsl6dhdtt6xoh8MuwDL_amnqwy8kfXBW7d-v0Ndw7MTOzwQF0nAQCBDpUwzjdAqPMntZT-MzFjqM0eTQUGsX0FZvIyHgpbL28_mawQxasBCA",
                            name = "Bocina sony srs-xp500",
                            price = 7613m,
                            storeid = 5
                        },
                        new
                        {
                            id = 11,
                            ageRestriction = 5,
                            companyId = 5,
                            description = "Mouse Microsoft Óptico Camo SE, Inalámbrico, Bluetooth 5.0, 1000DPI, Verde",
                            imageIurl = "https://www.cyberpuerta.mx/img/product/M/CP-MICROSOFT-8KX-00003-cb7e3a.jpg",
                            name = "Mouse Microsoft Óptico Camo SE",
                            price = 375m,
                            storeid = 3
                        },
                        new
                        {
                            id = 12,
                            ageRestriction = 5,
                            companyId = 5,
                            description = "Kit De Teclado Y Mouse Microsoft 1ai-00003",
                            imageIurl = "https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcQpd3HERKl-ka_ZdWXjM6kW0b2jGYe2VGlNol7dNvT4w2pZrqTs8cM5z_fc6Y-ZxHCiZjtqOWvOi4hUfmt3n72ekyaLdQ80oo4GXUyiD1gXn_XlfOfM1JNo",
                            name = "Kit De Teclado Y Mouse Microsoft 1ai-00003",
                            price = 999m,
                            storeid = 2
                        });
                });

            modelBuilder.Entity("WarehouseModels.Models.ProductWarehouse", b =>
                {
                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("warehouseId")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("productId", "warehouseId");

                    b.ToTable("ProductsWarehouses");
                });

            modelBuilder.Entity("WarehouseModels.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("storeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            address = "Plaza Galerias,Avenida Insurgentes 2500, Galerias Monterrey, Monterrey",
                            city = "Monterrey, NL",
                            storeName = "Galerias Monterrey"
                        },
                        new
                        {
                            Id = 2,
                            address = "9 sur 11302,Sobre Periférico Ecológico",
                            city = "Puebla, Puebla",
                            storeName = "Periplaza"
                        },
                        new
                        {
                            Id = 3,
                            address = "Avenida Francisco Medina Ascencio 2920, Puerto Vallarta",
                            city = "Puerto Vallarta, Jal.",
                            storeName = "Galerias Puerto Vallarta"
                        },
                        new
                        {
                            Id = 4,
                            address = "Libramiento Monterrey",
                            city = "Reynosa, Tamaulipas",
                            storeName = "Plaza Periferico"
                        },
                        new
                        {
                            Id = 5,
                            address = "Avenida Lázaro Cárdenas Sn",
                            city = "Xalapa, Veracruz",
                            storeName = "Plaza Cristal"
                        });
                });

            modelBuilder.Entity("WarehouseModels.Models.WarehouseInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("WarehouseInfo");

                    b.HasData(
                        new
                        {
                            id = 1,
                            active = true,
                            code = "MWDC",
                            name = "Monterrey Warehouse Distrubution Center"
                        },
                        new
                        {
                            id = 2,
                            active = true,
                            code = "MXDC",
                            name = "Mexico Warehouse Distrubution Center"
                        },
                        new
                        {
                            id = 3,
                            active = true,
                            code = "GDDC",
                            name = "Guadalajara Warehouse Distrubution Center"
                        });
                });

            modelBuilder.Entity("ProductWarehouseInfo", b =>
                {
                    b.HasOne("WarehouseModels.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("productsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseModels.Models.WarehouseInfo", null)
                        .WithMany()
                        .HasForeignKey("warehouseInfoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WarehouseModels.Models.Product", b =>
                {
                    b.HasOne("WarehouseModels.Models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseModels.Models.Store", "store")
                        .WithMany("products")
                        .HasForeignKey("storeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("company");

                    b.Navigation("store");
                });

            modelBuilder.Entity("WarehouseModels.Models.Store", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
