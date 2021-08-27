using DotNetty.Common.Concurrency;

namespace ClassLibrary2
{
    class TestClass
    {
        static IEventExecutor b;
        static void Usage1()
        {
            b.SubmitAsync(() => 1);
        }
    }
}
