using System.Collections.Concurrent;
using Aida.Sdk.Mini.Model;

namespace WebhooksReceiver.Messaging;

public class MachineMessage
{
    public string IpAddress { get; set; }
    public WorkflowMessage Message { get; set; }
    
    public MachineMessage(string ipAddress, WorkflowMessage message)
    {
        IpAddress = ipAddress;
        Message = message;
    }
}

public class MessageCollection
{
    //create queue of MachineMessage
    private readonly ConcurrentQueue<MachineMessage> _incomingMessages = new();
    //enqueue message in _incomingMessages queue
    public void Enqueue(MachineMessage message) => _incomingMessages.Enqueue(message);
    //Tries to remove and return the object at the beginning of the concurrent queue.
    public MachineMessage TakeMessage() => _incomingMessages.TryDequeue(out var message) ? message : null;
}