using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
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

        public new async Task<IEnumerable<OrderViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Order>();
            var result = await repository.Get(includeProperties: "Class.Phylum.Kingdom.Domain");

            return result.Select(_mapper.Map<OrderViewModel>);
        }
    }
}
