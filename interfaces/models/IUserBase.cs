namespace KDG.UserManagement.Interfaces;

public interface IUserBase<TPermissionGroup,TPermission> {
    public System.Guid Id { get; set;}
    public HashSet<IPermissionGroupBase<TPermissionGroup>> PermissionGroups { get; set; }
    public HashSet<IPermissionBase<TPermission>> Permissions { get; set; }
}