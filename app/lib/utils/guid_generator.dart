import 'dart:math' as math;

class Guid {
  Guid._();

  static String generate() {
    const String hexDigits = "0123456789abcdef";

    var random = math.Random(DateTime.now().millisecond);
    var uuid = List<String>.filled(36, '');

    for (int i = 0; i < 36; i++) {
      var hexPos = random.nextInt(16);
      uuid[i] = (hexDigits.substring(hexPos, hexPos + 1));
    }

    var pos = (int.parse(uuid[19], radix: 16) & 0x3) | 0x8;

    uuid[14] = "4";
    uuid[19] = hexDigits.substring(pos, pos + 1);
    uuid[8] = uuid[13] = uuid[18] = uuid[23] = "-";

    final StringBuffer buffer = StringBuffer();
    buffer.writeAll(uuid);
    return buffer.toString();
  }
}
