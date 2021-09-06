using System;
using System.Threading.Tasks;
using static System.Console;
namespace AsynchronousFactory
{
    public class Foo
    {
        private Foo()
        {
            // private constructor
            //no instantiate the object
        }
        async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }
        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }
    }
    class Program
    {
        public static async Task Main(string[] args)
        {
            Foo x = await Foo.CreateAsync();
        }
    }
}
