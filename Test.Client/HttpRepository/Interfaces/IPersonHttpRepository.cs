using Test.Shared.Dtos;

namespace Test.Client.HttpRepository.Interfaces
{
    public interface IPersonHttpRepository
    {
        Task<IList<PersonDto>> GetAllPersonsAsync();
    }
}
