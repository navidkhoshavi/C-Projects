using System;
using System.Collections.Generic;
using System.Text;

namespace find_path
{
    class Node
    {
        public Node() 
        {
            name = depth = parent = 0;
        }
        public Node(int n, int d, int p, int[] ch,bool goal,string nam) 
        {
            name = n;
            depth = d;
            parent = p;
            for (int i = 0; i < 3; i++) 
            {
                childs[i] = ch[i];
            }
            isGoal = goal;
            name1 = nam;
        }
        public int name;
        public int depth;
        public int parent;
        public int[] childs=new int[3];
        public bool isGoal;
        public string name1; 
    }
}
