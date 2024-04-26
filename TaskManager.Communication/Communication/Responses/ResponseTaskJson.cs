using TaskManager.Communication.enums;

namespace TaskManager.Communication.Communication.Responses;
public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PriorityType  Priority { get; set; }
    public StatusType Status { get; set; }
}
