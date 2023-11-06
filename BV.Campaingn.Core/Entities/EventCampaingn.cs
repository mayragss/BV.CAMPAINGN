
namespace BV.Campaingn.Domain.Entities;

public class EventCampaingn : BaseEntity
{ 
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
    public decimal Budget { get; set; }
    public bool IsActive { get; set; } // Deve ser substituída por uma tabela de status
   // public List<TargetAudience> TargetAudiences { get; set; } // Relacionamento com público-alvo
    public string Tags { get; set; } // Metadados
    public string ImageUrl { get; set; }  
}

