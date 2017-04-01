namespace Bridge.Google.Maps
{
    using Bridge;
    
    public static class Init
    {
        // since those are interfaces, they need to be declared explicitly for bridge to work

        [Init(InitPosition.Top)]
        public static void Initialize()
        {
            Script.Write("Bridge.Google.Maps.Projection = function(){};");
            Script.Write("Bridge.Google.Maps.MapType = function(){};");
        }
    }
}