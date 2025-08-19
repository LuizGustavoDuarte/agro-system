public class UsersService : IUsersService{
    public string getHelloString(string name) {
        return "Hello, { " + name + " } ";
    }
}