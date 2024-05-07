// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Reflection;

//Console.WriteLine("Hello, World!");

var summary = BenchmarkRunner.Run<StringStartsWithBenchmark>();


public class StringStartsWithBenchmark
{
    private const int Iterations = 100;
    private string testString = "sample string";

    [Benchmark]
    public void StartsWithDoubleQuotes()
    {
        for (int i = 0; i < Iterations; i++)
        {
            string testString = "sample string";
            bool startsWithS = testString.StartsWith("s");
        }
    }

    [Benchmark]
    public void StartsWithSingleQuotes()
    {
        for (int i = 0; i < Iterations; i++)
        {
            string testString = "sample string";
            bool startsWithS = testString.StartsWith('s');
        }
    }
}
