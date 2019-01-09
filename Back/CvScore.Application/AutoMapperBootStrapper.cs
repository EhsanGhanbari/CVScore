using AutoMapper;
using CV.Application.DTO;

namespace CV.Application
{
    public class AutoMapperBootStrapper
    {
        public static void ConfigureAutoMapper()
        {

            //Contact
            Mapper.CreateMap<Contact, ContactDTO>();
            Mapper.CreateMap<ContactDTO, Contact>();




        }
    }
}
