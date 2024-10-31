namespace KDG.UserManagement.Interfaces;

public interface IPermissionGroupBase<T>
{
    /// <summary>
    /// The unique identifier for this permission group
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Deserializes the stored permission group data into type T
    /// You will probably provide a static Func<string,T> here in *most* cases.
    /// </summary>
    public T Deserialize(string input);

}