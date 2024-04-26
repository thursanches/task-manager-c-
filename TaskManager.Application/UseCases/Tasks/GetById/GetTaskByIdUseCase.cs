using TaskManager.Communication.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Tarefa 1",
            Priority = 0,
            Status = 0,
        };
    }
}
