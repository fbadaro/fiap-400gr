import '../models/_models.dart';
import '_repositories.dart';

abstract class RepositoryRemote<TEntityModel extends EntityModel, TPrimaryKey> extends RepositoryBase<TEntityModel, TPrimaryKey> {}
