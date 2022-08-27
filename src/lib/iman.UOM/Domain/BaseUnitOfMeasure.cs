namespace iman.UOM.Domain;

public class BaseUnitOfMeasure : IUnitOfMeasure
{

    protected BaseUnitOfMeasure(string title, string slug, string symbol, string description = "")
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentNullException(nameof(title));
        
        Title = title;
        Slug = slug;
        Symbol = symbol;
        Description = description;
    }
    
    public Guid Id { get; protected set; }

    public string Title { get; protected set; }

    public string Slug { get; protected set; }

    public string Symbol { get; protected set; }

    public UnitDimension Dimension { get; protected set; }
    
    public string Description { get; protected set; }
}