using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.DataAccess.Abstract;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal : EfEntityRepository<Address,Context>,IAddressDal
    {
    }
}
