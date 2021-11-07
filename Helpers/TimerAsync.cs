using System;
using System.Threading.Tasks;
using System.Timers;

namespace Des_evaluacion_frontend.Helpers
{
    public class TimerAsync
    {
        public async Task ExecuteTaskOnceDay(int seconds, Action action)
        {
            var timer = new Timer(seconds * 1000);
            timer.Elapsed += (_, _) => action();
            timer.Start();
            await Task.Delay(TimeSpan.FromSeconds(seconds)).ContinueWith(_ => timer.Stop());
        }
    }
}