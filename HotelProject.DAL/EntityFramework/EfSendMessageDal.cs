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
    public class EfSendMessageDal:GenericRepository<SendMessage>, ISendMessageDal
    {
        public EfSendMessageDal(Context context): base(context) 
        {
            
        }

        public int GetSendMessageCount()
        {
            var context = new Context();
            return context.SendMessages.Count();
        }
    }
}
