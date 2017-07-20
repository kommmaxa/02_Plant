using System;
using System.Threading;

namespace _02_Plant
{
    class Plant
    {

        public delegate void OperationOnPart(Part part);
        public void PerformOperationOnPart(Part part, OperationOnPart operation)
        {
            var operationStart = DateTime.Now;
            Console.WriteLine();
            //Console.WriteLine("======= Part ========", part.name);
            Console.WriteLine("{0} Operation has started at {1} by {2}", operation.Method.Name, operationStart, operation.Target);
            operation(part);
            Thread.Sleep(2000);
            var operationEnd = DateTime.Now;
            Console.WriteLine("Operation has finished at {0}", operationEnd);
            var operationExecutionTime = operationEnd - operationStart;
            Console.WriteLine("Operation has lasted for {0}", operationExecutionTime);
            Console.WriteLine();
        }

    }
}
