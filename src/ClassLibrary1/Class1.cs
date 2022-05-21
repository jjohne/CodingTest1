namespace ClassLibrary1
{
    public class Class1
    {
        private readonly IList<string> _brokers =
            new List<string>{
                                    "Vangard",
                                    "Ameritrade",
                                    "Capital",
                                    "City"
                                };
        public string GetFirstBroker()
        {
            return null;
        }

        public Task<string> GetFilteredBroker(string searchTag)
        {
            LongRunningTask1();
            LongRunningTask1();
            return null;
        }

        private async Task LongRunningTask1()
        {
            await Task.Delay(1000);
        }

        private async Task LongRunningTask2()
        {
            await Task.Delay(1000);
        }
    }
}