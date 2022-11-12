namespace Fiap.FourGrams.Lib.Core.Entities;

public abstract class EntityBase<TPrimaryKey> : IEntityBase<TPrimaryKey> 
    where TPrimaryKey : struct
{
    public TPrimaryKey Id { get; init; } = default!;

    public override bool Equals(object obj)
    {
        var compareTo = obj as EntityBase<TPrimaryKey>;

        if (ReferenceEquals(this, compareTo)) return true;
        if (ReferenceEquals(null, compareTo)) return false;

        return Id.Equals(compareTo.Id);
    }

    public static bool operator ==(EntityBase<TPrimaryKey> a, EntityBase<TPrimaryKey> b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            return true;

        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(EntityBase<TPrimaryKey> a, EntityBase<TPrimaryKey> b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return (GetType().GetHashCode() * 907) + Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"{GetType().Name} [Id={Id}]";
    }
}


public abstract class EntityBase : EntityBase<Guid>
{

}