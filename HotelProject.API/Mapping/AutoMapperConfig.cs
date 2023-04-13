using AutoMapper;
using HotelProject.DTO.Dtos.RoomDto;
using HotelProject.Entity.Concrete;

namespace HotelProject.API.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();

        }
    }
}
