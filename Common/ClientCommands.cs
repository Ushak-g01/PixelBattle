namespace Common
{
    public static class ClientCommands
    {
        public const string CreateWorld = "CREATE";
        public const string JoinWorld = "JOIN";
        public const string PlaceWorld = "PIXEL";
        public const string ListWorld = "LIST";
    }
    public static class ServerCommands
    {
        public const string WorldState = "STATE";
        public const string PixelPlaced = "PIXEL_OK";
        public const string Error = "ERROR";
        public const string WorldList = "WORLDS";
    }
    public class WorldState
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public byte[,] Pixels { get; set; }
        public Dictionary<string, int> PlayerScores { get; set; }

    }
}
