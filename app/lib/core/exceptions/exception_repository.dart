class RepositoryException implements Exception {
  final String? message;
  final Exception? innerException;
  final Object? object;

  const RepositoryException({this.message, this.innerException, this.object});

  @override
  String toString() => message ?? 'The connection with remote client returned with errors. See: $object InnerException: $innerException';
}
