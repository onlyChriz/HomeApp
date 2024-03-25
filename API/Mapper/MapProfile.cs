using AutoMapper;
using HomeApp.API.Models;

namespace HomeApp.API.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<TasksToDo, TasksToDo>();
        }
    }
}
