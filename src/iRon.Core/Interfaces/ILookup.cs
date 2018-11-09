namespace iRon.Core.Interfaces
{
    interface ILookup
    {
        string Name { get; set; }
        string Code { get; set; }
        string Description { get; set; }
        bool IsVisible { get; set; }
    }
}
