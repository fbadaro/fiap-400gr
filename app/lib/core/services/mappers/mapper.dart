import '../../entities/_entities.dart';
import '../../models/_models.dart';

abstract class Mapper<TEntity extends Entity, TEntityModel extends EntityModel> {
  TEntityModel to(TEntity entity);
  TEntity from(TEntityModel entityModel);
}
