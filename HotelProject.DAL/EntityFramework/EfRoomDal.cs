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
    public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {

        public EfRoomDal(Context context) : base(context) 
        {
            
        }
    }
}
