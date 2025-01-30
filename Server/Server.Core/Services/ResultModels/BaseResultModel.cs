namespace Server.Core.Services.ResultModels
{
    public abstract class BaseResultModel
    {
        public bool Success => Errors.Count == 0;
        public List<string> Errors { get; set; } = new List<string>();
    }
}