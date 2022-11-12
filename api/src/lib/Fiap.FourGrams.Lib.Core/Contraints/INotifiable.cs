namespace Fiap.FourGrams.Lib.Core.Contraints;

public interface INotifiable<TEntity, TPrimaryKey> 
    where TEntity : IEntityBase<TPrimaryKey>
{
    public IReadOnlyCollection<Event> Events { get; }

    public void AddEvent(Event @event);

    public void RemoveEvent(Event @event);

    public void ClearEvents();
}

public interface INotifiable<TEntity> : INotifiable<TEntity, Guid> 
    where TEntity : IEntityBase<Guid>
{
}
