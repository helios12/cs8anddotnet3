using System;

namespace Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"sbyte size: {sizeof(sbyte)}, minValue: {sbyte.MinValue}, maxValue: {sbyte.MaxValue}");
            Console.WriteLine($"byte size: {sizeof(byte)}, minValue: {byte.MinValue}, maxValue: {byte.MaxValue}");
            Console.WriteLine($"short size: {sizeof(short)}, minValue: {short.MinValue}, maxValue: {short.MaxValue}");
            Console.WriteLine($"ushort size: {sizeof(ushort)}, minValue: {ushort.MinValue}, maxValue: {ushort.MaxValue}");
            Console.WriteLine($"int size: {sizeof(int)}, minValue: {int.MinValue}, maxValue: {int.MaxValue}");
            Console.WriteLine($"uint size: {sizeof(uint)}, minValue: {uint.MinValue}, maxValue: {uint.MaxValue}");
            Console.WriteLine($"long size: {sizeof(long)}, minValue: {long.MinValue}, maxValue: {long.MaxValue}");
            Console.WriteLine($"ulong size: {sizeof(ulong)}, minValue: {ulong.MinValue}, maxValue: {ulong.MaxValue}");
            Console.WriteLine($"float size: {sizeof(float)}, minValue: {float.MinValue}, maxValue: {float.MaxValue}");
            Console.WriteLine($"double size: {sizeof(double)}, minValue: {double.MinValue}, maxValue: {double.MaxValue}");
            Console.WriteLine($"decimal size: {sizeof(decimal)}, minValue: {decimal.MinValue}, maxValue: {decimal.MaxValue}");
        }
    }
}
