//// IntegralTypes
//using System;

//namespace Integral
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            sbyte a = -10;
//            byte b = 40;

//            Console.WriteLine($"a={a}, b={b}");

//            short c = -30000;
//            ushort d = 60000;

//            Console.WriteLine($"c={c}, d={d}");

//            int e = -1000_0000;
//            uint f = 3_0000_0000;
//            // 큰 자릿수의 정수 리터럴을 타이핑할 때 자릿수 구분자 언더바(_)를 이용하면 됨
//            Console.WriteLine($"e={e}, f={f}");

//            long g = -5000_0000_0000;
//            ulong h = 200_0000_0000_0000_0000;

//            Console.WriteLine($"g={g}, h={h}");
//        }
//    }
//}

//// Integral Literals
//using System;
//using System.Formats.Asn1;

//namespace IntegralLiterals
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            byte a = 240;
//            Console.WriteLine($"a={a}");

//            byte b = 0b1111_0000;
//            Console.WriteLine($"b={b}");

//            byte c = 0XF0;
//            Console.WriteLine($"c={c}");

//            uint d = 0x1234_abcd;
//            Console.WriteLine($"d={d}");

//        }
//    }
//}

//// SignedUnsigned
//using System;

//namespace SignedUnsigned
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            // 이진수 1111 1111을 2의 보수법이냐 2진수냐는 데이터 타입으로 결정됨
//            byte a = 255;   // 부호가 없는 데이터 타입 -> 255
//            sbyte b = (sbyte)a; // 부호가 있는 데이터 타입 -> -1

//            Console.WriteLine(a);
//            Console.WriteLine(b);
//        }
//    }
//}

//// Overflow
//using System;

//namespace Overflow
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            uint a = uint.MaxValue;
//            Console.WriteLine(a);

//            a = a + 1;
//            Console.WriteLine(a);
//        }
//    }
//}

//// FloatingPoint
//using System;

//namespace FloatingPoint
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            float a = 3.1415_9265_3589_7932_3846f; // float 타입의 변수에 직접 할당을 위해 숫자 뒤에 f를 붙임
//            Console.WriteLine(a); // 3.1415927
//            // 7자릿수까지 표현 그외 나머지는 버림

//            double b = 3.1415_9265_3589_7932_3846;
//            Console.WriteLine(b); // 3.141592653589793
//            // 15~16 자릿수까지 표현 그외 나머지는 버림
//            // 데이터 손실 우려로 float보다는 double 사용 권장
//            // double을 넘는 경우나 데이터의 손실 우려가 있다면 decimal 사용
//        }
//    }
//}

//// Decimal
//using System;

//namespace Deciaml
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f; // 숫자 뒤에 f를 붙이면 float
//            double b = 3.1415_9265_3589_7932_3846_2643_3832_79; // 숫자 뒤에 아무것도 없으면 double
//            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;   // 숫자 뒤에 m을 붙이면 decimal

//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);
//        }
//    }
//}


//// 문자 char, 문자열 string
//using System;

//namespace CharString
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            // 문자
//            char a = '안';
//            char b = '녕';
//            char c = '하';
//            char d = '세';
//            char e = '요';

//            Console.Write(a);
//            Console.Write(b);
//            Console.Write(c);
//            Console.Write(d);
//            Console.Write(e);
//            Console.WriteLine();
//            Console.WriteLine();

//            // 문자열
//            string f = "안녕하세요?";
//            string g = "권민창입니다!";

//            Console.WriteLine(f);
//            Console.WriteLine(g);
//        }
//    }
//}

//// MultiLine
//using System;

//namespace MultiLine
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string multiline = """
//                검푸른 복장 삼킬듯 사나워도
//                나는야 언제나 독사같은 사나이
//                막걸리 생각날 때 흙탕물을 마시고
//                사랑이 그리울 땐 일만이만 헤아린다
//                사나이 한 목숨 창공에다 벗을 삼고
//                굳세게 살다가 명예롭게 죽으리라
//                창공은 나의 고향 창공은 낙원이란다
//                """;

//            Console.WriteLine(multiline);
//        }
//    }
//}

//// 논리 타입 boolean
//using System;

//namespace Bool
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            bool a = true;
//            bool b = false;

//            Console.WriteLine(a);
//            Console.WriteLine(b);
//        }
//    }
//}

//// Object
//using System;

//namespace Object
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            object a = 123;
//            object b = 3.1415926653589793238462643383279m;
//            object c = true;
//            object d = "안녕하세요";

//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);
//            Console.WriteLine(d);
//        }
//    }
//}

//// Boxing, Unboxing
//using System;

//namespace BoxingUnboxing
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int a = 123;
//            object b = (object)a;
//            int c = (int)b;

//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);

//            double x = 3.1414213;
//            object y = (object)x;
//            double z = (double)y;

//            Console.WriteLine(x);
//            Console.WriteLine(y);
//            Console.WriteLine(z);
//        }
//    }
//}

//// IntegralConversion
//using System;

//namespace IntegralConversion
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            sbyte a = 127;
//            Console.WriteLine(a);

//            int b = (int)a;
//            Console.WriteLine(b);

//            int x = 128; // sbyte의 최댓값 127보다 1 큰 수
//            Console.WriteLine(x);

//            sbyte y = (sbyte)x;       // 오버플로 발생
//            Console.WriteLine(y);
//        }
//    }
//}

//// FloatConversion
//using System;

//namespace FloatConversion
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            float a = 69.6875f;
//            Console.WriteLine("a: {0}", a);

//            double b = (double)a;
//            Console.WriteLine("b: {0}", b);

//            Console.WriteLine("69.6875 == b: {0}", 69.6875 == b);

//            float x = 0.1f;
//            Console.WriteLine("x: {0}", x);

//            double y = (double)x;
//            Console.WriteLine("y: {0}", y);

//            Console.WriteLine("0.1 == y: {0}", 0.1 == y);
//        }
//    }
//}

//// SignedUnsignedConversion
//using System;

//namespace SignedUnsignedConversion
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int a = 500;
//            Console.WriteLine(a);

//            uint b = (uint)a;
//            Console.WriteLine(b);

//            int x = -30;
//            Console.WriteLine(x);

//            uint y = (uint)x;   // 언더플로 발생
//            Console.WriteLine(y);
//        }
//    }
//}

//// FloatToIntegral
//using System;

//namespace FloatToIntegral
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            // 부동 소수점 -> 정수는 소수점 위의 값만 남기고 소수점 뒤로는 버림
//            float a = 0.9f;
//            int b = (int)a;
//            Console.WriteLine(b);

//            float c = 1.1f;
//            int d = (int)c;
//            Console.WriteLine(d);
//        }
//    }
//}

//// StringNumberConversion
//using System;

//namespace StringNumberConversion
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            // 숫자 -> 문자열: ToString() 메서드 사용
//            int a = 123;
//            string b = a.ToString();
//            Console.WriteLine(b);

//            float c = 3.14f;
//            string d = c.ToString();
//            Console.WriteLine(d);

//            // 문자열 -> 숫자: 
//            string e = "123456";
//            int f = Convert.ToInt32(e);
//            // null 값이 들어오면 0으로 반환
//            Console.WriteLine(f);

//            string g = "1.2345";
//            float h = float.Parse(g);
//            // null 값이 들어오면 error
//            Console.WriteLine(h);
//        }
//    }
//}

//// Constant
//using System;

//namespace Constant
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            const int MAX_INT = 2147483647;
//            const int MIN_INT = -2147483648;

//            Console.WriteLine(MAX_INT);
//            Console.WriteLine(MIN_INT);
//        }
//    }
//}

// Enum
using System;

namespace Enum
{
    class MainApp
    {
        // main 메서드 밖 전역함수로 사용
        // 배열과 같이 순차적으로 0, 1, 2, 3, 4를 자동 할당
        enum DialogResult {YES, NO, CANCEL, CONFIRM, OK}

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}