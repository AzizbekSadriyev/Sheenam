using Sheenam.Api.Models.Foundations.Guests;
using System.Threading.Tasks;

namespace Sheenam.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        public ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
