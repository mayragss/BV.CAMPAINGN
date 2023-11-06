
namespace BV.Campaingn.Domain.Entities;

public class TargetAudience : BaseEntity
{
    public int AudienceId { get; set; } // ID exclusivo do público-alvo
    public string Name { get; set; } // Nome ou descrição do público-alvo
    public int AgeRangeMin { get; set; } // Idade mínima do público-alvo
    public int AgeRangeMax { get; set; } // Idade máxima do público-alvo
    public string Gender { get; set; } // Gênero do público-alvo
    public string Interests { get; set; } // Interesses do público-alvo
                                          // Outros campos relevantes
}
