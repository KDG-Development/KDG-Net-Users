using KDG.UserManagement.Interfaces;

public class Permission<T> : IPermissionBase<T>
{
    public string Name { get; }
    private readonly Func<string, T> _deserialize = x => (T)Convert.ChangeType(x, typeof(T));

    public T Deserialize(string input) => _deserialize(input);

    public Permission(string name, Func<string, T> deserialize)
    {
        Name = name;
        _deserialize = deserialize;
    }
}
