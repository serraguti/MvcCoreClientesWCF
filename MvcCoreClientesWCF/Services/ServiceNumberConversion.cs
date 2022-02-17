using ReferenceNumberConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ReferenceNumberConversion.NumberConversionSoapTypeClient;

namespace MvcCoreClientesWCF.Services
{
    public class ServiceNumberConversion
    {
        private NumberConversionSoapTypeClient client;

        public ServiceNumberConversion
            (NumberConversionSoapTypeClient client)
        {
            this.client = client;
            //new NumberConversionSoapTypeClient
            //   (EndpointConfiguration.NumberConversionSoap);
        }

        public async Task<string> GetNumberToWords(int numero)
        {
            NumberToWordsResponse response =
            await this.client.NumberToWordsAsync((ulong)numero);
            string result = response.Body.NumberToWordsResult;
            return result;
        }
    }
}
