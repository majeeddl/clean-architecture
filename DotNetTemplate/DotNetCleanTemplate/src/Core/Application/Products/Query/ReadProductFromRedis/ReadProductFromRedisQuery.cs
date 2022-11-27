using MediatR;

namespace DotNetCleanTemplate.Application.Products.Query.ReadProductFromRedis
{
    public class ReadProductFromRedisQuery : IRequest<ReadProductFromRedisResponse>
    {
        public ReadProductFromRedisQuery(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
    }
}
