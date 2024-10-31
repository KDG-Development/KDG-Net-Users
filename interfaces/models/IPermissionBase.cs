namespace KDG.UserManagement.Interfaces;

public interface IPermissionBase<T>
{
    /// <summary>
    /// The unique identifier for this permission
    /// </summary>
    public string Name { get; }
    
    /// <summary>
    /// Deserializes the stored permission data into type T
    /// You will probably provide a static Func<string,T> here in *most* cases.
    /// </summary>
    public T Deserialize(string input);
}