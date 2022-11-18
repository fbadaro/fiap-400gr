class BusinessException implements Exception {
  final String? message;
  final Exception? innerException;
  final Object? object;

  const BusinessException({this.message, this.innerException, this.object});

  @override
  String toString() => message ?? 'An error has occurred. See: $object InnerException: $innerException';
}
