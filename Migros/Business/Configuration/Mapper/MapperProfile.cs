using AutoMapper;
using DTO.Payment;
using Models.Entities;

namespace Business.Configuration.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreatePaymentRequest, Payment>();
            CreateMap<UpdatePaymentRequest, Payment>();
            CreateMap<Payment, SearchPaymentResponse>();
            CreateMap<Payment, SearchPaymentResponse2>();
            CreateMap<CreateUserRequest, User>();
        }
    }
}
