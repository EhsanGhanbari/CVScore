using AutoMapper;
using CvScore.Domain.Contacts;
using CvScore.MetaData;

namespace CvScore.Application
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
