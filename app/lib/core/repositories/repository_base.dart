import '../models/_models.dart';

abstract class RepositoryBase<TEntityModel extends EntityModel, TPrimaryKey> {
  /// List all the entities of [TEntity].
  ///
  /// Gets a list of all the entities without pagination.
  Future<List<TEntityModel>> listAllAsync({required String path});

  /// Gets a entity of [TEntity] by [TPrimaryKey].
  ///
  /// Gets an entity with given primary key.
  Future<TEntityModel?> getAsync({required String path, required TPrimaryKey id});

  /// Insert a entity of [TEntity].
  ///
  /// Inserts a new entity.
  Future<void> insertAsync({required String path, required TEntityModel entity});

  /// Update a entity of [TEntity].
  ///
  /// Updates an existing entity
  Future<TEntityModel> updateAsync({required String path, required TEntityModel entity});

  /// Delete a entity of [TEntity] by [TPrimaryKey].
  ///
  /// Deletes an entity.
  Future<void> deleteAsync({required String path, required TPrimaryKey id});
}
