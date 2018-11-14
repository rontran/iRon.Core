using iRon.Core.Enums;
using System;

namespace iRon.Core.Interfaces
{
    public interface IEntity<IDType> where IDType:struct
    {
        string Id { get; set; }
        string Tag { get; set; }
        DateTimeOffset? CreatedDate { get; set; }
        DateTimeOffset? UpdatedDate { get; set; }
        IDType UpdatedById { get; set; }
        IDType CreatedById { get; set; }
        bool isNew { get; }
        bool isDirty { get; }
        string LegacyId { get; set; }
        ObjectStatusEnum ObjectStatus { get; set; }

    }
}
