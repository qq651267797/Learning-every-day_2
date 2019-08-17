package com.complexjavaclass;

/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */

/**
 * 学生--课程关系表
 * 学生编号，课程编号，成绩
 */
public class StudentAndSubjectRelation {
    private Student student;
    private Subject subject;
    private int results;

    public StudentAndSubjectRelation() {

    }

    public StudentAndSubjectRelation(Student student, Subject subject, int results) {
        this.student = student;
        this.subject = subject;
        this.results = results;
    }

    public Student getStudent() {
        return this.student;
    }

    public void setStudent(Student student) {
        this.student = student;
    }

    public Subject getSubject() {
        return this.subject;
    }

    public void setSubject(Subject subject) {
        this.subject = subject;
    }

    public int getResults() {
        return this.results;
    }

    public void setResults(int results) {
        this.results = results;
    }

    public String getInfo() {
        return "学生姓名= " + this.student + ",课程名称= " + this.subject + ",成绩= " + this.results;
    }
}
