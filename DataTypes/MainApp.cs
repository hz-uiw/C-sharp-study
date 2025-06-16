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

//// Enum1
//using System;

//namespace Enum1
//{
//    class MainApp
//    {
//        // main 메서드 밖 전역함수로 사용
//        // 배열과 같이 순차적으로 0, 1, 2, 3, 4를 자동 할당
//        enum DialogResult {YES, NO, CANCEL, CONFIRM, OK}

//        static void Main(string[] args)
//        {
//            Console.WriteLine((int)DialogResult.NO);
//            Console.WriteLine((int)DialogResult.YES);
//            Console.WriteLine((int)DialogResult.CANCEL);
//            Console.WriteLine((int)DialogResult.CONFIRM);
//            Console.WriteLine((int)DialogResult.OK);
//        }
//    }
//}

//// Enum2
//using System;

//namespace Enum2
//{
//    enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            DialogResult result = DialogResult.YES;

//            Console.WriteLine(result == DialogResult.YES);
//            Console.WriteLine(result == DialogResult.NO);
//            Console.WriteLine(result == DialogResult.CANCEL);
//            Console.WriteLine(result == DialogResult.CONFIRM);
//            Console.WriteLine(result == DialogResult.OK);
//        }
//    }
//}

//// Enum3
//using System;

//namespace Enum3
//{
//    class MainApp
//    {
//        enum DialogResult {YES = 10, NO, CANCEL, CONFIRM = 50, OK}
//        static void Main(string[] args)
//        {
//            Console.WriteLine((int)DialogResult.NO);
//            Console.WriteLine((int)DialogResult.YES);
//            Console.WriteLine((int)DialogResult.CANCEL);
//            Console.WriteLine((int)DialogResult.CONFIRM);
//            Console.WriteLine((int)DialogResult.OK);
//        }
//    }
//}

//// Nullable 형식
//using System;

//namespace Nullable
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int? a = null;

//            // HashValue 메서드 해당값이 null이면 False, null이 아니면 True
//            Console.WriteLine(a.HasValue);
//            // a는 null이므로 False 출력
//            Console.WriteLine(a != null);

//            a = 3;

//            Console.WriteLine(a.HasValue);
//            // a는 null이 아니므로 True 출력
//            Console.WriteLine(a != null);
//            // Value 메서드 변수에 담겨있는 해당값 출력
//            Console.WriteLine(a.Value);
//        }
//    }
//}

//// Var
//using System;

//namespace UsingVar
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            // var 선언시 반드시 초기화 필요
//            var a = 20;
//            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

//            var b = 3.1414213;
//            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

//            var c = "Hello, World!";
//            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

//            var d = new int[] {10, 20, 30};
//            Console.Write("Type: {0}, Value: ", b.GetType());
//            foreach (var e in d)
//                Console.Write("{0} ", e);
//            Console.WriteLine();
//        }
//    }
//}

//// CTS
//using System;

//namespace CTS
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            System.Int32 a = 123;
//            int b = 456;

//            Console.WriteLine("a type: {0}, value: {1}", a.GetType().ToString(), a);
//            Console.WriteLine("b type: {0}, value: {1}", b.GetType().ToString(), b);

//            System.String c = "abc";
//            string d = "def";

//            Console.WriteLine("c type: {0}, value: {1}", c.GetType().ToString(), c);
//            Console.WriteLine("d type: {0}, value: {1}", d.GetType().ToString(), d);
//        }
//    }
//}

//// StringSearch
//using static System.Console;

//namespace StringSearch
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string greeting = "Good Morning";

//            WriteLine(greeting);
//            WriteLine();

//            // IndexOf()
//            // 현재 문자열 내에서 찾으려고 하는 지정된 문자 또는 문자열의 위치를 찾는다
//            WriteLine("IndexOf 'Good': {0}", greeting.IndexOf("Good")); // 0번째 인덱스
//            WriteLine("IndexOf 'o': {0}", greeting.IndexOf('o'));   // 1번째 인덱스

//            // LastIndexOf()
//            // 현재 문자열 내에서 찾으려고 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾는다
//            WriteLine("LastIndexOf 'good': {0}", greeting.LastIndexOf("Good")); // 0번째 인덱스
//            WriteLine("LastIndexOf 'o': {0}", greeting.LastIndexOf('o'));   // 1번쨰 인덱스

//            // StartsWith()
//            // 현재 문자열이 지정된 문자열로 시작하는지를 평가
//            // 논리형으로 반환
//            WriteLine("StartsWith 'Good': {0}", greeting.StartsWith("Good"));   // True
//            WriteLine("StartsWith 'Morning': {0}", greeting.StartsWith("Morning")); // False

//            // EndsWith()
//            // 현재 문자열이 지정된 문자열로 끝나는지 평가
//            // 논리형으로 반환
//            WriteLine("EndsWith 'Good': {0}", greeting.EndsWith("Good"));   // False
//            WriteLine("EndsWith 'Morning': {0}", greeting.EndsWith("Morning")); // True

//            // Contains()
//            // 현재 문자열이 지정된 문자열을 포함하는지를 평가
//            // 논리형으로 반환
//            WriteLine("Contains 'Evening': {0}", greeting.Contains("Evening")); // false
//            WriteLine("Contains 'Morning': {0}", greeting.Contains("Morning")); // ture

//            // Replace(A, B)
//            // 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환
//            WriteLine("Replaced 'Morning' with 'Evening': {0}",
//                greeting.Replace("Morning", "Evening"));
//        }
//    }
//}

//// StringModify
//using static System.Console;

//namespace StringModify
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            // ToLower()
//            // 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열 반환
//            WriteLine("ToLower(): '{0}'", "ABC".ToLower());

//            // ToUpper()
//            // 현재 문자열의 모든 소문자를 대문자로 바꾼 새 문자열 반환
//            WriteLine("ToUpper(): '{0}'", "abc".ToLower());

//            // Insert(num, a)
//            // 현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열 반환
//            WriteLine("Insert(): '{0}'", "Happy Friday!".Insert(5, " Sunny "));

//            // Remove(a, b)
//            // 현재 문자열의 지정된 위치로부터 지정된 수만큼 문자가 삭제된 새 문자열 반환
//            WriteLine("Remove(): '{0}'", "I Don't Love You.".Remove(2, 6));

//            // Trim()
//            // 현재 문자열의 압/뒤에 있는  공백을 삭제한 새 문자열 반환
//            WriteLine("Trim(): '{0}'", " No Spaces ".Trim());

//            // TrimStar()
//            // 현재 문자열의 앞에 있는 공백을 삭제한 새 문자열 반환
//            WriteLine("TrimStart(): '{0}", " No Spaces ".TrimStart());

//            // TrimEnd()
//            // 현재 문자열의 뒤에 있는 공백을 삭제한 새 문자열 반환
//            WriteLine("TrimEnd(): '{0}'", " No Spaces ".TrimEnd());
//        }
//    }
//}

//// StringSlice
//using System;
//using static System.Console;

//namespace StringSlice
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string greeting = "Good Morning";

//            // SubString(Index, num2)
//            // 현재 문자열의 지정된 위치(Index)로부터 지정된 수(num2) 만큼의 문자로 이루어진 새 문자열 반환
//            // num2를 비워두면 해당 Index부터 문자열 끝까지 새 문자열로 반환
//            WriteLine(greeting.Substring(0, 4));    // "Good"
//            WriteLine(greeting.Substring(5));   // "Morning"
//            WriteLine();

//            // Split()
//            // 지정된 문자 기준으로 현재 문자열을 분리한 다음 분리한 문자열의 배열을 반환
//            string[] arr = greeting.Split(
//                new string[] { " " }, StringSplitOptions.None);
//            WriteLine("Word Count: {0}", arr.Length);

//            foreach (string element in arr)
//                WriteLine("{0}", element);
//        }
//    }
//}

//// StringFormatBasic
//using System;
//using static System.Console;

//namespace StringFormatBasic
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string fmt = "{0,-20}{1, -15}{2, 30}";

//            WriteLine(fmt, "Publisher", "Author", "Title");
//            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
//            WriteLine(fmt, "Hanbit", "Minchang Kwon", "This is c#");
//            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
//        }
//    }
//}

// StringFormatNumber
using System;
using static System.Console;

namespace StringFormatNumber
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // D, 10진수: 입력된 수를 10진수로 서식화
            WriteLine("10진수: {0:D}", 123);  // WriteLine(string.Format("10진수: {0:D}, 123)); 과 동일
            WriteLine("10진수: {0:D5}", 123);
            
            // X, 16진수: 입력된수를 16진수로 서식화
            WriteLine("16진수: 0x{0:X}", 0xFF1234);
            WriteLine("16진수: 0x{0:X8}", 0xFF1234);

            // N, 콤마(,)로 묶어 표현한 수: 입력된 수를 콤마로 구분하여 출력
            WriteLine("숫자: {0:N}", 123456789);
            WriteLine("숫자: {0:N0}", 123456789); // 자릿수 0은 소수점 이하를 제거함

            // F, 고정 소수점: 입력된 수를 고정 소수점 형식으로 서식화
            WriteLine("고정 소수점: {0:F}", 123.45);
            WriteLine("고정 소수점: {0:F5}", 123.456);

            // E, 지수: 입력된 수를 지수 표기로 서식화(공학용)
            WriteLine("공학: {0:E}", 123.456789);
        }
    }
}