using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("PaidMember")]
public class PaidMember : BaseModel
{

    public bool Paid { get; set; }

    [Column("email")]
    public string email { get; set; }

    [Column("UID")]
    public string UID { get; set; }
}