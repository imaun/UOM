namespace iman.UOM.Domain;

public class BaseUnitOfMeasure : IUnitOfMeasure
{

    public Guid Id { get; protected set; }

    public string Title { get; protected set; }

    public string Slug { get; protected set; }

    public string Symbol { get; protected set; }

    public UnitDimension Dimension { get; protected set; }
}