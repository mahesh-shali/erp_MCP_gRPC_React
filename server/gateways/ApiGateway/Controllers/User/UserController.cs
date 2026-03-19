using Microsoft.AspNetCore.Mvc;
using Contracts.User;

namespace ApiGateway.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService.UserServiceClient _client;

    public UserController(UserService.UserServiceClient client)
    {
        _client = client;
    }

    // GET: api/user/1
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
        var response = await _client.GetUserAsync(new UserRequest
        {
            UserId = id
        });

        return Ok(new
        {
            response.Name
        });
    }
}