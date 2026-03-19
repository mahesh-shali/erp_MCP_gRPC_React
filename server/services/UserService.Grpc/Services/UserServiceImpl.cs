using Contracts.User;
using Grpc.Core;

namespace UserService.Grpc.Services;

public class UserServiceImpl : Contracts.User.UserService.UserServiceBase
{
    public override Task<UserReply> GetUser(UserRequest request, ServerCallContext context)
    {
        var user = new UserReply
        {
            Name = $"User-{request.UserId}"
        };

        return Task.FromResult(user);
    }
}