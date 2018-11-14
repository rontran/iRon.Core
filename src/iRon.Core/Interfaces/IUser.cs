using System;

namespace iRon.Core.Interfaces
{
    public interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        int Status { get; set; }
    }
}
