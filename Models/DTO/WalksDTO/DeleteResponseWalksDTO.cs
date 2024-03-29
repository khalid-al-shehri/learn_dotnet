
namespace NZwalker.Models.Domain;

public class DeleteResponseWalksDTO{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public string? WalkImageUrl { get; set; }

    public Guid? DifficultyId { get; set; }
    public Guid? RegionId { get; set; }

}