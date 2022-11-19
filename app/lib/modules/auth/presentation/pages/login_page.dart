import 'package:flutter/material.dart';

import '../../../../theme/_theme.dart';

class LoginPage extends StatefulWidget {
  static String routeName = '/';

  const LoginPage({Key? key}) : super(key: key);

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
  }

  @override
  void dispose() {
    // TODO: implement dispose
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: SingleChildScrollView(
          child: Padding(
            padding: const EdgeInsets.only(left: 32.0, top: 64.0, right: 32.0, bottom: 0),
            child: SizedBox(
              width: double.infinity,
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Image.asset('lib/assets/images/ic_launch_image.png', width: 225, alignment: Alignment.center),
                  const FHSpacer(spacer: 4),
                  const FHFormField(label: 'email'),
                  const FHSpacer(spacer: 4),
                  const FHFormField(label: 'senha', obscureText: true, obscureCharacter: '*'),
                  const FHSpacer(spacer: 8),
                  const FHButton()
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}

class FHButton extends StatelessWidget {
  const FHButton({super.key});

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      width: double.infinity,
      child: ElevatedButton(
        onPressed: () => {},
        style: ButtonStyle(
          padding: MaterialStateProperty.resolveWith(
            (states) => const EdgeInsets.symmetric(vertical: 24.0, horizontal: 0),
          ),
          backgroundColor: MaterialStateColor.resolveWith(
            (states) => greenMain,
          ),
        ),
        child: const Text(
          'ENTRAR',
          style: TextStyle(color: Colors.white, fontSize: 16.0),
        ),
      ),
    );
  }
}
