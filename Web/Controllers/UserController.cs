using Application;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBoilerplate.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    private readonly UserService service;

    public UserController(UserService userService)
    {
        service = userService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(string name, string email)
    {
        await service.Create(name, email);

        return CreatedAtAction(nameof(Create), null);
    }
}
