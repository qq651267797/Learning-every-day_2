package com.vince.tree;

/**
 * �����

 *
 */
public class RBTree {

	RBTreeNode nulNode = new RBTreeNode();
	RBTreeNode root = nulNode;
	
	public RBTree(){
		this.nulNode.color = "B";
		this.nulNode.data = -1;
		this.nulNode.lchild = nulNode;
		this.nulNode.rchild = nulNode;
	}
	
	/**
	 * ��������
	 * @param t
	 * @param data
	 */
	public void insert(RBTree t,int data){
		RBTreeNode x = t.root;
		RBTreeNode y = nulNode;
		RBTreeNode node = new RBTreeNode();
		node.data = data;
		
		while(x != nulNode){
			y = x;
			if(node.data<x.data){
				x = x.lchild;
			}else{
				x = x.rchild;
			}
		}
		node.parent = y;
		if(y == nulNode){
			root = node;
		}else if(node.data<y.data){
			y.lchild = node;
		}else{
			y.rchild = node;
		}
		node.color = "R";
		node.lchild = nulNode;
		node.rchild = nulNode;
		insertRotate(t, node);//����
		
	}
	
	public void insertRotate(RBTree t,RBTreeNode node){
		RBTreeNode y = nulNode;
		while(node.parent.color.equals("R")){
			if(node.parent == node.parent.parent.lchild){
				y = node.parent.parent.rchild;
				if(y.color.equals("R")){
					node.parent.color = "B";
					y.color = "B";
					node.parent.parent.color = "R";
					node = node.parent.parent;
				}else{
					if(node == node.parent.rchild){
						node = node.parent;
						leftRotate(t, node);
					}
					node.parent.color = "B";
					node.parent.parent.color = "R";
					RightRotate(t, node.parent.parent);
				}
			}else{
				y = node.parent.parent.lchild;
				if(y.color.equals("R")){
					node.parent.color = "B";
					y.color = "B";
					node.parent.parent.color = "R";
					node = node.parent.parent;
				}else{
					if(node==node.parent.lchild){
						node = node.parent;
						RightRotate(t, node);
					}
					node.parent.color = "B";
					node.parent.parent.color = "R";
					leftRotate(t, node.parent.parent);
				}
			}
		}
		t.root.color = "B";
	}
	
	
	private void leftRotate(RBTree t,RBTreeNode node){
		RBTreeNode y = node.rchild;
		node.rchild = y.lchild;
		if(y.lchild != nulNode){
			y.lchild.parent = node;
		}
		y.parent = node.parent;
		
		if(node.parent == nulNode){
			t.root = y;
		}else if(node==node.parent.lchild){
			node.parent.lchild = y;
		}else{
			node.parent.rchild = y;
		}
		y.lchild = node;
		node.parent = y;
	}
	
	/**
	 * ����
	 * @param t
	 * @param node
	 */
	private void RightRotate(RBTree t,RBTreeNode node){
		RBTreeNode y = node.lchild;
		node.lchild = y.rchild;
		if(y.rchild != nulNode){
			y.rchild.parent = node;
		}
		y.parent = node.parent;
		
		if(node.parent == nulNode){
			t.root = y;
		}else if(node==node.parent.lchild){
			node.parent.lchild = y;
		}else{
			node.parent.rchild = y;
		}
		y.rchild = node;
		node.parent = y;
	}
	
	public void display(RBTreeNode t,int h){
		for (int k = 0;k<h ;k++) {
			System.out.print("   ");
		}
		if(t==nulNode){
			System.out.print("NIL");
		}else{
			System.out.println("("+t.data + t.color+",");
			display(t.lchild, h+1);
			System.out.println(",");
			
			display(t.rchild, h+1);
			System.out.println(")");
			for (int i = 0; i < h-1; i++) {
				System.out.print("   ");
			}
		}
	}
	
	public static void main(String[] args) {
		RBTree rb = new RBTree();
		int[] nums = {10,85,15,70,20,60,30,50};
		for (int i = 0; i < nums.length; i++) {
			rb.insert(rb, nums[i]);
		}
		System.out.println("������������£�");
		rb.display(rb.root, 0);
		
	}

}


















