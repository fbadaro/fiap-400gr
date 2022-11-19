import 'package:equatable/equatable.dart';

abstract class EntityModelBase<TPrimaryKey> extends Equatable {
  late final TPrimaryKey id;
}
