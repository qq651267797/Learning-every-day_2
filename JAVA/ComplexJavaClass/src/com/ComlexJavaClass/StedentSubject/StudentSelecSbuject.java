package com.ComlexJavaClass.StedentSubject;
//复杂 JAVA类 和 数据表的转换

/**
 * 1，可以找到一门课程，以及参加此课程的所有学生信息 以及 成绩
 * 2，可以根据一个学生，找到所参加的所有课程 和 每门课程的成绩
 */
public class StudentSelecSbuject {
    public static void main(String[] args) {
        //第一步 根据结构，设置对象间的关系
        //1，创建各自的独立对象
        Student studentOne = new Student(
                10075,
                "费久猛",
                23);
        Student studentTwo = new Student(
                10076,
                "费久鼎",
                13);
        Student studentThree = new Student(
                10077,
                "费俊乔",
                8);
        Subject subjectOne = new Subject(
                1001,
                "高数",
                10);
        Subject subjectTwo = new Subject(
                1002,
                "英语",
                10);
        Subject subjectThree = new Subject(
                1003,
                "法语",
                10);
        //2，需要设置学生和课程的关系，这里需要准备出成绩
        studentOne.setStudentSubjectResultArrary(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentOne, subjectOne, 91.0),
                new StudentAndSubjectRelation(studentOne, subjectTwo, 81),
                new StudentAndSubjectRelation(studentOne, subjectThree, 61)
        });
        studentTwo.setStudentSubjectResultArrary(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentTwo, subjectTwo, 72)
        });
        studentThree.setStudentSubjectResultArrary(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentThree, subjectOne, 63),
                new StudentAndSubjectRelation(studentThree, subjectTwo, 73),
        });
        //3，设置课程和时间关系，
        subjectOne.setStudentSubjectResultArrary(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentOne, subjectOne, 91.0),
                new StudentAndSubjectRelation(studentThree, subjectOne, 63)
        });
        subjectTwo.setStudentSubjectResultArrary(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentOne, subjectTwo, 81),
                new StudentAndSubjectRelation(studentTwo, subjectTwo, 72),
                new StudentAndSubjectRelation(studentThree, subjectTwo, 73)
        });
        subjectThree.setStudentSubjectResultArrary(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentOne, subjectThree, 61),
        });
        //第二步 根据结构，取出数据
        //1，找一门课程，找到参加此课程的所有学生的信息，以及他们的成绩。
        System.out.println("===================================");
        System.out.println(subjectOne.getInfo());
        for (int i = 0; i < subjectOne.getStudentSubjectResultArrary().length; i++) {
            System.out.print("\t|- " +
                    subjectOne.getStudentSubjectResultArrary()[i].getStudent().getInfo());
            System.out.print("，成绩：" + subjectOne.getStudentSubjectResultArrary()[i].getResult());
            System.out.println();
        }
        //2，可以根据一个学生，找到所参加的所有课程 和 每门课程的成绩
        System.out.println("===================================");
        System.out.println(studentOne.getInfo());
        for (int i = 0;i<studentOne.getStudentSubjectResultArrary().length;i++){
            System.out.print("\t|- " +
                    studentOne.getStudentSubjectResultArrary()[i].getSubject().getInfo());
            System.out.print("，成绩：" + studentOne.getStudentSubjectResultArrary()[i].getResult());
            System.out.println();
        }

    }
}

/**
 * 学生表：
 * 学生编号，姓名，年龄，
 */
class Student {
    private int StudentId;
    private String StudentName;
    private int StudentAge;
    //    private Subject[] SubjectArrary;
    private StudentAndSubjectRelation[] StudentSubjectResultArrary;

    public Student() {
    }

    public Student(int studentNumber, String studentName, int studentAge) {
        this.StudentId = studentNumber;
        this.StudentName = studentName;
        this.StudentAge = studentAge;
    }

    public int getStudentId() {
        return this.StudentId;
    }

    public String getStudentName() {
        return this.StudentName;
    }

    public int getStudentAge() {
        return this.StudentAge;
    }

//    public Subject[] getSubjectArrary() {
//        return this.SubjectArrary;
//    }

    public StudentAndSubjectRelation[] getStudentSubjectResultArrary() {
        return StudentSubjectResultArrary;
    }


    public void setStudentId(int studentId) {
        this.StudentId = studentId;
    }

    public void setStudentName(String studentName) {
        this.StudentName = studentName;
    }

    public void setStudentAge(int studentAge) {
        this.StudentAge = studentAge;
    }

//    public void setSubjectArrary(Subject[] subjectArrary) {
//        this.SubjectArrary = subjectArrary;
//    }

    public void setStudentSubjectResultArrary(StudentAndSubjectRelation[] studentSubjectResultArrary) {
        StudentSubjectResultArrary = studentSubjectResultArrary;
    }

    public String getInfo() {
        return "学生信息: StudentId：" + this.StudentId +
                " ; StudentName：" + this.StudentName +
                " ; StudentAge：" + this.StudentAge;
    }
}

/**
 * 课程表
 * 课程编号，课程名称，学分
 */
class Subject {
    private int SubjectId;
    private String SubjectName;
    private int SubjectCredit;
    //    private Student[] StudentArrary;
    private StudentAndSubjectRelation[] StudentSubjectResultArrary;

    public Subject() {
    }

    public Subject(int subjectNumber, String subjectName, int subjectResult) {
        this.SubjectId = subjectNumber;
        this.SubjectName = subjectName;
        this.SubjectCredit = subjectResult;
    }

    public int getSubjectId() {
        return this.SubjectId;
    }

    public String getSubjectName() {
        return this.SubjectName;
    }

    public int getSubjectCredit() {
        return this.SubjectCredit;
    }

//    public Student[] getStudentArrary() {
//        return this.StudentArrary;
//    }

    public StudentAndSubjectRelation[] getStudentSubjectResultArrary() {
        return StudentSubjectResultArrary;
    }

    public void setSubjectId(int subjectId) {
        this.SubjectId = subjectId;
    }

    public void setSubjectName(String subjectName) {
        this.SubjectName = subjectName;
    }

    public void setSubjectCredit(int subjectCredit) {
        this.SubjectCredit = subjectCredit;
    }

//    public void setStudentArrary(Student[] studentArrary) {
//        this.StudentArrary = studentArrary;
//    }

    public void setStudentSubjectResultArrary(StudentAndSubjectRelation[] studentSubjectResultArrary) {
        StudentSubjectResultArrary = studentSubjectResultArrary;
    }

    public String getInfo() {
        return "课程信息：SubjectId：" + this.SubjectId +
                " ; SubjectName：" + this.SubjectName +
                " ; SubjectCredit：" + this.SubjectCredit;
    }
}

/**
 * 学生--课程关系表
 * 学生编号，课程编号，成绩
 */
class StudentAndSubjectRelation {
    private Student Student;
    private Subject Subject;
    private double Result;

    public StudentAndSubjectRelation() {

    }

    public StudentAndSubjectRelation(Student student, Subject subject, double result) {
        this.Student = student;
        this.Subject = subject;
        this.Result = result;
    }

    public Student getStudent() {
        return this.Student;
    }

    public Subject getSubject() {
        return this.Subject;
    }

    public double getResult() {
        return this.Result;
    }

    public void setStudent(Student student) {
        this.Student = student;
    }

    public void setSubject(Subject subject) {
        this.Subject = subject;
    }

    public void setResult(double result) {
        this.Result = result;
    }

    public String getInfo() {
        return "课程和学生信息：Student：" + this.Student +
                "Subject" + this.Subject +
                "Result" + this.Result;
    }
}

