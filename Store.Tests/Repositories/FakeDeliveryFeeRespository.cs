using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories
{
    public class FakeDeliveryFeeRespository : IDeliveryFeeRepository
    {
        public decimal Get(string zipcode)
        {
            return 10;
        }
    }
}