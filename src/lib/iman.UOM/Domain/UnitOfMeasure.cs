namespace iman.UOM.Domain;

public class UnitOfMeasure : BaseUnitOfMeasure, IUnitOfMeasure
{
    protected UnitOfMeasure(string title, string slug, string symbol, string description = "")
        : base(title, slug, symbol, description)
    {
    }
    
    
}