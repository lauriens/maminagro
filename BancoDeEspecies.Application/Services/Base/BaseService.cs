using AutoMapper;
using BancoDeEspecies.Application.Exceptions;
using BancoDeEspecies.DataAccess.UnitOfWork;

namespace BancoDeEspecies.Application.Services.Base
{
    public interface IBaseService<T, W>
    {
        Task<IEnumerable<W>> GetAllAsync();
        Task<W> GetByIdAsync(int id);
        Task CreateAsync(W entity);
        Task DeleteAsync(int id);
    }

    public class BaseService<T, W> : IBaseService<T, W> where T : class
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<W>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<T>();
            var result = await repository.Get();

            return result.Select(_mapper.Map<W>);
        }

        public async Task<W> GetByIdAsync(int id)
        {
            var repository = _unitOfWork.GetBaseRepository<T>();
            var result = await repository.GetByID(id);

            if (result == null)
                throw new NotFoundException(id, typeof(T).ToString());

            return _mapper.Map<W>(result);
        }

        public async Task CreateAsync(W entityViewModel)
        {
            var repository = _unitOfWork.GetBaseRepository<T>();

            var entity = _mapper.Map<T>(entityViewModel);
            repository.Insert(entity);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var repository = _unitOfWork.GetBaseRepository<T>();
            repository.Delete(id);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
