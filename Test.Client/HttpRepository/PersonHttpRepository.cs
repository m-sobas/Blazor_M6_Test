using System.Net.Http.Json;
using Test.Client.HttpRepository.Interfaces;
using Test.Shared.Dtos;

namespace Test.Client.HttpRepository
{
    public class PersonHttpRepository : IPersonHttpRepository
    {
        private readonly HttpClient _client;

        public PersonHttpRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<IList<PersonDto>> GetAllPersons() 
            => await _client.GetFromJsonAsync<IList<PersonDto>>("person");
    }
}
