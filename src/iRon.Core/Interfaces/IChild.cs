namespace iRon.Core.Interfaces
{
    public interface IChild<ParentType> where ParentType : struct
    {
        ParentType Parent { get; set; }
    }
}
