using LAB5_MAUIDATA.Interfaces;
using LAB5_MAUIDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_MAUIDATA.Services
{
    public class ApiDataRepository : IDataRepository
    {
        private readonly IHouseApiClient _houseApiClient;

        public ApiDataRepository(IHouseApiClient apiClient)
        {
            _houseApiClient = apiClient;
        }
        public async Task DeleteAddress(int studentId, int addressId)
        {
            await _houseApiClient
                .DeleteItemAsync($"{HouseApiConstants.HousesUrl}/{studentId}/{HouseApiConstants.AddresesUrl}/{addressId}");
        }

        public async Task DeleteGarage(int studentId, int garageId)
        {
            await _houseApiClient
                .DeleteItemAsync($"{HouseApiConstants.HousesUrl}/{studentId}/{HouseApiConstants.GaragesUrl}/{garageId}");
        }

        public async Task<Address[]> GetHouseAddresesAsync(int houseId)
        {
            var result = await _houseApiClient
                .GetItemsAsync<Address>($"{HouseApiConstants.HousesUrl}/{houseId}/{HouseApiConstants.AddresesUrl}");
            return result;
        }

        public async Task<Garage[]> GetHouseGaragesAsync(int houseId)
        {
            var result = await _houseApiClient
                .GetItemsAsync <Garage>($"{HouseApiConstants.HousesUrl}/{houseId}/{HouseApiConstants.GaragesUrl}");
            return result;
        }

        public async Task<House[]> GetHouseAsync()
        {
            var result = await _houseApiClient.GetItemsAsync<House>(HouseApiConstants.HousesUrl);
            return result;
        }

        public async Task UpdateHouseAsync(House house)
        {
            await _houseApiClient.UpdateItem<House>($"{HouseApiConstants.HousesUrl}/{house.Id}", house);
        }

        public async Task UpdateAddressAsync(Address address)
        {
            await _houseApiClient.UpdateItem<Address>($"{HouseApiConstants.AddresesUrl}/{address.Id}", address);
        }

        public async Task UpdateGarageAsync(Garage garage)
        {
            await _houseApiClient.UpdateItem<Garage>($"{HouseApiConstants.GaragesUrl}/{garage.Id}", garage);
        }

    }
}
