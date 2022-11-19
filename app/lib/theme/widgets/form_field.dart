import 'package:flutter/material.dart';

class FHFormField extends StatelessWidget {
  final String label;
  final bool obscureText;
  final String obscureCharacter;

  const FHFormField({
    super.key,
    required this.label,
    this.obscureText = false,
    this.obscureCharacter = '*',
  });

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      obscureText: obscureText,
      obscuringCharacter: obscureCharacter,
      decoration: InputDecoration(
        border: const UnderlineInputBorder(),
        labelText: label,
      ),
    );
  }
}
