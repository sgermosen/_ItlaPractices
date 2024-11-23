namespace ExpressTaste.Common.Responses
{
    public class DeleteOrderDetailResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public decimal UpdatedOrderTotal { get; set; }
    }
}
