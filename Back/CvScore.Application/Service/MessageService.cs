using CV.Application.Mappers;
using CV.Application.Messaging.Messages;
using CV.Application.ServicePresenting;
using CV.Repository.UnitOfWork;
using CV.Model.Messages;

namespace CV.Application.Service
{
   public class MessageService :IMessageService
   {
       private readonly IMessageRepository _messageRepository;
       private readonly IUnitOfWork _unitOfWork;

       public MessageService(IMessageRepository messageRepository, IUnitOfWork unitOfWork)
       {
           _messageRepository = messageRepository;
           _unitOfWork = unitOfWork;
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
           _unitOfWork.Commit();
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
           _unitOfWork.Commit();
           return response;
       }
    }
}
