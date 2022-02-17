using ServicioCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreClientesWCF.Services
{
    public class ServiceCountries
    {
        //EL NOMBRE DEL OBJETO SIEMPRE SERA UN CLIENT
        //SE LLAMARA COMO EL NOMBRE DEL SERVICIO QUE HEMOS
        //VISTO EN LA ANTERIOR PANTALLA
        CountryInfoServiceSoapTypeClient client;

        public ServiceCountries()
        {
            this.client = new CountryInfoServiceSoapTypeClient
(CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);
        }

        public async Task<tCountryCodeAndName[]> 
            GetCountries()
        {
            ListOfCountryNamesByNameResponse response =
            await this.client.ListOfCountryNamesByNameAsync();
            tCountryCodeAndName[] objetos =
            response.Body.ListOfCountryNamesByNameResult;
            return objetos;
        }

        public async Task<tCountryInfo>
            GetCountryInfo(string isoCode)
        {
            FullCountryInfoResponse
                response = await this.client.FullCountryInfoAsync(isoCode);
            tCountryInfo country = response.Body.FullCountryInfoResult;
            return country;
        }
    }
}
