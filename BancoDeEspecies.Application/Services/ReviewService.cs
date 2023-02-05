using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IReviewService : IBaseService<Review, ReviewViewModel>
    {
    }

    public class ReviewService : BaseService<Review, ReviewViewModel>, IReviewService
    {
        public ReviewService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
