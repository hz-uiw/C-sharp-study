﻿using System;
using static System.Console;

namespace Hello
{
    class MainApp
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(String[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법: Hello.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);
        }
    }
}