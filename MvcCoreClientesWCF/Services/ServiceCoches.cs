using ReferenceCochesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreClientesWCF.Services
{
    public class ServiceCoches
    {
        private CochesContractClient client;

        public ServiceCoches(CochesContractClient client)
        {
            this.client = client;
        }

        public async Task<Coche[]> GetCochesAsync()
        {
            Coche[] cars =
                await this.client.GetCochesAsync();
            return cars;
        }

        public async Task<Coche> FindCocheAsync(int id)
        {
            Coche car = await this.client.FindCocheAsync(id);
            return car;
        }
    }
}
