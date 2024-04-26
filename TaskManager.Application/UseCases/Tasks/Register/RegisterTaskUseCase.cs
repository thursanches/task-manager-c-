using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;
namespace TaskManager.Application.UseCases.Tasks.Register;
public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestRegisterTaskJson request)
    {
        return new ResponseRegisterTaskJson
        {
            Id = 1,
            Name = request.Name,
        };
    }
}
