package com.complexjavaclass;

/**
 * 1，可以找到一门课程，以及参加此课程的所有学生信息 以及 成绩
 * 2，可以根据一个学生，找到所参加的所有课程 和 每门课程的成绩
 */
public class FinalOutput {
    public static void main(String[] args) {
        //new 几个学生 和 课程
        Student studentOne = new Student(10000, "一号", 11);
        Student studentTwo = new Student(20000, "二号", 22);
        Student studentThree = new Student(30000, "三号", 33);
        Student studentFour = new Student(40000, "四号", 44);

        System.out.println(studentOne.getInfo());
        System.out.println(studentTwo.getInfo());
        System.out.println(studentThree.getInfo());

        Subject subjectOne = new Subject(111, "语文", 10);
        Subject subjectTwo = new Subject(222, "数学", 10);
        Subject subjectThree = new Subject(333, "外语", 10);

        System.out.println(subjectOne.getInfo());
        System.out.println(subjectTwo.getInfo());
        System.out.println(subjectThree.getInfo());

        System.out.println("==============================================");
        //设置这几个 学生 和 课程之间的关系
        studentOne.setStudentAndSubjectRelationArr(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentOne, subjectOne, 11),
                new StudentAndSubjectRelation(studentOne, subjectTwo, 11),
                new StudentAndSubjectRelation(studentOne, subjectThree, 11)
        });
        studentTwo.setStudentAndSubjectRelationArr(new StudentAndSubjectRelation[]{
                //new StudentAndSubjectRelation(studentTwo, subjectOne, 22),
                new StudentAndSubjectRelation(studentTwo, subjectTwo, 22),
                new StudentAndSubjectRelation(studentTwo, subjectThree, 22)
        });
        studentThree.setStudentAndSubjectRelationArr(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentThree, subjectOne, 33),
                //new StudentAndSubjectRelation(studentThree, subjectTwo, 11),
                //new StudentAndSubjectRelation(studentThree, subjectTwo, 11)
        });
        subjectOne.setStudentAndSubjectRelationArr(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentOne, subjectOne, 11),
                new StudentAndSubjectRelation(studentThree, subjectOne, 33),
        });
        subjectTwo.setStudentAndSubjectRelationArr(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentOne, subjectTwo, 11),
                new StudentAndSubjectRelation(studentTwo, subjectTwo, 22),
        });
        subjectThree.setStudentAndSubjectRelationArr(new StudentAndSubjectRelation[]{
                new StudentAndSubjectRelation(studentOne, subjectThree, 11),
                new StudentAndSubjectRelation(studentTwo, subjectThree, 22),
        });
        System.out.println("==============================================");
        //1，可以找到一门课程，以及参加此课程的所有学生信息 以及 成绩
        System.out.println(subjectOne.getInfo());
        for (int i = 0; i < subjectOne.getStudentAndSubjectRelationArr().length; i++) {
            System.out.println("\t|-" + subjectOne.getStudentAndSubjectRelationArr()[i].getStudent().getInfo());
            System.out.println("\t|该学生的成绩为| = " + subjectOne.getStudentAndSubjectRelationArr()[i].getResults());
        }
        System.out.println("==============================================");
        //2，可以根据一个学生，找到所参加的所有课程 和 每门课程的成绩
        System.out.println(studentOne.getInfo());
        for (int i = 0; i < studentOne.getStudentAndSubjectRelationArr().length; i++) {
            System.out.println("\t|-" + studentOne.getStudentAndSubjectRelationArr()[i].getSubject().getInfo());
            System.out.println("\t|该学生的成绩为|=" + studentOne.getStudentAndSubjectRelationArr()[i].getResults());
        }
    }
}
