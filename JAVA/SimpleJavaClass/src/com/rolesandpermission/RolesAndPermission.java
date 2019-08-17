package com.rolesandpermission;

/**
 * @Author:
 * @Project:
 * @Time:
 * @version:
 * @修改原因:
 */
public class RolesAndPermission {
    public static void main(String[] args) {
        //1，新建几个员工对象
        Person person10000 = new Person(10000, "1号财务");
        Person person20000 = new Person(20000, "2号市场");
        Person person30000 = new Person(30000, "3号财务");
        Person person40000 = new Person(40000, "4号市场");
        //新建几个部门对象
        Section section111 = new Section(111, "财务");
        Section section222 = new Section(222, "市场");
        //新建几个角色对象
        Roles roles100 = new Roles(100, "管理者");
        Roles roles200 = new Roles(200, "职员层");
        //新建几个权限对象
        Permission permission11111 = new Permission(11111, "雇员入职", "雇员入职");
        Permission permission22222 = new Permission(22222, "雇员升职", "雇员升职");
        Permission permission33333 = new Permission(33333, "雇员离职", "雇员离职");
        Permission permission44444 = new Permission(44444, "发布公告", "发布公告");
        Permission permission55555 = new Permission(55555, "查看客户信息", "查看客户信息");
        //建立角色与权限之间的关系
        roles100.setPermissions(new Permission[]{permission11111, permission22222, permission33333});
        roles200.setPermissions(new Permission[]{permission44444, permission55555});
        //建立权限与角色之间的对象
        permission11111.setRoles(roles100);
        permission22222.setRoles(roles100);
        permission33333.setRoles(roles100);
        permission44444.setRoles(roles200);
        permission55555.setRoles(roles200);
        //建立部门与角色之间的关系
        section111.setRoles(roles100);
        section222.setRoles(roles200);
        //建立角色与部门之间的关系
        roles100.setSections(new Section[]{section111});
        roles200.setSections(new Section[]{section222});
        //设置员工和部门之间的关系
        person10000.setSection(section111);
        person30000.setSection(section111);
        person20000.setSection(section222);
        person40000.setSection(section222);
        //设置部门和员工之间的关系
        section111.setPersonArr(new Person[]{person10000, person30000});
        section222.setPersonArr(new Person[]{person20000, person40000});

        //取出相应的数据
        //要求1 可以根据一个员工找到他的部门，以及该部门对应的角色，以及每个角色对应的所有的权限
        System.out.println(person10000.getInfo());
        System.out.println(person10000.getSection().getInfo());
        System.out.println(person10000.getSection().getRoles().grtInfo());
        for (int i = 0; i < person10000.getSection().getRoles().getPermissions().length; i++) {
            System.out.println(person10000.getSection().getRoles().getPermissions()[i].getInfo());
        }
        System.out.println("============================================================");
        //可以根据一个角色，找到所有具备此角色的所有部门，以及该部门所有的员工
        System.out.println(roles100.grtInfo());
        for (int i = 0; i < roles100.getSections().length; i++) {
            System.out.println(roles100.getSections()[i].getInfo());
            for (int j = 0; j < roles100.getSections()[i].getPersonArr().length; j++) {
                System.out.println(roles100.getSections()[i].getPersonArr()[j].getInfo());
            }
        }
        System.out.println("============================================================");
        //根据权限列出，所有具备该权限的所有的角色，以及每一个角色下对应的所有部门，以及每个部门的员工
        System.out.println(permission11111.getInfo());
        System.out.println(permission11111.getRoles().grtInfo());
        for (int i = 0; i < permission11111.getRoles().getSections().length; i++) {
            System.out.println(permission11111.getRoles().getSections()[i].getInfo());
            for (int j = 0; j < permission11111.getRoles().getSections()[i].getPersonArr().length; j++) {
                System.out.println(permission11111.getRoles().getSections()[i].getPersonArr()[j].getInfo());
            }
        }

    }
}
