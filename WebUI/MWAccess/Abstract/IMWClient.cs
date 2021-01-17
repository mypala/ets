using ResponseStates.Models;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.MWAccess.Abstract
{
    public interface IMWClient
    {
        ResponseState<TResponse> GetJSON<TResponse>(Connection connection);
        ResponseState PostJSON<TRequest>(Connection<TRequest> connection);
        ResponseState<TResponse> PostJSON<TResponse, TRequest>(Connection<TRequest> connection);
    }
}
