using AutoMapper;
using Db_Watch_and_Ring.Models;
using MyAPI.Model;

namespace MyAPI.Header
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<DongHo, WatchModel>().ReverseMap();
        }
    }
}
