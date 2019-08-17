package com.simplejavaclass;

/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */
public class Person {
    //id,姓名，年龄等等，，都需要进行限制，负数等
    private int supremeLeader = 0;
    private int employeeId;
    private String employeeName;
    private String position;
    private Person leader;
    private Department department;

    public Person() {
    }

    public Person(int employeeId, String employeeName, String position) {
        this.employeeId = employeeId;
        this.employeeName = employeeName;
        this.position = position;
    }

    public int getEmployeeId() {
        return this.employeeId;
    }

    public String getEmployeeName() {
        return this.employeeName;
    }

    public String getPosition() {
        return this.position;
    }

    public Department getDepartment() {
        return this.department;
    }

    public Person getLeader() {
        return this.leader;
    }

    public void setEmployeeId(int employeeId) {
        this.employeeId = employeeId;
    }

    public void setEmployeeName(String employeeName) {
        this.employeeName = employeeName;
    }

    public void setPosition(String position) {
        this.position = position;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }

    public void setLeader(Person leader) {
        this.leader = leader;
    }

    public String getInfo() {
        return "员工ID = " + this.employeeId + "，员工姓名 = " + this.employeeName + "，员工职位 = " + this.position;
    }

    public void getDepartAndLeaderInfo(Person employee) {
        if (employee.getDepartment() != null) {
            System.out.println("\t|-" + employee.getDepartment().getInfo());
        } else {
            if (employee.getEmployeeId() == supremeLeader) {
                System.out.println(", 他的身份是 = " + employee.getInfo());
                return;
            } else {
                System.out.println("\t|-该员工没有部门，有异常");
            }

        }
        if (employee.getLeader() != null) {
            System.out.println("\t|-Leader = " + employee.getLeader().getInfo());
        } else {
            if (employee.getEmployeeId() == supremeLeader) {
                System.out.println("\t|-他的身份是 = " + employee.getInfo());
                return;
            } else {
                System.out.println("\t|-该员工没有领导，有异常");
            }
        }
    }
}
