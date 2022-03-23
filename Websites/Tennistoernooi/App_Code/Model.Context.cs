using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class TennistoernooiEntities : DbContext
{
    public TennistoernooiEntities()
        : base("name=TennistoernooiEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<AANMELDING> AANMELDINGs { get; set; }
    public virtual DbSet<SCHEIDSRECHTER> SCHEIDSRECHTERs { get; set; }
    public virtual DbSet<SCHOOL> SCHOOLs { get; set; }
    public virtual DbSet<SPELER> SPELERs { get; set; }
    public virtual DbSet<TOERNOOI> TOERNOOIs { get; set; }
    public virtual DbSet<WEDSTRIJD> WEDSTRIJDs { get; set; }
}
