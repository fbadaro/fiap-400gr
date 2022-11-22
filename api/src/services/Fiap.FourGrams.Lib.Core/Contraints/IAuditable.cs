namespace Fiap.FourGrams.Lib.Core.Contraints;

public interface IAuditable<TEntity, TPrimaryKey> 
    where TEntity : IEntityBase<TPrimaryKey>
{
    string CreatedBy { get; set; }

    DateTime? CreatedOn { get; set; }

    string UpdatedBy { get; set; }

    DateTime? UpdatedOn { get; set; }
}

public interface IAuditable<TEntity> : IAuditable<TEntity, Guid> 
    where TEntity : IEntityBase<Guid>
{
}