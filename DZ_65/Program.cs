using System;

class Program {
    static void Main(string[] args) {
        int M = 3;
        int N = 1;
        int sum = 0;

        // Если M > N, меняем их значения местами
        if (M > N) {
            int temp = M;
            M = N;
            N = temp;
        }

        // Вычисляем сумму натуральных чисел от M до N
        for (int i = M; i <= N; i++) {
            sum += i;
        }

        Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
    }
}
