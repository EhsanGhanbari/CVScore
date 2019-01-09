using CV.Application.Mappers;
using CvScore.Application.Messaging.Messages;
using CvScore.Application.Service.IService;
using CvScore.Domain.Messages;

namespace CvScore.Application.Service.Service
{
   public class MessageService :IMessageService
   {
       private readonly IMessageRepository _messageRepository;

       public MessageService(IMessageRepository messageRepository)
       {
           _messageRepository = messageRepository;
       }


       /// <summary>
       /// Createa Message 
       /// </summary>
       /// <param name="request"></param>
       /// <returns></returns>
       public CreateMessageResponse CreateMessage(CreateMessageRequest request)
       {
           var response = new CreateMessageResponse();
           var message = request.MessageDTO.ConverToMessageModel();
           _messageRepository.Add(message);
           return response;
       }


       /// <summary>
       /// Get Message Details By ID
       /// </summary>
       /// <param name="request"></param>
       /// <returns></returns>
       public GetMessageResponse GetMessage(GetMessageRequest request)
       {
           var response = new GetMessageResponse();
           var message = _messageRepository.FindBy(request.MessageDTO.MessageId);
           response.MessageDTO = message.ConvertToMessageDTO();
           return response;
       }


       /// <summary>
       /// Get ALl message of a user
       /// </summary>
       /// <param name="request"></param>
       /// <returns></returns>
       public GetAllMessageResponse GetAllMessage(GetAllMessageRequest request)
       {
           var response = new GetAllMessageResponse();
           var messages = _messageRepository.FindAll();
           response.MessageDTO = messages.ConvertToMessageDTOList();
           return response;
       }


       /// <summary>
       /// Remove Message
       /// Sent message by A user or recieved message in B user's inbox
       /// </summary>
       /// <param name="request"></param>
       /// <returns></returns>
       public RemoveMessageResponse RemoveMessage(RemoveMessageRequest request)
       {
           var response = new RemoveMessageResponse();
           var message = request.MessageDTO.ConverToMessageModel();
           _messageRepository.Remove(message);
           return response;
       }
    }
}
