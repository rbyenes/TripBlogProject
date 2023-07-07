using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.DataAccess.Abstract;
using TravelTripProject.Entities.ComplexTypes;
using TravelTripProject.Entities.Concrete;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepository<User, Context>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (Context context = new Context())
            {
                var result = from ur in context.UserRoles
                             join r in context.Roles
                             on ur.RoleId equals r.Id
                             where ur.UserId == user.Id
                             select new UserRoleItem { RoleName = r.Name };
                return result.ToList();
            }
        }
    }
}
