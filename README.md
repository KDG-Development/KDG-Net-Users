# Getting started

1. Extend the `UserBase` with your own needs

```
// example extended user with email

public class User : UserBase<string, string>
{
    public string Email { get; set; }

    public User() : base()
    {
        Email = string.Empty;
    }

    public User(Guid id) : base(id) 
    {
        Email = string.Empty;
    }

    public User(Guid id, string email) : base(id)
    {
        Email = email;
    }
}
```

2. Then parse the user at applicable call-sites

```
// example parsing user from a single SQL query result
// for simplicity, we serialize to a simple string, but you might use a more advanced type

return new User {
    Id = result.Id,
    Email = result.Email,
    PermissionGroups =
        new HashSet<IPermissionGroupBase<string>>(
            result.PermissionGroups.Select(group => new PermissionGroup<string>(group, s => s))
        ),
    Permissions =
        new HashSet<IPermissionBase<string>>(
            result.Permissions.Select(permission => new Permission<string>(permission, s => s))
        ),
};
```

## Support

For support, please open an issue on our [GitHub Issues page](https://github.com/KDG-Development/KDG-Net-Users/issues) and provide your questions or feedback. We strive to address all inquiries promptly.

## Contributing

To contribute to this project, please follow these steps:

1. Fork the repository to your own GitHub account.
2. Make your changes and commit them to your fork.
3. Submit a pull request to the original repository with a clear description of what your changes do and why they should be included.
