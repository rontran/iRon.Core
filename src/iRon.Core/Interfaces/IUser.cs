using System;

namespace iRon.Core.Interfaces
{
    public interface IUser<UserStatusEnum> where UserStatusEnum : Enum
    {
        string Name { get; set; }
        string Password { get; set; }
        UserStatusEnum UserStatus { get; set; }
    }
}
