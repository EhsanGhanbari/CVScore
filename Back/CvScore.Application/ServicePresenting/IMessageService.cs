using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.Application.Messaging.Messages;

namespace CV.Application.ServicePresenting
{
    public interface IMessageService
    {
        CreateMessageResponse CreateMessage(CreateMessageRequest request);
        GetMessageResponse GetMessage(GetMessageRequest request);
        GetAllMessageResponse GetAllMessage(GetAllMessageRequest request);
        RemoveMessageResponse RemoveMessage(RemoveMessageRequest request);
    }
}
