package com.complexjavaclass;
/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */

/**
 * 学生表：
 * 学生编号，姓名，年龄，
 */
public class Student {
    private int studentId;
    private String studentName;
    private int studentAge;
    private StudentAndSubjectRelation[] studentAndSubjectRelationArr;

    public Student() {
    }

    public Student(int studentId, String studentName, int studentAge) {
        this.studentId = studentId;
        this.studentName = studentName;
        this.studentAge = studentAge;
    }

    public int getStudentId() {
        return this.studentId;
    }

    public void setStudentId(int studentId) {
        this.studentId = studentId;
    }

    public String getStudentName() {
        return this.studentName;
    }

    public void setStudentName() {
        this.studentName = studentName;
    }

    public int getStudentAge() {
        return this.studentAge;
    }

    public void setStudentAge(int studentAge) {
        this.studentAge = studentAge;
    }

    public StudentAndSubjectRelation[] getStudentAndSubjectRelationArr() {
        return this.studentAndSubjectRelationArr;
    }

    public void setStudentAndSubjectRelationArr(StudentAndSubjectRelation[] studentAndSubjectRelationArr) {
        this.studentAndSubjectRelationArr = studentAndSubjectRelationArr;
    }

    public String getInfo() {
        return "学生ID= " + this.studentId + ",学生姓名= " + this.studentName + ",学生年龄= " + this.studentAge;
    }
}
