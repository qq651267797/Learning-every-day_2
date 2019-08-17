package com.simplejavaclass;


/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */
public class SimpleJavaClass {
    public static void main(String[] args) {
        //new 几个对象  部门  与  员工
        Department development = new Department("开发", "广东");
        Department testing = new Department("测试", "广东");

        Person employeeOne = new Person(1111, "luoq2", "开发工程师");
        Person employeeTwo = new Person(2222, "feijm2", "测试工程师");
        Person employeeThree = new Person(3333, "lisj3", "开发工程师");
        Person employeeFour = new Person(4444, "zhuyp2", "测试工程师");

        //设置员工的领导与部门
        employeeOne.setDepartment(development);
        employeeTwo.setDepartment(testing);
        employeeThree.setDepartment(development);
        employeeFour.setDepartment(testing);

        employeeOne.setLeader(employeeThree);
        employeeTwo.setLeader(employeeThree);
        employeeFour.setLeader(employeeThree);
        //设置部门的员工数组
        development.setEmployeesArr(new Person[]{employeeOne, employeeThree});
        testing.setEmployeesArr(new Person[]{employeeTwo, employeeFour});

        //1，一个部门有多个雇员，并且可以输出一个部门的完整信息
        //（包括所有雇员的信息）
        System.out.println(development.getInfo());
        for (int i = 0; i < development.getEmployeeArr().length; i++) {
            System.out.println("\t|-" + development.getEmployeeArr()[i].getInfo());
        }
        System.out.println(testing.getInfo());
        for (int i = 0; i < testing.getEmployeeArr().length; i++) {
            System.out.println("\t|-" + testing.getEmployeeArr()[i].getInfo());
        }
        System.out.println("======================================================");
        //2，可以根据一个雇员，找到领导的信息 和 雇员所在部门的信息
        System.out.println("雇员1 ");
        System.out.println(employeeOne.getInfo());
        employeeOne.getDepartAndLeaderInfo(employeeOne);
        System.out.println("======================================================");

        System.out.println("雇员2 ");
        System.out.println(employeeTwo.getInfo());
        employeeTwo.getDepartAndLeaderInfo(employeeTwo);
        System.out.println("======================================================");

        System.out.println("雇员3 ");
        System.out.println(employeeThree.getInfo());
        employeeThree.getDepartAndLeaderInfo(employeeThree);
        System.out.println("======================================================");

        System.out.println("雇员4 ");
        System.out.println(employeeFour.getInfo());
        employeeFour.getDepartAndLeaderInfo(employeeFour);
        System.out.println("======================================================");

    }
}
