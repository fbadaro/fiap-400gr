import '../models/_models.dart';
import '_repositories.dart';

abstract class RepositoryLocal<TEntityModel extends EntityModel, TPrimaryKey> extends RepositoryBase<TEntityModel, TPrimaryKey> {}
