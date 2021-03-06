using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.Api.HttpModels.GetMerchInfoForEmployee;
using OzonEdu.MerchandiseService.Api.HttpModels.OrderMerch;
using OzonEdu.MerchandiseService.Api.Services.Interfaces;

namespace OzonEdu.MerchandiseService.Api.Services
{
    public class MerchService : IMerchService
    {
        public Task<OrderMerchResponse> OrderMerch(OrderMerchRequest orderMerchRequest, CancellationToken cancellationToken)
        {
            return Task.FromResult(new OrderMerchResponse());
        }

        public Task<GetMerchInfoForEmployeeResponse> GetMerchInfoForEmployee(long employeeId, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetMerchInfoForEmployeeResponse());
        }
    }
}