using System;

namespace iRon.Core.Interfaces
{
    public interface IChild<T, S> where S : Enum where T : struct
    {
        T Parent { get; set; }
    }
}
