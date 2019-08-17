package com.simplejavaclass;

/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */
public class Department {
    private String departmentName;
    private String departmentWorkPlace;
    private Person[] employeeArr;

    public Department() {
    }

    public Department(String departmentName, String departmentWorkPlace) {
        this.departmentName = departmentName;
        this.departmentWorkPlace = departmentWorkPlace;
    }

    public String getDepartmentName() {
        return departmentName;
    }

    public String getDepartmentWorkPlace() {
        return departmentWorkPlace;
    }

    public Person[] getEmployeeArr() {
        return employeeArr;
    }

    public void setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
    }

    public void setDepartmentWorkPlace(String departmentWorkPlace) {
        this.departmentWorkPlace = departmentWorkPlace;
    }

    public void setEmployeesArr(Person[] employeesArr) {
        this.employeeArr = employeesArr;
    }

    public String getInfo() {
        return "部门名称 = " + this.departmentName + "，部门工作地点 = " + this.departmentWorkPlace;
    }
}
