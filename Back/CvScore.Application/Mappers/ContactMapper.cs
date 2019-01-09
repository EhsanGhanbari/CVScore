using System.Collections.Generic;
using AutoMapper;
using CV.Application.DTO;
using CV.Model.Contacts;

namespace CV.Application.Mappers
{
    public static class ContactMapper
    {
        /// <summary>
        /// Convert to View
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public static ContactDTO ConvertToContactView(this Contact contact)
        {
            return Mapper.Map<Contact, ContactDTO>(contact);
        }


        /// <summary>
        ///Convert to Model 
        /// </summary>
        /// <param name="contactView"></param>
        /// <returns></returns>
        public static Contact ConvertToContactModel(this ContactDTO contactView)
        {
            return Mapper.Map<ContactDTO, Contact>(contactView);
        }



        /// <summary>
        /// Convert to Contact List View
        /// </summary>
        /// <param name="contacts"></param>
        /// <returns></returns>
        public static IEnumerable<ContactDTO> ConvertToContactViewList(this IEnumerable<Contact> contacts)
        {
            return Mapper.Map<IEnumerable<Contact>, IEnumerable<ContactDTO>>(contacts);
        }
    }
}
