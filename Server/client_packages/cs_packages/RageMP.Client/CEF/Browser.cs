using RAGE.Ui;

namespace RageMP.Client.CEF
{
    public static class Browser
    {
        public static HtmlWindow Window { get; }
        public static string BaseAddress => "";

        static Browser()
        {
            Window = new HtmlWindow(BaseAddress)
            {
                Active = false
            };
        }

        public static void TriggerEvent(this HtmlWindow window, string eventName, params object[] args)
        {
            window.ExecuteJs($"window.eventsManager.call('{eventName}', {RAGE.Util.Json.Serialize(args)})");
        }
    }
}
