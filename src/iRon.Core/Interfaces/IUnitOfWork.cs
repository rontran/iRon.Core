namespace iRon.Core.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();
        bool IsInTransaction();
    }
}
