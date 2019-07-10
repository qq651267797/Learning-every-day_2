package com.MyArr.Arrary;



public class ArraryList {
    public static void main(String[] args) {
        ArraryDemo ff = new ArraryDemo();
        Object[] gg = new Object[]{100,6,7,8,96,5,6,400};
        //Object Input = 11;
        for (Object i : gg){
            ff.AddLast(i);
        }
        ff.DeleteFirst();
        ff.PrintArrary();
        System.out.println();

        ff.DeleteLast();
//        ff.AddFirst(1);
//        ff.Insert(1,111);
//        System.out.println(ff.GetMin());
//        System.out.println(ff.GetMax());
        System.out.println();
        ff.PrintArrary();
        System.out.println();
        ff.DeleteIndex(1);
        ff.PrintArrary();
    }


}
