using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL_Dotnet
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var schema = Schema.For(@"type Query { hello: String}");

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ hello }";
                _.Root = new { Hello = "Hello World!" };
            });

            Console.WriteLine(json);
        }
    }
}
