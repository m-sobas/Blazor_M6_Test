using Microsoft.AspNetCore.Components;
using Test.Client.HttpRepository.Interfaces;
using Test.Shared.Dtos;

namespace Test.Client.Pages
{
    public partial class Person
    {
        private IList<PersonDto> _persons;

        [Inject]
        public IPersonHttpRepository PersonRepository { get; set; }

        protected override async Task OnInitializedAsync()
        {
           _persons = await PersonRepository.GetAllPersons();
        }
    }
}
