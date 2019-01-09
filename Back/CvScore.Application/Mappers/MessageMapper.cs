using System.Collections.Generic;
using AutoMapper;
using CV.Application.DTO;
using CV.Model.Messages;

namespace CV.Application.Mappers
{
    public static class MessageMapper
    {

        /// <summary>
        /// Convert to Message DTO 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static MessageDTO ConvertToMessageDTO(this Message message)
        {
            Mapper.CreateMap<Message, MessageDTO>()
                  .ForMember(mess => mess.MessageId, me => me.MapFrom(m => m.Id));
            return Mapper.Map<Message, MessageDTO>(message);
        }


        /// <summary>
        /// Convert to Message Model
        /// </summary>
        /// <param name="messageDTO"></param>
        /// <returns></returns>
        public static Message ConverToMessageModel(this MessageDTO messageDTO)
        {
            return Mapper.Map<MessageDTO, Message>(messageDTO);
        }



        /// <summary>
        /// Convert To Message DTO List
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static IEnumerable<MessageDTO> ConvertToMessageDTOList(this IEnumerable<Message> message)
        {
            Mapper.CreateMap<Message, MessageDTO>()
                  .ForMember(mess => mess.MessageId, me => me.MapFrom(m => m.Id));
            return Mapper.Map<IEnumerable<Message>, IEnumerable<MessageDTO>>(message);
        }
    }
}
