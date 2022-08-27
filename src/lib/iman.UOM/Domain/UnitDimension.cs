using System;

namespace iman.UOM.Domain;

public class UnitDimension
{

    protected UnitDimension(string title, string slug, string symbol, string description = "")
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentNullException(nameof(title));

        Title = title.Trim();
        Slug = slug.Trim();
        Symbol = symbol.Trim();
        Description = description;
    }
    
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Slug { get; private set; }
    public string Symbol { get; private set; }
    public string Description { get; private set; }

    public static UnitDimension Create(
        string title, string slug, 
        string symbol, string description = "") 
            => new UnitDimension(title, slug, symbol, description);
}