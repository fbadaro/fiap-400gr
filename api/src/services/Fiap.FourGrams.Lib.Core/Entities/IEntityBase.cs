namespace Fiap.FourGrams.Lib.Core.Entities;

public interface IEntityBase<TPrimaryKey>
{
    TPrimaryKey Id { get; init; }
}
