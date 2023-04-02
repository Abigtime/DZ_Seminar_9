using System;

class MainClass {
  static void Main () {
    int m = 2, n = 3; // Пример 1: m = 2, n = 3 -> A(m,n) = 9
    Console.WriteLine("A(" + m + "," + n + ") = " + Ackermann(m, n));

    m = 3; n = 2; // Пример 2: m = 3, n = 2 -> A(m,n) = 29
    Console.WriteLine("A(" + m + "," + n + ") = " + Ackermann(m, n));
  }

  static int Ackermann(int m, int n) {
    return (m == 0) ? (n + 1) : ((n == 0) ? Ackermann(m - 1, 1) : Ackermann(m - 1, Ackermann(m, n - 1)));
  }
}

