using Test.Dotnet.Topic.Publisher.Api.Models;
using Test.Dotnet.Topic.Publisher.Core.Entities;

using AutoMapper;

namespace Test.Dotnet.Topic.Publisher.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
