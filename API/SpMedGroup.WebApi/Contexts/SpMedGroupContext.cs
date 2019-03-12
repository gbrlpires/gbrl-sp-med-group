using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpMedGroup.WebApi.Domains
{
    public partial class SpMedGroupContext : DbContext
    {
        public SpMedGroupContext()
        {
        }

        public SpMedGroupContext(DbContextOptions<SpMedGroupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinicas> Clinicas { get; set; }
        public virtual DbSet<Consultas> Consultas { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<Prontuarios> Prontuarios { get; set; }
        public virtual DbSet<StatusConsultas> StatusConsultas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosTipos> UsuariosTipos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = .\\SqlExpress; Initial Catalog= SPMEDGROUP_MANHA_LITE; User=sa; Pwd=132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinicas>(entity =>
            {
                entity.HasKey(e => e.ClinicaId);

                entity.ToTable("CLINICAS");

                entity.HasIndex(e => e.Cnpj)
                    .HasName("UQ__CLINICAS__AA57D6B4C6D9D713")
                    .IsUnique();

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("CEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Consultas>(entity =>
            {
                entity.HasKey(e => e.ConsultaId);

                entity.ToTable("CONSULTAS");

                entity.Property(e => e.DataConsulta).HasColumnType("date");

                entity.Property(e => e.ObservacoesConsulta).HasColumnType("text");

                entity.HasOne(d => d.IdConsultaMedicoNavigation)
                    .WithMany(p => p.Consultas)
                    .HasForeignKey(d => d.IdConsultaMedico)
                    .HasConstraintName("FK__CONSULTAS__IdCon__656C112C");

                entity.HasOne(d => d.IdConsultaPacienteNavigation)
                    .WithMany(p => p.Consultas)
                    .HasForeignKey(d => d.IdConsultaPaciente)
                    .HasConstraintName("FK__CONSULTAS__IdCon__66603565");

                entity.HasOne(d => d.IdConsultaStatusNavigation)
                    .WithMany(p => p.Consultas)
                    .HasForeignKey(d => d.IdConsultaStatus)
                    .HasConstraintName("FK__CONSULTAS__IdCon__6754599E");
            });

            modelBuilder.Entity<Especialidades>(entity =>
            {
                entity.HasKey(e => e.EspecialidadeId);

                entity.ToTable("ESPECIALIDADES");

                entity.HasIndex(e => e.EspecialidadeNome)
                    .HasName("UQ__ESPECIAL__AAEE4012F2165D8D")
                    .IsUnique();

                entity.Property(e => e.EspecialidadeNome)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.HasKey(e => e.MedicoId);

                entity.ToTable("MEDICOS");

                entity.HasIndex(e => e.Crm)
                    .HasName("UQ__MEDICOS__C1F887FF3C62B410")
                    .IsUnique();

                entity.Property(e => e.Crm)
                    .IsRequired()
                    .HasColumnName("CRM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MedicoNome)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMedicoEspecialidadeNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdMedicoEspecialidade)
                    .HasConstraintName("FK__MEDICOS__IdMedic__5AEE82B9");

                entity.HasOne(d => d.IdMedicoUsuarioNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdMedicoUsuario)
                    .HasConstraintName("FK__MEDICOS__IdMedic__59FA5E80");
            });

            modelBuilder.Entity<Pacientes>(entity =>
            {
                entity.HasKey(e => e.PacienteId);

                entity.ToTable("PACIENTES");

                entity.HasIndex(e => e.Cpf)
                    .HasName("UQ__PACIENTE__C1F89731AC23F8F7")
                    .IsUnique();

                entity.HasIndex(e => e.Rg)
                    .HasName("UQ__PACIENTE__321537C8F3625699")
                    .IsUnique();

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("CEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PacienteNome)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("RG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPacienteProntuarioNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdPacienteProntuario)
                    .HasConstraintName("FK__PACIENTES__IdPac__628FA481");

                entity.HasOne(d => d.IdPacienteUsuarioNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdPacienteUsuario)
                    .HasConstraintName("FK__PACIENTES__IdPac__619B8048");
            });

            modelBuilder.Entity<Prontuarios>(entity =>
            {
                entity.HasKey(e => e.ProntuarioId);

                entity.ToTable("PRONTUARIOS");

                entity.Property(e => e.Altura)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacoesProntuario).HasColumnType("text");

                entity.Property(e => e.PesoAtual)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusConsultas>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("STATUS_CONSULTAS");

                entity.HasIndex(e => e.StatusTipo)
                    .HasName("UQ__STATUS_C__AE8F45A233790390")
                    .IsUnique();

                entity.Property(e => e.StatusTipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.UsuarioId);

                entity.ToTable("USUARIOS");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIOS__A9D10534EA736A8A")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuariosTiposNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdUsuariosTipos)
                    .HasConstraintName("FK__USUARIOS__IdUsua__5629CD9C");
            });

            modelBuilder.Entity<UsuariosTipos>(entity =>
            {
                entity.HasKey(e => e.UsuarioTipoId);

                entity.ToTable("USUARIOS_TIPOS");

                entity.HasIndex(e => e.UsuarioTipo)
                    .HasName("UQ__USUARIOS__5A83C59DDBFA08BC")
                    .IsUnique();

                entity.Property(e => e.UsuarioTipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
