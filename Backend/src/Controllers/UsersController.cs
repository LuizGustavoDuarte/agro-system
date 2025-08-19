using Microsoft.AspNetCore.Mvc;

[Controller]
public class UsersController {

    IUsersService _usersService;

    public UsersController(IUsersService usersService) {
        _usersService = usersService;
    }

    [HttpGet("/{name}")]
    public string returnUserPlaceholderString(string name) {
        string helloString = _usersService.getHelloString(name);
        return helloString;
    }
}