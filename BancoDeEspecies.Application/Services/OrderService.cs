using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Application.ViewModels.Order;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IOrderService : IBaseService<Order, OrderViewModel, CreateOrderViewModel>
    {
    }

    public class OrderService : BaseService<Order, OrderViewModel, CreateOrderViewModel>, IOrderService
    {
        public OrderService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
