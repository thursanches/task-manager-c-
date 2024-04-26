using TaskManager.Communication.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetAll;
public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Tarefa Piloto",
                    Priority = Communication.enums.PriorityType.Medium,
                    Status = Communication.enums.StatusType.Completed,

                }
            }
        };
    }
}
