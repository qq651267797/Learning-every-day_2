# 2019年7月2日09:30:02 #
**1.  自己写的ArraryList**
> 首先要实现的功能
> 
> 1. 自动扩张：当判断 定义的长度不够时，就自动扩张。*3/2+1
> 1. Add：在末尾增加。可以用Insert代替。Insert(0, item)Insert(Index, item)
> 1. AddFirst + AddAfter
> 1. Insert：在任意地点插入
> 1. DeleteFirset + DeleteAfter
> 1. Delete可以实现 Delete(0, item)Insert(Index, item)


 **2.  自己写的LinkList**
> 1. 首先要实现的功能
> 1. 自动扩张：当判断 定义的长度不够时，就自动扩张。*3/2+1
> 1. Add：在末尾增加。可以用Insert代替。Insert(0, item)Insert(Index, item)
> 1. AddFirst + AddAfterW
> 1. Insert：在任意地点插入
> 1. DeleteFirset + DeleteAfter
> 1. Delete可以实现 Delete(0, item)  Insert(Index, item)

for(int i =length-1;i>index;i--)
{
	list[]i = list[i-1];
	
]
list[index]=item;