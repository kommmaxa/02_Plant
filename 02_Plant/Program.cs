using System;

namespace _02_Plant
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant plant = new Plant();
            Part part = new Part("my_new_part");
            PartOperationProvider provider = new DniproProvider();

            PerformOperationsOnPlantByProvider(part, plant, provider);

            part = new Part("another_part");
            provider = new KyivProvider();

            PerformOperationsOnPlantByProvider(part, plant, provider);
        }

        static void PerformOperationsOnPlantByProvider(Part part, Plant plant, PartOperationProvider provider)
        {
            Console.WriteLine(part);
            provider.PerformStandardSetOfOperations(part, plant);
            Console.WriteLine(part);
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            Console.WriteLine();
        }
    }
}
