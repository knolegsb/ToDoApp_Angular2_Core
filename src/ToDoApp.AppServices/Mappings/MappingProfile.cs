using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.AppServices.Dtos;

namespace ToDoApp.AppServices.Mappings
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.TodoDto, Domain.Entities.Todo>().ReverseMap();
            CreateMap<Dtos.TodoFilterDto, Domain.Filters.TodoFilter>().ReverseMap();
        }
    }
}
