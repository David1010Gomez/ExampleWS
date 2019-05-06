using Datos.Configuration;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contexto
{
    using Configuration;
    using System.Linq;
public class Contexto : System.Data.Entity.DbContext, IContext
{
    public System.Data.Entity.DbSet<Users> Usuarios { get; set; } // TBL_USUARIOS


    static Contexto()
    {
        System.Data.Entity.Database.SetInitializer<Contexto>(null);

    }

    public Contexto()
        : base("Name=Context")
    {
        Configuration.ProxyCreationEnabled = false;
        Configuration.LazyLoadingEnabled = true;
        Configuration.ValidateOnSaveEnabled = false;
    }

    public Contexto(string connectionString)
        : base(connectionString)
    {
    }

    public Contexto(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
        : base(connectionString, model)
    {
    }

    public Contexto(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
        : base(existingConnection, contextOwnsConnection)
    {
    }

    public Contexto(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
        : base(existingConnection, model, contextOwnsConnection)
    {
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }

    public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
    {
        var sqlValue = param.SqlValue;
        var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
        if (nullableValue != null)
            return nullableValue.IsNull;
        return (sqlValue == null || sqlValue == System.DBNull.Value);
    }
    protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Configurations.Add(new UsersConf());
    }

    public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
    {
        modelBuilder.Configurations.Add(new UsersConf(schema));
        return modelBuilder;
    }
}
}
