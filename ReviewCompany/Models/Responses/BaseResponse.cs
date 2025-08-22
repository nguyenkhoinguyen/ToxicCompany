namespace ReviewCompany.Models.Responses
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public int Total { get; set; }
        public T? Result { get; set; }
    }
}
