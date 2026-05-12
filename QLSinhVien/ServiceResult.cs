public class ServiceResult
{
    public ServiceResult()
    {
    }

    public ServiceResult(bool success, string message, string tile, bool except)
    {
        Success = success;
        Message = message;
        Tile = tile;
        Except = except;
    }

    public bool Success { get; set; }
    public string Message { get; set; }
    public string Tile { get; set; }
    public bool Except { get; set; }

}