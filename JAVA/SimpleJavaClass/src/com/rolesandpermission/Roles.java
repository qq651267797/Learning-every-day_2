package com.rolesandpermission;

/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */
public class Roles {
    private int rolesId;
    private String rolesTitle;
    //多个部门具备一个角色
    private Section[] sections;
    //一个角色拥有多个权限
    private Permission[] permissions;

    public Roles() {
    }

    public Roles(int rolesId, String rolesTitle) {
        this.rolesId = rolesId;
        this.rolesTitle = rolesTitle;
    }

    public int getRolesId() {
        return rolesId;
    }

    public void setRolesId(int rolesId) {
        this.rolesId = rolesId;
    }

    public String getRolesTitle() {
        return rolesTitle;
    }

    public void setRolesTitle(String rolesTitle) {
        this.rolesTitle = rolesTitle;
    }

    public Section[] getSections() {
        return this.sections;
    }

    public void setSections(Section[] sections) {
        this.sections = sections;
    }

    public Permission[] getPermissions() {
        return permissions;
    }

    public void setPermissions(Permission[] permissions) {
        this.permissions = permissions;
    }

    public String grtInfo() {
        return "角色ID= " + this.rolesId + "，角色名称= " + this.rolesTitle;
    }
}
