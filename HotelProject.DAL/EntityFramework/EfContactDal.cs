using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repository;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DAL.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {

        public EfContactDal(Context context) : base(context)
        {

        }

        public int GetContactCount()
        {
            var context = new Context();
            return context.Contacts.Count();
        }
    }
}
