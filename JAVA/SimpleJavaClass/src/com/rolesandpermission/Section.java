package com.rolesandpermission;

/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */
public class Section {
    //部门Id
    private int sectionId;
    //部门名字名字
    private String sectionName;
    //部门数组。包含多个员工
    private com.rolesandpermission.Person[] personArr;
    //每个部门，只有一个角色ID
    private Roles roles;

    public Section() {
    }

    public Section(int sectionId, String sectionName) {
        this.sectionId = sectionId;
        this.sectionName = sectionName;
    }

    public int getSectionId() {
        return this.sectionId;
    }

    public void setSectionId(int sectionId) {
        this.sectionId = sectionId;
    }

    public String getSectionName() {
        return this.sectionName;
    }

    public void setSectionName(String sectionName) {
        this.sectionName = sectionName;
    }

    public Roles getRoles() {
        return this.roles;
    }

    public void setRoles(Roles roles) {
        this.roles = roles;
    }

    public com.rolesandpermission.Person[] getPersonArr() {
        return this.personArr;
    }

    public void setPersonArr(Person[] personArr) {
        this.personArr = personArr;
    }

    public String getInfo() {
        return "部门ID= " + this.sectionId + "，部门名称= " + this.sectionName;
    }
}
