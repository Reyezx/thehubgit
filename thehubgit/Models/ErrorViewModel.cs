namespace thehubgit.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public int? ErrorCode { get; set; }

        public int? ErrorCodes { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}