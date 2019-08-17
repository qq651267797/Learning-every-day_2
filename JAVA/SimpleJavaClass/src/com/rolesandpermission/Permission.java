package com.rolesandpermission;


public class Permission {
    //权限ID
    //权限名称
    //权限标记
    private int permissionId;
    private String permissionName;
    private String permissionFlag;
    private Roles roles;

    public Permission() {
    }

    public Permission(int permissionId, String permissionName, String permissionFlag) {
        this.permissionId = permissionId;
        this.permissionName = permissionName;
        this.permissionFlag = permissionFlag;
    }

    public int getPermissionId() {
        return this.permissionId;
    }

    public void setPermissionId(int permissionId) {
        this.permissionId = permissionId;
    }

    public String getPermissionName() {
        return this.permissionName;
    }

    public void setPermissionName(String permissionName) {
        this.permissionName = permissionName;
    }

    public String getPermissionFlag() {
        return this.permissionFlag;
    }

    public void setPermissionFlag(String permissionFlag) {
        this.permissionFlag = permissionFlag;
    }

    public Roles getRoles() {
        return this.roles;
    }

    public void setRoles(Roles roles) {
        this.roles = roles;
    }

    public String getInfo() {
        return "权限Id= " + this.permissionId + ",权限名字= " + this.permissionName + ",权限标志= " + this.permissionFlag;
    }
}
