using CvScore.Application.Service.IService;
using CvScore.Application.Service.Service;
using CvScore.Data;
using CvScore.Domain.Accounts;
using CvScore.Domain.Messages;
using CvScore.Domain.Profiles;
using CvScore.Domain.Skills;
using StructureMap;


namespace CvScore.Web.BootStrapper {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });

                            x.For<IAccountService>().Use<AccountService>();
                            x.For<IAccountRepository>().Use<AccountRepository>();

                            x.For<IProfileService>().Use<ProfileService>();
                            x.For<IProfileRepository>().Use<ProfileRepository>();

                            x.For<ISkillService>().Use<SkillService>();
                            x.For<ISkillRepository>().Use<SkillRepository>();

                            x.For<IMessageService>().Use<MessageService>();
                            x.For<IMessageRepository>().Use<MessageRepository>();

                            x.For<IMessageService>().Use<MessageService>();
                            x.For<IMessageRepository>().Use<MessageRepository>();

                        });
            return ObjectFactory.Container;
        }
    }
}