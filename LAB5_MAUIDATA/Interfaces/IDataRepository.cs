using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB5_MAUIDATA.Models;

namespace LAB5_MAUIDATA.Interfaces
{
    public interface IDataRepository
    {
        Task<House[]> GetHouseAsync();

        Task<Address[]> GetHouseAddresesAsync(int houseId);
        Task<Garage[]> GetHouseGaragesAsync(int houseId);

        Task DeleteAddress(int houseId, int addressId);
        Task DeleteGarage(int houseId, int garageId);
        Task UpdateHouseAsync(House house);
        Task UpdateAddressAsync(Address address);
        Task UpdateGarageAsync(Garage garage);
    }

}
