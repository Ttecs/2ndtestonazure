using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dec3webmobile.Models
{
    public partial class MobileBravoContext : DbContext
    {
        public MobileBravoContext()
        {
        }

        public MobileBravoContext(DbContextOptions<MobileBravoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Eventreservation> Eventreservation { get; set; }
        public virtual DbSet<Guiderservation> Guiderservation { get; set; }
        public virtual DbSet<Hotelreservation> Hotelreservation { get; set; }
        public virtual DbSet<Transportproviderreservation> Transportproviderreservation { get; set; }
        public virtual DbSet<UserDetail> UserDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-OTAH8L6F;Database=MobileBravo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eventreservation>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__eventres__B14BF5C53B804AB8");

                entity.ToTable("eventreservation");

                entity.Property(e => e.ReservationId)
                    .HasColumnName("reservationId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInDate)
                    .HasColumnName("check_in_date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnName("check_out_date")
                    .HasColumnType("date");

                entity.Property(e => e.Eventtype)
                    .HasColumnName("eventtype")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UId")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Guiderservation>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__guiderse__B14BF5C5292289B7");

                entity.ToTable("guiderservation");

                entity.Property(e => e.ReservationId)
                    .HasColumnName("reservationId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInDate)
                    .HasColumnName("check_in_date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnName("check_out_date")
                    .HasColumnType("date");

                entity.Property(e => e.GuideName)
                    .HasColumnName("guide_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Guideimage)
                    .HasColumnName("guideimage")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UId")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hotelreservation>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__hotelres__B14BF5C567BB403B");

                entity.ToTable("hotelreservation");

                entity.Property(e => e.ReservationId)
                    .HasColumnName("reservationId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInDate)
                    .HasColumnName("check_in_date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnName("check_out_date")
                    .HasColumnType("date");

                entity.Property(e => e.HotelName)
                    .HasColumnName("Hotel_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfRooms).HasColumnName("no_of_rooms");

                entity.Property(e => e.NoOfTravellers).HasColumnName("no_of_travellers");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.RoomType)
                    .HasColumnName("room_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UId")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transportproviderreservation>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__transpor__B14BF5C5E5B5BE68");

                entity.ToTable("transportproviderreservation");

                entity.Property(e => e.ReservationId)
                    .HasColumnName("reservationId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInDate)
                    .HasColumnName("check_in_date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnName("check_out_date")
                    .HasColumnType("date");

                entity.Property(e => e.DropOffLocation)
                    .HasColumnName("drop_off_location")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumOfTravellers).HasColumnName("num_of_travellers");

                entity.Property(e => e.PickupLocation)
                    .HasColumnName("pickup_location")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PickupTime).HasColumnName("Pickup_time");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleType)
                    .HasColumnName("vehicle_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__UserDeta__C5B1966205EFCDEB");

                entity.Property(e => e.Uid)
                    .HasColumnName("UId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Adress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passsword)
                    .IsRequired()
                    .HasColumnName("passsword")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Userurl)
                    .HasColumnName("userurl")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
