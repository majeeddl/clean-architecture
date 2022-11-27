using DotNetCleanTemplate.Application.Products.Command.AddProduct;
using DotNetCleanTemplate.Common.Exceptions;
using DotNetCleanTemplate.Persistence.CommandHandlers.Products;
using DotNetCleanTemplate.Persistence.Db;
using Microsoft.Extensions.Logging;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DotNetCleanTemplate.CommandHandler.Test
{
    public class AddProductCommandHandlerTest
    {
        [Fact]
        public async Task Should_ThrowException_When_InputIsNull()
        {
            var dbContext = new Mock<CleanArchWriteDbContext>();
            var logger = new Mock<ILogger<AddProductCommandHandler>>();

            var commandHandler = new AddProductCommandHandler(dbContext.Object, logger.Object);

            var request = new Mock<AddProductCommand>();

            //await Assert.ThrowsAsync<InvalidNullInputException>(() => commandHandler.Handle(request.Object, CancellationToken.None));
            await Assert.ThrowsAsync<InvalidNullInputException>(() => commandHandler.Handle(null, CancellationToken.None));
        }
    }
}