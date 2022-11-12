namespace Fiap.FourGrams.Lib.Core.Contraints;

public interface IDeletable<TEntity, TPrimaryKey> 
    where TEntity : IEntityBase<TPrimaryKey>
{
    string DeletedBy { get; set; }

    DateTime? DeletedOn { get; set; }

    bool isDeleted { get; set; }
}

public interface IDeletable<TEntity> : IDeletable<TEntity, Guid> 
    where TEntity : IEntityBase<Guid>
{
}