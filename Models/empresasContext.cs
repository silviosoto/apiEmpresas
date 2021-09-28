using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiEmpresa.Models
{
    public partial class empresasContext : DbContext
    {
        public empresasContext()
        {
        }

        public empresasContext(DbContextOptions<empresasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-LH88N10;Initial Catalog=empresas; Integrated Security=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.ToTable("municipio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnvioMensajes).HasColumnName("envio_mensajes");

                entity.Property(e => e.IdMunicipio).HasColumnName("id_municipio");

                entity.Property(e => e.Letra)
                    .HasColumnName("letra")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCompania)
                    .HasColumnName("nombre_compania")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Numero2).HasColumnName("numero_2");

                entity.Property(e => e.NumeroComplemento)
                    .HasColumnName("numero_complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion).HasColumnName("numero_identificacion");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion)
                    .HasColumnName("tipo_identificacion")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Via)
                    .HasColumnName("via")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_persona_municipio_");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
