using TaskManager.Communication.Requests;

namespace TaskManager.Communication.Responses;
public class ResponseRegisterTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public object Execute(RequestRegisterTaskJson request)
    {
        throw new NotImplementedException();
    }
}
