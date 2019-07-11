//简单 JAVA类 和 数据表的转换
/**
 * 1，一个部门有多个雇员，并且可以输出一个部门的完整信息
 *（包括所有雇员的信息）
 *
 *2，可以根据一个雇员，找到领导的信息 和 雇员所在部门的信息
 * */
public class SimpleJAVCclass {
    public static void main(String[] args) {
        //设置类对象间的关系
        //分别创建各自的实例化对象
        Department Dept = new Department(
                99999999,
                "Granmmer",
                "HuNan");
        Employee EmpOne = new Employee(
                1234,
                "Feijm",
                "Granm",
                1000.0,
                0.0);
        Employee EmpTwo = new Employee(
                12345,
                "FeiJD",
                "TeamLeader",
                2000.0,
                1.0);
        Employee EmpThree = new Employee(
                123456789,
                "FeiSX",
                "President",
                4000.0,
                10.0);

        //设置雇员的领导关系
        EmpOne.setLeader(EmpTwo);
        EmpTwo.setLeader(EmpThree); //EmpThree没有领导，因为他是头
        //设置雇员的部门关系
        EmpOne.setDepartment(Dept);
        EmpTwo.setDepartment(Dept);
        EmpThree.setDepartment(Dept);
        //设置部门和雇员的关系
        Dept.setEmployees(new Employee[]{EmpOne, EmpTwo, EmpThree});

        //取得数据之间的关系
        //输出部门的信息
        System.out.println("============================");
        System.out.println(Dept.getInfo()); //输出部门的信息
        for (int i = 0; i < Dept.getEmployees().length; i++) {
            System.out.println("\t|- " + Dept.getEmployees()[i].getInfo());
            //有领导可以输出，没领导则不输出
            if (Dept.getEmployees()[i].getLeader() != null) {
                System.out.println("\t\t|- " + Dept.getEmployees()[i].getLeader().getInfo());
            }
        }
        System.out.println("============================");
        //可以根据雇员的信息，找到对应的领导和雇员所在部门的信息
        System.out.println(EmpTwo.getInfo());
        if (EmpTwo.getLeader() != null) {
            System.out.println("\t|- " + EmpTwo.getLeader().getInfo());
        }
        if (EmpTwo.getDepartment() != null) {
            System.out.println("\t|- " + EmpTwo.getDepartment().getInfo());
        }
    }
}

class Employee {
    private int EmployeeNumber;     //员工编号
    private String EmployeeName;    //员工名字
    private String EmployeePosition;//员工职位
    private double EmployeeSalary;  //员工工资
    private double EmployeeMM;
    private Employee Leader;        //描述雇员领导
    private Department Department;  //描述雇员所在部门

    //leader 领导
    public Employee() {
    }

    public Employee(int employeeNumber,
                    String employeeName,
                    String employeePosition,
                    double sal,
                    double companyMM) {

        this.EmployeeNumber = employeeNumber;
        this.EmployeeName = employeeName;
        this.EmployeePosition = employeePosition;
        this.EmployeeSalary = sal;
        this.EmployeeMM = companyMM;
    }

    public void setLeader(Employee leader) {
        this.Leader = leader;
    }

    public Employee getLeader() {
        return this.Leader;
    }

    public void setDepartment(Department department) {
        this.Department = department;
    }

    public Department getDepartment() {
        return this.Department;
    }

    public String getInfo() {
        return "EmployeeNumber = " + this.EmployeeNumber +
                " ; EmployeeName = " + this.EmployeeName +
                " ; EmployeePosition = " + this.EmployeePosition +
                " ; EmployeeSalary = " + this.EmployeeSalary +
                " ; EmployeeMM = " + this.EmployeeMM;
    }
}

class Department {
    private int DepartmentNumber;   //部门编号
    private String DeptCompanyName; //部门名称
    private String JobPlace;        //工作地点
    private Employee[] Employees;

    public Department() {
    }

    public Department(int deptCompanyNo,
                      String deptCompanyName,
                      String jobPlace) {
        this.DeptCompanyName = deptCompanyName;
        this.DepartmentNumber = deptCompanyNo;
        this.JobPlace = jobPlace;
    }

    public void setEmployees(Employee[] employees) {
        this.Employees = employees;
    }

    public Employee[] getEmployees() {
        return Employees;
    }

    public String getInfo() {
        return "deptCompanyNumber = " + DepartmentNumber +
                " ; deptCompanyName = " + DeptCompanyName +
                " ; jobPlace = " + JobPlace;
    }
}

