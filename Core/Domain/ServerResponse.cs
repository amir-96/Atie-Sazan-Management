namespace Domain
{
  public class ServerResponse<T>
  {
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }

    public ServerResponse(bool success, string message, T data)
    {
      IsSuccess = success;
      Message = message;
      Data = data;
    }
  }
}
