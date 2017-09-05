using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoExchangeFarmer.Handlers
{
    public interface IServicesHandler
    {
        Task<dynamic> Get(string path);
        void Post(string path, HttpContent body);
        Task<dynamic> Put(string path, HttpContent body);
        void Delete(string path);
    }
}
