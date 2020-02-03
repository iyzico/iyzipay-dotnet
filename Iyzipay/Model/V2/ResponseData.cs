namespace Iyzipay.Model.V2
{
    public class ResponseData<T> : IyzipayResourceV2
    {
        public T Data { get; set; }
    }
}