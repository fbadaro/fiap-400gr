namespace Fiap.FourGrams.Lib.Core.Repositories;

public interface IUnitOfWork
{
    Task<bool> Commit();
}
