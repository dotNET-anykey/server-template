using RageMP.Client.Scripts;

namespace RageMP.Client
{
    public class Main : RAGE.Events.Script
    {
        public Main()
        {
            RAGE.Events.OnPlayerReady += OnPlayerReady;
        }

        private void OnPlayerReady()
        {
            Script.Launch();
        }
    }
}
