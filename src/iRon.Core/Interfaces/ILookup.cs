namespace iRon.Core.Interfaces
{
    public interface ILookup
    {
        string Name { get; set; }
        string Code { get; set; }
        string Description { get; set; }
        bool IsVisible { get; set; }
    }
}
