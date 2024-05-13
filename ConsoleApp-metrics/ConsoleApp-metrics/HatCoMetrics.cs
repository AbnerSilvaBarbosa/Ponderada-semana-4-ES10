using System.Diagnostics.Metrics;

namespace ConsoleApp_metrics
{
    public class HatCoMetrics
    {
        private readonly Counter<int> _hatsSold;
        private readonly Histogram<double> _orderProcessingTime;
        private readonly ObservableCounter<int> _coatsSoldCounter;
        private static int _coatsSold;
        private static int _ordersPending;
        private static Random _rand = new Random();

        public HatCoMetrics(IMeterFactory meterFactory)
        {
            var meter = meterFactory.Create("HatCo.Store");
            _hatsSold = meter.CreateCounter<int>("hatco.store.hats_sold");
            _orderProcessingTime = meter.CreateHistogram<double>("hatco.store.order_processing_time");
            _coatsSoldCounter = meter.CreateObservableCounter<int>("hatco.store.coats_sold", () => _coatsSold);
            meter.CreateObservableGauge<int>("hatco.store.orders_pending", () => _ordersPending);
        }

        private void HatsSold(int quantity)
        {
            _hatsSold.Add(quantity);
        }

        private void RecordOrderProcessingTime(double time)
        {
            _orderProcessingTime.Record(time);
        }

        private void SimulateCoatSale()
        {
            _coatsSold += 5;
        }

        private void SimulateOrderQueue()
        {
            _ordersPending = _rand.Next(0, 25);
        }

        public void SimulateMetricsAbner()
        {
            HatsSold(5);
            SimulateCoatSale();
            SimulateOrderQueue();
            RecordOrderProcessingTime(_rand.Next(5, 15) / 1000.0);
        }

        public void GetMetrics()
        {
            Console.WriteLine(_hatsSold);
            Console.WriteLine(_ordersPending);
            Console.WriteLine(_orderProcessingTime);
            Console.WriteLine(_coatsSold);
        }
    }
}
