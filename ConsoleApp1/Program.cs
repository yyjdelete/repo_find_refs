using DotNetty.Common.Concurrency;

namespace ConsoleApp1
{
    class Program
    {
        static IEventExecutor b;
        static void Test()
        {
            b.SubmitAsync(() => 1);
        }
        static void Main(string[] args)
        {
        }
    }
}
