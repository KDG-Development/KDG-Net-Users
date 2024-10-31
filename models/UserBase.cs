using KDG.UserManagement.Interfaces;

namespace KDG.UserManagement.Models;

public class UserBase<TPermissionGroup, TPermission> : IUserBase<TPermissionGroup, TPermission>
{
    public Guid Id { get; set; }
    public HashSet<IPermissionGroupBase<TPermissionGroup>> PermissionGroups { get; set; } = new();
    public HashSet<IPermissionBase<TPermission>> Permissions { get; set; } = new();

    public UserBase()
    {
        Id = Guid.NewGuid();
    }

    public UserBase(Guid id)
    {
        Id = id;
    }
}
