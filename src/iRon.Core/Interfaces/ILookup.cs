using System;

namespace iRon.Core.Interfaces
{
    interface ILookup<T,S> where T:struct where S:Enum
    {
        string Name { get; set; }
        string Code { get; set; }
        string Description { get; set; }
        bool IsVisible { get; set; }
    }
}
