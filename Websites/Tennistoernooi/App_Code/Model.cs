using System;
using System.Collections.Generic;

public partial class AANMELDING
{
    public int Id { get; set; }
    public int Speler_Id { get; set; }
    public int Toernooi_Id { get; set; }

    public virtual SPELER SPELER { get; set; }
    public virtual TOERNOOI TOERNOOI { get; set; }
}

public partial class SCHEIDSRECHTER
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SCHEIDSRECHTER()
    {
        this.WEDSTRIJDs = new HashSet<WEDSTRIJD>();
    }

    public int Id { get; set; }
    public string Gebruikersnaam { get; set; }
    public string Wachtwoord { get; set; }
    public string Voornaam { get; set; }
    public string Tussenvoegsel { get; set; }
    public string Achternaam { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<WEDSTRIJD> WEDSTRIJDs { get; set; }
}

public partial class SCHOOL
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SCHOOL()
    {
        this.SPELERs = new HashSet<SPELER>();
    }

    public int Id { get; set; }
    public string School_Naam { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<SPELER> SPELERs { get; set; }
}

public partial class SPELER
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SPELER()
    {
        this.AANMELDINGs = new HashSet<AANMELDING>();
        this.WEDSTRIJDs = new HashSet<WEDSTRIJD>();
        this.WEDSTRIJDs1 = new HashSet<WEDSTRIJD>();
    }

    public int Id { get; set; }
    public string Speler_Voornaam { get; set; }
    public string Speler_Tussenvoegsel { get; set; }
    public string Speler_Achternaam { get; set; }
    public int School_Id { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AANMELDING> AANMELDINGs { get; set; }
    public virtual SCHOOL SCHOOL { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<WEDSTRIJD> WEDSTRIJDs { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<WEDSTRIJD> WEDSTRIJDs1 { get; set; }
}

public partial class TOERNOOI
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TOERNOOI()
    {
        this.AANMELDINGs = new HashSet<AANMELDING>();
        this.WEDSTRIJDs = new HashSet<WEDSTRIJD>();
    }

    public int Id { get; set; }
    public string Toernooi_Naam { get; set; }
    public System.DateTime Datum { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AANMELDING> AANMELDINGs { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<WEDSTRIJD> WEDSTRIJDs { get; set; }
}

public partial class WEDSTRIJD
{
    public int Id { get; set; }
    public int Toernooi_Id { get; set; }
    public int Ronde { get; set; }
    public int Speler1_Id { get; set; }
    public int Speler2_Id { get; set; }
    public int Score1 { get; set; }
    public int Score2 { get; set; }
    public int Winnaar_Id { get; set; }
    public string Veld { get; set; }
    public System.TimeSpan Begin_Tijd { get; set; }
    public System.TimeSpan Eind_Tijd { get; set; }
    public Nullable<int> Scheidsrechter_Id { get; set; }

    public virtual SCHEIDSRECHTER SCHEIDSRECHTER { get; set; }
    public virtual SPELER SPELER { get; set; }
    public virtual SPELER SPELER1 { get; set; }
    public virtual TOERNOOI TOERNOOI { get; set; }
}
