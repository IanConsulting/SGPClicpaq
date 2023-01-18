using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SGPClicpaq.Shared.Models;

namespace SGPClicpaq.Server.Context
{
    public partial class CLPContext : DbContext
    {
        public CLPContext()
        {
        }

        public CLPContext(DbContextOptions<CLPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chofer> Chofers { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<DespTrazabilidad> DespTrazabilidads { get; set; } = null!;
        public virtual DbSet<Guium> Guia { get; set; } = null!;
        public virtual DbSet<Movil> Movils { get; set; } = null!;
        public virtual DbSet<Transporte> Transportes { get; set; } = null!;
        public virtual DbSet<Trazabilidad> Trazabilidads { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=192.168.0.12;user=consulta;password=consulta;database=CLP");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<Chofer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chofer");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("apellido")
                    .IsFixedLength();

                entity.Property(e => e.Codloca)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("codloca");

                entity.Property(e => e.Codpais)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("codpais");

                entity.Property(e => e.Codprov)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codprov")
                    .IsFixedLength();

                entity.Property(e => e.Cpostal)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("cpostal");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("direccion")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.Fechahora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechahora");

                entity.Property(e => e.Legajo)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("legajo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombre")
                    .IsFixedLength();

                entity.Property(e => e.Nrodoc)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("nrodoc");

                entity.Property(e => e.Observ)
                    .HasColumnType("text")
                    .HasColumnName("observ");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("telefono")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cliente");

                entity.Property(e => e.Acl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("acl")
                    .IsFixedLength();

                entity.Property(e => e.AclE)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("acl_e")
                    .IsFixedLength();

                entity.Property(e => e.Ccemp2)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ccemp2");

                entity.Property(e => e.Ccemp3)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ccemp3");

                entity.Property(e => e.Ccemp4)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ccemp4");

                entity.Property(e => e.Ccemp5)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ccemp5");

                entity.Property(e => e.Ccemp6)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ccemp6");

                entity.Property(e => e.Ccemp7)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ccemp7");

                entity.Property(e => e.Ccemp8)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ccemp8");

                entity.Property(e => e.Ccemp9)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ccemp9");

                entity.Property(e => e.Clave)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("clave")
                    .IsFixedLength();

                entity.Property(e => e.Cliape)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cliape")
                    .IsFixedLength();

                entity.Property(e => e.Clicat).HasColumnName("clicat");

                entity.Property(e => e.Clicod).HasColumnName("clicod");

                entity.Property(e => e.Clicta).HasColumnName("clicta");

                entity.Property(e => e.Clicuit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("clicuit")
                    .IsFixedLength();

                entity.Property(e => e.Clidesh)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("clidesh");

                entity.Property(e => e.ClidomF)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clidom_f")
                    .IsFixedLength();

                entity.Property(e => e.ClidomP)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("clidom_p")
                    .IsFixedLength();

                entity.Property(e => e.Clifax)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("clifax")
                    .IsFixedLength();

                entity.Property(e => e.Cliiva).HasColumnName("cliiva");

                entity.Property(e => e.Cliloc).HasColumnName("cliloc");

                entity.Property(e => e.ClimaiL)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("climai_l")
                    .IsFixedLength();

                entity.Property(e => e.ClimaiP)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("climai_p")
                    .IsFixedLength();

                entity.Property(e => e.Clinom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clinom")
                    .IsFixedLength();

                entity.Property(e => e.Cliobs)
                    .HasColumnType("text")
                    .HasColumnName("cliobs");

                entity.Property(e => e.Cliocu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cliocu")
                    .IsFixedLength();

                entity.Property(e => e.CliposF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clipos_f")
                    .IsFixedLength();

                entity.Property(e => e.CliposL)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clipos_l")
                    .IsFixedLength();

                entity.Property(e => e.CliposP)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clipos_p")
                    .IsFixedLength();

                entity.Property(e => e.Clisex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("clisex")
                    .IsFixedLength();

                entity.Property(e => e.ClitelP)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("clitel_p")
                    .IsFixedLength();

                entity.Property(e => e.CodLocF)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("cod_loc_f");

                entity.Property(e => e.Codclie)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("codclie");

                entity.Property(e => e.Codempr)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codempr")
                    .IsFixedLength();

                entity.Property(e => e.Codigoz)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codigoz")
                    .IsFixedLength();

                entity.Property(e => e.Codzong)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codzong")
                    .IsFixedLength();

                entity.Property(e => e.Comprob)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("comprob");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("contacto")
                    .IsFixedLength();

                entity.Property(e => e.Ctacte)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ctacte");

                entity.Property(e => e.DesExen)
                    .HasColumnType("datetime")
                    .HasColumnName("des_exen");

                entity.Property(e => e.Dir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dir")
                    .IsFixedLength();

                entity.Property(e => e.DirE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dir_e")
                    .IsFixedLength();

                entity.Property(e => e.Dom)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("dom");

                entity.Property(e => e.EDespa)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("e_despa");

                entity.Property(e => e.Empaque)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("empaque");

                entity.Property(e => e.Fechahora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechahora");

                entity.Property(e => e.Gencot)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("gencot");

                entity.Property(e => e.HasExen)
                    .HasColumnType("datetime")
                    .HasColumnName("has_exen");

                entity.Property(e => e.Hordes)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("hordes");

                entity.Property(e => e.Horhas)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("horhas");

                entity.Property(e => e.IgRto)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ig_rto");

                entity.Property(e => e.Jue)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("jue");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(10, 6)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(10, 6)")
                    .HasColumnName("lng");

                entity.Property(e => e.Lun)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("lun");

                entity.Property(e => e.Mar)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("mar");

                entity.Property(e => e.MedArba)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("med_arba");

                entity.Property(e => e.Mie)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("mie");

                entity.Property(e => e.Nomfan)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nomfan")
                    .IsFixedLength();

                entity.Property(e => e.Num)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("num");

                entity.Property(e => e.NumE)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("num_e");

                entity.Property(e => e.Pais)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("pais");

                entity.Property(e => e.Pedido)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("pedido");

                entity.Property(e => e.Periibb)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("periibb");

                entity.Property(e => e.ProArba)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("pro_arba")
                    .IsFixedLength();

                entity.Property(e => e.Provin)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("provin")
                    .IsFixedLength();

                entity.Property(e => e.Repcuit)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("repcuit");

                entity.Property(e => e.Reporte)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("reporte");

                entity.Property(e => e.Sab)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("sab");

                entity.Property(e => e.SegDes)
                    .HasColumnType("datetime")
                    .HasColumnName("seg_des");

                entity.Property(e => e.SegHas)
                    .HasColumnType("datetime")
                    .HasColumnName("seg_has");

                entity.Property(e => e.SegPol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("seg_pol")
                    .IsFixedLength();

                entity.Property(e => e.SegSin)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("seg_sin");

                entity.Property(e => e.Seguro)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("seguro")
                    .IsFixedLength();

                entity.Property(e => e.Transpo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("transpo");

                entity.Property(e => e.Usuario)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("usuario");

                entity.Property(e => e.Vencitar)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("vencitar");

                entity.Property(e => e.Vie)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("vie");
            });

            modelBuilder.Entity<DespTrazabilidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Desp_trazabilidad");

                entity.Property(e => e.Auto)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("auto");

                entity.Property(e => e.Codempr)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codempr")
                    .IsFixedLength();

                entity.Property(e => e.Codtraz)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("codtraz");

                entity.Property(e => e.Estado)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("estado");

                entity.Property(e => e.Fechahora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechahora");

                entity.Property(e => e.Guia)
                    .HasColumnType("numeric(9, 0)")
                    .HasColumnName("guia");

                entity.Property(e => e.Item)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("item");

                entity.Property(e => e.Observ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("observ")
                    .IsFixedLength();

                entity.Property(e => e.Trazacli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("trazacli")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Guium>(entity =>
            {
                entity.HasKey(e => e.Guia);

                entity.ToTable("guia");

                entity.Property(e => e.Guia)
                    .ValueGeneratedNever()
                    .HasColumnName("guia");

                entity.Property(e => e.AclD)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("acl_d")
                    .IsFixedLength();

                entity.Property(e => e.AclR)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("acl_r")
                    .IsFixedLength();

                entity.Property(e => e.Adicional)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("adicional");

                entity.Property(e => e.Aforado)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("aforado");

                entity.Property(e => e.AnuCob)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("anu_cob");

                entity.Property(e => e.Anula)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("anula");

                entity.Property(e => e.Bulto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("bulto");

                entity.Property(e => e.BultoT)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("bulto_t");

                entity.Property(e => e.Cae)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cae")
                    .IsFixedLength();

                entity.Property(e => e.Caevto)
                    .HasColumnType("datetime")
                    .HasColumnName("caevto");

                entity.Property(e => e.Canti)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("canti");

                entity.Property(e => e.CliD)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("cli_d");

                entity.Property(e => e.CliR)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("cli_r");

                entity.Property(e => e.Cobrado)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("cobrado");

                entity.Property(e => e.Cobranza)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("cobranza");

                entity.Property(e => e.Codclie)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("codclie");

                entity.Property(e => e.Codempr)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codempr")
                    .IsFixedLength();

                entity.Property(e => e.Codpres)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codpres")
                    .IsFixedLength();

                entity.Property(e => e.Codserv)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("codserv");

                entity.Property(e => e.Codtran)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codtran")
                    .IsFixedLength();

                entity.Property(e => e.CuiD)
                    .HasColumnType("numeric(11, 0)")
                    .HasColumnName("cui_d");

                entity.Property(e => e.CuiR)
                    .HasColumnType("numeric(11, 0)")
                    .HasColumnName("cui_r");

                entity.Property(e => e.DirD)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dir_d")
                    .IsFixedLength();

                entity.Property(e => e.DirR)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dir_r")
                    .IsFixedLength();

                entity.Property(e => e.DomD)
                    .HasMaxLength(110)
                    .IsUnicode(false)
                    .HasColumnName("dom_d")
                    .IsFixedLength();

                entity.Property(e => e.DomR)
                    .HasMaxLength(110)
                    .IsUnicode(false)
                    .HasColumnName("dom_r")
                    .IsFixedLength();

                entity.Property(e => e.EmailD)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email_d")
                    .IsFixedLength();

                entity.Property(e => e.EmailR)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email_r")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("estado");

                entity.Property(e => e.Facprove)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("facprove")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Factura)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("factura")
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fechahora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechahora");

                entity.Property(e => e.Gestion)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("gestion");

                entity.Property(e => e.Idsucursal).HasColumnName("idsucursal");

                entity.Property(e => e.Iva)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("iva");

                entity.Property(e => e.IvaD)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("iva_d");

                entity.Property(e => e.IvaR)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("iva_r");

                entity.Property(e => e.LocD)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("loc_d");

                entity.Property(e => e.LocR)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("loc_r");

                entity.Property(e => e.Magnitud)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("magnitud");

                entity.Property(e => e.NomD)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nom_d")
                    .IsFixedLength();

                entity.Property(e => e.NomR)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nom_r")
                    .IsFixedLength();

                entity.Property(e => e.NumD)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("num_d");

                entity.Property(e => e.NumR)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("num_r");

                entity.Property(e => e.Numfac)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("numfac");

                entity.Property(e => e.OblPre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("obl_pre")
                    .IsFixedLength();

                entity.Property(e => e.OblTra)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("obl_tra")
                    .IsFixedLength();

                entity.Property(e => e.Observ)
                    .HasColumnType("text")
                    .HasColumnName("observ");

                entity.Property(e => e.Perib)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("perib");

                entity.Property(e => e.Peso)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("peso");

                entity.Property(e => e.PesoT)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("peso_t");

                entity.Property(e => e.PosD)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("pos_d");

                entity.Property(e => e.PosR)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("pos_r");

                entity.Property(e => e.Rendrto)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("rendrto");

                entity.Property(e => e.Seguro)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("seguro");

                entity.Property(e => e.Subtot)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("subtot");

                entity.Property(e => e.Subtot1)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("subtot1");

                entity.Property(e => e.Sucfac)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("sucfac");

                entity.Property(e => e.TelD)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tel_d")
                    .IsFixedLength();

                entity.Property(e => e.TelR)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tel_r")
                    .IsFixedLength();

                entity.Property(e => e.Tipfac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipfac")
                    .IsFixedLength();

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.Trancos)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("trancos");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ubicacion")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("usuario");

                entity.Property(e => e.Valdec)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("valdec");

                entity.Property(e => e.Venta)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("venta");

                entity.Property(e => e.Volumen)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("volumen");

                entity.Property(e => e.VolumenT)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("volumen_t");

                entity.Property(e => e.Vtacli)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vtacli");

                entity.Property(e => e.ZonD)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("zon_d")
                    .IsFixedLength();

                entity.Property(e => e.ZonR)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("zon_r")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Movil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Movil");

                entity.Property(e => e.Año)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("año");

                entity.Property(e => e.Chasis)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("chasis")
                    .IsFixedLength();

                entity.Property(e => e.Codmovi)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("codmovi");

                entity.Property(e => e.Control)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("control");

                entity.Property(e => e.Dominio)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dominio")
                    .IsFixedLength();

                entity.Property(e => e.Fecalta)
                    .HasColumnType("datetime")
                    .HasColumnName("fecalta");

                entity.Property(e => e.Fechahora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechahora");

                entity.Property(e => e.Marca)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("marca")
                    .IsFixedLength();

                entity.Property(e => e.Modelo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("modelo")
                    .IsFixedLength();

                entity.Property(e => e.Motor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("motor")
                    .IsFixedLength();

                entity.Property(e => e.Observ)
                    .HasColumnType("text")
                    .HasColumnName("observ");

                entity.Property(e => e.Sinuso)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("sinuso");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tipo")
                    .IsFixedLength();

                entity.Property(e => e.Titular)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("titular")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("usuario");

                entity.Property(e => e.Venci)
                    .HasColumnType("datetime")
                    .HasColumnName("venci");
            });

            modelBuilder.Entity<Transporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("transporte");

                entity.Property(e => e.Canbul)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("canbul");

                entity.Property(e => e.Cobranza)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("cobranza");

                entity.Property(e => e.Codloca)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("codloca");

                entity.Property(e => e.Codpais)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("codpais");

                entity.Property(e => e.Codprov)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codprov")
                    .IsFixedLength();

                entity.Property(e => e.Codtran)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codtran")
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("contacto")
                    .IsFixedLength();

                entity.Property(e => e.Cpostal)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("cpostal");

                entity.Property(e => e.Ctacte)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ctacte")
                    .IsFixedLength();

                entity.Property(e => e.Cuit)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cuit")
                    .IsFixedLength();

                entity.Property(e => e.Descrip)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descrip")
                    .IsFixedLength();

                entity.Property(e => e.Descweb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descweb")
                    .IsFixedLength();

                entity.Property(e => e.Despa)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("despa");

                entity.Property(e => e.Despacha)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("despacha");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("direccion")
                    .IsFixedLength();

                entity.Property(e => e.Domguia)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("domguia");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.EmiEti)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("emi_eti");

                entity.Property(e => e.Fechahora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechahora");

                entity.Property(e => e.GuiaHr)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("guia_hr");

                entity.Property(e => e.Horario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("horario")
                    .IsFixedLength();

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(10, 6)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(10, 6)")
                    .HasColumnName("lng");

                entity.Property(e => e.MaxPes)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("max_pes");

                entity.Property(e => e.MaxVol)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("max_vol");

                entity.Property(e => e.MinPes)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("min_pes");

                entity.Property(e => e.MinVol)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("min_vol");

                entity.Property(e => e.MultPes)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("mult_pes")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MultVol)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("mult_vol")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Noconso)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("noconso");

                entity.Property(e => e.ObDes)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ob_des");

                entity.Property(e => e.ObFc)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ob_fc");

                entity.Property(e => e.Observ)
                    .HasColumnType("text")
                    .HasColumnName("observ");

                entity.Property(e => e.Prioridad)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("prioridad");

                entity.Property(e => e.ReqRc)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("req_rc");

                entity.Property(e => e.Reqcomp)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("reqcomp");

                entity.Property(e => e.RetCen)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("ret_cen");

                entity.Property(e => e.Seguimiento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("seguimiento")
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("telefono")
                    .IsFixedLength();

                entity.Property(e => e.Tipiva)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tipiva");

                entity.Property(e => e.Transoft)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("transoft");

                entity.Property(e => e.Trazaauto)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("trazaauto");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ubicacion")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("usuario");

                entity.Property(e => e.Web)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("web")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Trazabilidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Trazabilidad");

                entity.Property(e => e.Actua)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("actua");

                entity.Property(e => e.Auto)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("auto");

                entity.Property(e => e.Codtraz)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("codtraz");

                entity.Property(e => e.Color)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("color");

                entity.Property(e => e.Descrip)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descrip")
                    .IsFixedLength();

                entity.Property(e => e.Descweb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descweb")
                    .IsFixedLength();

                entity.Property(e => e.Desp)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("desp");

                entity.Property(e => e.Envi)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("envi");

                entity.Property(e => e.Fechahora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechahora");

                entity.Property(e => e.Fin)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("fin");

                entity.Property(e => e.Hrut)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("hrut");

                entity.Property(e => e.Observ)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("observ");

                entity.Property(e => e.Quad)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("quad");

                entity.Property(e => e.Rcob)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("rcob");

                entity.Property(e => e.Rece)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("rece");

                entity.Property(e => e.Rrto)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("rrto");

                entity.Property(e => e.Trazaact)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("trazaact");

                entity.Property(e => e.Usuario)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("usuario");

                entity.Property(e => e.Web)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("web");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
