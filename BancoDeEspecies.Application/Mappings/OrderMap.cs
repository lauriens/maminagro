using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Order;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class OrderMap : Profile
    {
        public OrderMap()
        {
            CreateMap<Order, OrderViewModel>();
            CreateMap<CreateOrderViewModel, Order>();
            CreateMap<EditOrderViewModel, Order>();
        }
    }
}
