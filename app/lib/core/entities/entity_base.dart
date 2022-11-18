import 'package:equatable/equatable.dart';

abstract class EntityBase<TPrimaryKey> extends Equatable {
  late final TPrimaryKey id;
}
