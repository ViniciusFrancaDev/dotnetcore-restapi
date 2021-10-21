using AutoMapper;
using dotnetcore_restapi.Dtos;
using dotnetcore_restapi.Models;

namespace dotnetcore_restapi.Profiles
{
    public class SubjectsProfile : Profile
    {
        public SubjectsProfile()
        {
            CreateMap<Subject, SubjectReadDto>();
        }
    }
}
