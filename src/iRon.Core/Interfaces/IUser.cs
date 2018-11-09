using System;

namespace iRon.Core.Interfaces
{
    public interface IUser<T> where T : Enum
    {
        string Name { get; set; }
        string Password { get; set; }
        T UserStatus { get; set; }
    }
}
