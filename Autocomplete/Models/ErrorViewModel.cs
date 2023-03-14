namespace Autocomplete.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class customer
    {
        public int id { get; set; }
        public string customerName { get; set; }
    }
}