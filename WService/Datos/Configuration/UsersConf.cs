using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuration
{
    public class UsersConf : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Users>
    {
        public UsersConf()
            : this("dbo")
        {
        }

        public UsersConf(string schema)
        {
            ToTable("TBL_USUARIOS", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cedula).HasColumnName(@"CEDULA").IsOptional().HasColumnType("numeric");
            Property(x => x.Nombre).HasColumnName(@"NOMBRE").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Contrasena).HasColumnName(@"CONTRASENA").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(300);
            Property(x => x.Genero).HasColumnName(@"GENERO").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Correo).HasColumnName(@"CORREO").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.FechaNacimiento).HasColumnName(@"FECHA_NACIMIENTO").IsOptional().HasColumnType("date");
            Property(x => x.Telefono).HasColumnName(@"TELEFONO").IsOptional().HasColumnType("numeric");
            Property(x => x.FechaContrasena).HasColumnName(@"FECHA_CONTRASENA").IsOptional().HasColumnType("date");
            Property(x => x.Capacitado).HasColumnName(@"Capacitado").IsOptional().HasColumnType("bit");
            Property(x => x.IdLinea).HasColumnName(@"ID_LINEA").IsOptional().HasColumnType("int");
            
        }
    }
}
