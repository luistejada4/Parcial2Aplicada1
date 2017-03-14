namespace Parcial2Aplicada1.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Parcial2DB : DbContext
    {
        public DbSet<Entidades.Empleado> Empleados { get; set; }
        public DbSet<Entidades.EmpleadoEmail> EmpleadosEmails { get; set; }
        public DbSet<Entidades.EmpleadoRetencion> EmpleadosRetenciones { get; set; }
        public DbSet<Entidades.Retencion> Retenciones { get; set; }
        public DbSet<Entidades.TipoEmail> TiposEmails { get; set; }

        public Parcial2DB() : base("ConStr")
        {
        }
    }
}
