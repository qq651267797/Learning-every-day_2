package com.complexjavaclass;

/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */

/**
 * 课程表
 * 课程编号，课程名称，学分
 */
public class Subject {
    private int subjectId;
    private String subjectName;
    private int subjectScore;
    private StudentAndSubjectRelation[] studentAndSubjectRelationArr;

    public Subject() {
    }

    public Subject(int subjectId, String subjectName, int subjectScore) {
        this.subjectId = subjectId;
        this.subjectName = subjectName;
        this.subjectScore = subjectScore;
    }

    public int getSubjectId() {
        return this.subjectId;
    }

    public void setSubjectId(int subjectId) {
        this.subjectId = subjectId;
    }

    public String getSubjectName() {
        return this.subjectName;
    }

    public void setSubjectName(String subjectName) {
        this.subjectName = subjectName;
    }

    public int getSubjectScore() {
        return this.subjectScore;
    }

    public void setSubjectScore(int subjectScore) {
        this.subjectScore = subjectScore;
    }

    public StudentAndSubjectRelation[] getStudentAndSubjectRelationArr() {
        return this.studentAndSubjectRelationArr;
    }

    public void setStudentAndSubjectRelationArr(StudentAndSubjectRelation[] studentAndSubjectRelationArr) {
        this.studentAndSubjectRelationArr = studentAndSubjectRelationArr;
    }

    public String getInfo() {
        return "课程ID= " + this.subjectId + ",课程名称= " + this.subjectName + ",课程分数= " + this.subjectScore;
    }

}
