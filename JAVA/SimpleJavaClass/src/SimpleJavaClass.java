//简单 JAVA类 和 数据表的转换
/**
 * 1，一个部门有多个雇员，并且可以输出一个部门的完整信息
 * （包括所有雇员的信息）
 * <p>
 * 2，可以根据一个雇员，找到领导的信息 和 雇员所在部门的信息
 */

/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */
public class SimpleJavaClass {
    public static void main(String[] args) {
        //new几个员工出来
        Employees employessOne = new Employees(1110, "feijm", "秘 书");
        Employees employeesTwo = new Employees(2220,"feijd","秘书长");
        Employees employeesThree = new Employees(3330,"feisq","总 裁");
        System.out.println(employessOne.getInfo());
        System.out.println(employeesTwo.getInfo());
        System.out.println(employeesThree.getInfo());
        //设置员工之间的关系
        employessOne.setLeader();
        Department departmentOne = new Department("电控评价","广东佛山");
        System.out.println(departmentOne.getInfo());
    }
}

class Employees {
    private int employeesId;
    public String employeesName;
    public String position;
    public Employees leader;
    public Department department;

    public Employees() {
    }

    public Employees(int employeesId, String employeesName, String position) {
        this.employeesId = employeesId;
        this.employeesName = employeesName;
        this.position = position;
    }

    public int getEmployeesId() {
        return this.employeesId;
    }

    public String getEmployeesName() {
        return this.employeesName;
    }

    public String getPosition() {
        return this.position;
    }

    public Department getDepartment() {
        return this.department;
    }

    public Employees getLeader() {
        return this.leader;
    }

    public void setEmployeesId(int employeesId) {
        this.employeesId = employeesId;
    }

    public void setEmployeesName(String employeesName) {
        this.employeesName = employeesName;
    }

    public void setPosition(String position) {
        this.position = position;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }

    public void setLeader(Employees leader) {
        this.leader = leader;
    }

    public String getInfo() {
        return "员工ID = " + this.employeesId + "，员工姓名 = " + this.employeesName + "，员工职位 = " + this.position;
    }
}

class Department {
    public String departmentName;
    public String departmentWorkPlace;
    public Employees[] employeesArr;

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

    public Employees[] getEmployeesArr() {
        return employeesArr;
    }

    public void setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
    }

    public void setDepartmentWorkPlace(String departmentWorkPlace) {
        this.departmentWorkPlace = departmentWorkPlace;
    }

    public void setEmployeesArr(Employees[] employeesArr) {
        this.employeesArr = employeesArr;
    }

    public String getInfo() {
        return "部门名称 = " + this.departmentName + "，部门工作地点 = " + this.departmentWorkPlace;
    }
}
