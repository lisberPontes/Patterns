using System;
using BuilderPatternTester.ClassicApproach;
using BuilderPatternTester.FluentApproach;

namespace BuilderPatternTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classicBuilderUsage = new ClassicBuilderUsage();
            classicBuilderUsage.BuildOneStoryHouse();
            classicBuilderUsage.BuildMultiStoryHouse();
            Console.ReadLine();

            Console.WriteLine("*** FluentBuilder Pattern implementation ***\n\n");

            var fluentBuilderUsage = new FluentBuilderUsage();
            fluentBuilderUsage.BuildOneStoryHouse();
            fluentBuilderUsage.BuildMultiStoryHouse();
            Console.ReadLine();

        }
    }
}