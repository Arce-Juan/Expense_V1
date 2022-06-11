using Ardalis.Specification;

namespace Core.Application.Interfaces
{
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }
}
