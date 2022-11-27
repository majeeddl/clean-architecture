using MediatR;

namespace DotNetCleanTemplate.Application.Products.Query.GetProductById
{
    public class GetProductByIdQuery : IRequest<ProductQueryModel>
    {
        public int ProductId { get; set; }
    }
}