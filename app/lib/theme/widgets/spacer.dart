import 'package:flutter/material.dart';

/// An widget that provide space between elements

class FHSpacer extends StatelessWidget {
  final int spacer;

  const FHSpacer({required this.spacer, super.key}) : assert(spacer >= 0 && spacer <= 8);

  @override
  Widget build(BuildContext context) {
    return SizedBox(height: spacer * 8.0);
  }
}
