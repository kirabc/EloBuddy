namespace DisableWaterMark
{
    using EloBuddy;

    internal class Program
    {
        static void Main()
        {
            
             EloBuddy.Hacks.RenderWatermark = false;
            
            
            if (EloBuddy.Hacks.IngameChat)
            {
                EloBuddy.Hacks.IngameChat = false;
            }
        }
    }
}
