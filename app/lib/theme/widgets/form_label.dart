import 'package:flutter/material.dart';

class FHFormLabel extends StatelessWidget {
  final String label;
  final Color labelColor;

  const FHFormLabel({super.key, required this.label, required this.labelColor});

  @override
  Widget build(BuildContext context) {
    return Padding(padding: const EdgeInsets.only(bottom: 12.0), child: Text(label, style: TextStyle(color: labelColor)));
  }
}
