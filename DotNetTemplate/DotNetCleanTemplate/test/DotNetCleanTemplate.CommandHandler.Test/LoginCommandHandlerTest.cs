using DotNetCleanTemplate.Common.Exceptions;
using DotNetCleanTemplate.Domain.Entities.Users;
using DotNetCleanTemplate.Domain.IRepositories;
using DotNetCleanTemplate.Persistence.CommandHandlers.Users;
using DotNetCleanTemplate.Persistence.Jwt;
using Microsoft.AspNetCore.Identity;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DotNetCleanTemplate.CommandHandler.Test
{
    public class LoginCommandHandlerTest
    {
        [Fact]
        public async Task Should_ThrowException_When_InputIsNull()
        {
            // Arrange
            var userStore = new Mock<IUserStore<User>>();
            userStore.Setup(x => x.FindByIdAsync("123", CancellationToken.None))
                .ReturnsAsync(new User()
                {
                    UserName = "testUserName",
                    Id = 123
                });

            var userManager = new UserManager<User>(userStore.Object, null, null, null, null, null, null, null, null);
            var jwtService = new Mock<IJwtService>();
            var refreshTokenRepository = new Mock<IRefreshTokenRepository>();

            // Act
            var commandHandler = new LoginCommandHandler(userManager, jwtService.Object, refreshTokenRepository.Object);

            // Assert
            await Assert.ThrowsAsync<InvalidNullInputException>(() => commandHandler.Handle(null, CancellationToken.None));
        }
    }
}
