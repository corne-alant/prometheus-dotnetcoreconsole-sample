using System;
using System.Threading;
using Prometheus;

namespace prometheus_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");

            //start prom server
            var metricServer = new KestrelMetricServer(port: 1234);
            metricServer.Start();

            Thread.Sleep(200000);

            Console.WriteLine("Exit");
        }
    }
}
