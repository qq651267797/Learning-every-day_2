package com.rolesandpermission;

public class Person {
    //雇员ID
    private int personId;
    //雇员的姓名
    private String personName;
    //一个雇员属于一个部门
    private Section section;

    public Person() {
    }

    public Person(int personId, String personName) {
        this.personId = personId;
        this.personName = personName;
    }

    public int getPersonId() {
        return this.personId;
    }

    public void setPersonId(int personId) {
        this.personId = personId;
    }

    public String getPersonName() {
        return this.personName;
    }

    public void setPersonName(String personName) {
        this.personName = personName;
    }

    public Section getSection() {
        return this.section;
    }

    public void setSection(Section section) {
        this.section = section;
    }

    public String getInfo() {
        return "员工ID= " + this.personId + "，员工姓名= " + this.personName;
    }
}
