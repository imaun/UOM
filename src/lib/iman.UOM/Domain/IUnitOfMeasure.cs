namespace iman.UOM.Domain;

public interface IUnitOfMeasure
{
    
    Guid Id { get; }
    string Title { get; }
    string Slug { get; }
    string Symbol { get; }
    UnitDimension Dimension { get; }
}