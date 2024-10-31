
using KDG.UserManagement.Interfaces;

public class PermissionGroup<T> : IPermissionGroupBase<T> {
    public string Name { get; }
    private Func<string, T> _deserialize = x => (T)Convert.ChangeType(x, typeof(T));

    public T Deserialize(string input) => _deserialize(input);

    public PermissionGroup(string name, Func<string, T> deserialize)
    {
        Name = name;
        _deserialize = deserialize;
    }
}