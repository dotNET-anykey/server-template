using Client.Scripts;
using RAGE;

namespace Client
{
    public class Main : Events.Script
    {
        public Main()
        {
            Events.OnPlayerReady += OnPlayerReady;
        }

        private void OnPlayerReady()
        {
            Script.Launch();
        }
    }
}
