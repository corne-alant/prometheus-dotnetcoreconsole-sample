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

            //start metric server exposed on http://localhost:1234/metrics
            var metricServer = new KestrelMetricServer(port: 1234);
            metricServer.Start();

            
            var counter = Metrics.CreateCounter("myCounter", "some help about this");
            
            for(var i = 0; i < 2000; i++)
            {
            counter.Inc(i);
            Thread.Sleep(2000);
            }

            Console.WriteLine("Exit");
        }
    }
}
