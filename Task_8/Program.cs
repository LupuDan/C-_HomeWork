﻿using System;

class Program {
    static void Main() {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Четные числа от 1 до N: ");
        for (int i = 1; i <= n; i++) {
            if (i % 2 == 0) {
                Console.Write(i + " ");
            }
        }
    }
}

