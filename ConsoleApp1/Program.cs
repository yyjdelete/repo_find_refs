using DotNetty.Common.Concurrency;

namespace ConsoleApp1
{
    class Program
    {
        static IEventExecutor b;
        static void Usage2()
        {
            b.SubmitAsync(() => 2);
        }
        static void Main(string[] args)
        {
        }
    }
}
