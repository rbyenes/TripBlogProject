using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Business.Abstract;
using TravelTripProject.Business.Concrete;
using TravelTripProject.DataAccess.Abstract;
using TravelTripProject.DataAccess.Concrete.EntityFramework;
using TravelTripProject.Entities.Abstract;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAboutService>().To<AboutManager>().InSingletonScope();
            Bind<IAboutDal>().To<EfAboutDal>().InSingletonScope();

            Bind<IAddressService>().To<AddressManager>().InSingletonScope();
            Bind<IAddressDal>().To<EfAddressDal>().InSingletonScope();

            Bind<IAdminService>().To<AdminManager>().InSingletonScope();
            Bind<IAdminDal>().To<EfAdminDal>().InSingletonScope();

            Bind<IBlogCommentService>().To<BlogCommentManager>().InSingletonScope();
            Bind<IBlogCommentDal>().To<EfBlogCommentDal>().InSingletonScope();

            Bind<IBlogService>().To<BlogManager>().InSingletonScope();
            Bind<IBlogDal>().To<EfBlogDal>().InSingletonScope();

            Bind<ICommentService>().To<CommentManager>().InSingletonScope();
            Bind<ICommentDal>().To<EfCommentDal>().InSingletonScope();

            Bind<IContactService>().To<ContactManager>().InSingletonScope();
            Bind<IContactDal>().To<EfContactDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

        }
    }
}
