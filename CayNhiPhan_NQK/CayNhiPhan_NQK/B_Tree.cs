using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayNhiPhan_NQK
{
    class B_Tree
    {
        public Node_Tree root;
        public Node_Tree aux;



        public B_Tree()
        {
            aux = new Node_Tree();
        }
        public B_Tree (Node_Tree new_root)
        {
            root = new_root;
        }
        public void Insert(int x)
        {
            if (root == null)
            {
                root=new Node_Tree(x, null, null, null);
                root.bac = 0;
            }   
            else
            {
                root = root.Insert(x, root, root.bac);
            }    
        }
        public void Delete(int x)
        {
            if (root == null)
            {
                root = new Node_Tree(x, null, null, null);
                root.bac = 0;
            }   
            else
            {
                root.Delete(x, ref root);
            }    
        }
        public int tda;
        public int tdb;
        public void Find(int x)
        {
            root.Find(x, root);
            tda = root.timX;
            tdb = root.timY;
        }

        public List<int> re_edit = new List<int>();
        public bool end = false;
        public void inOrder(Node_Tree State_Node)
        {
            if (State_Node == null || end)
            {
                State_Node = null;
                end = true;
                return;
            }
            else
            {
                if (State_Node.truyCapR && State_Node.truyCapL && State_Node.daXet && !end)
                {
                    State_Node.truyCapL = false;
                    State_Node.truyCapR = false;
                    State_Node.daXet = false;
                    inOrder(State_Node.goc);
                }
                if (State_Node.left != null && State_Node.truyCapL == false && !end)
                {
                    State_Node.truyCapL = true;
                    inOrder(State_Node.left);
                }

                if ((State_Node.left == null || State_Node.truyCapL) && !end)
                {
                    if (State_Node.left == null && !end)
                    {
                        State_Node.truyCapL = true;
                    }
                    re_edit.Add(State_Node.data);
                    State_Node.daXet = true;
                    if (State_Node.right != null && !State_Node.truyCapL && !end)
                    {
                        State_Node.truyCapR = true;
                        inOrder(State_Node.right);
                    }
                    if (State_Node.goc != null && !end)
                    {
                        if (State_Node.right == null)
                        {
                            State_Node.truyCapR = true;
                        }
                        inOrder(State_Node.goc);
                    }
                    else
                    {
                        inOrder(State_Node.goc);
                    }

                }
            }
        }
        public void VeCay(Graphics grap, Font source, Brush Filling, Brush Fillingsource, Pen pen, Brush encuentro)
        {
            int x = 320;
            int y = 70;

            if (root == null)
            {
                return;
            }

            root.ViTriNode(ref x, y);
            root.VeNhanhNode(grap, pen);
            root.VeNode(grap, source, Filling, Fillingsource, pen, encuentro);
        }
        public int x1 = 320;
        public int y2 = 70;


        public void color(Graphics grap, Font source, Brush Filling, Brush Fillingsource, Pen pen, Node_Tree root, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Gray;
            if (inor == true)
            {
                if (root != null)
                {
                    color(grap, source, Filling, Fillingsource, pen, root.left, post, inor, preor);
                    root.color(grap, source, entorno, Fillingsource, pen);
                    Thread.Sleep(1000);
                    root.color(grap, source, Filling, Fillingsource, pen);
                    color(grap, source, Filling, Fillingsource, pen, root.right, post, inor, preor);
                }
            }
            else if (preor)
            {
                root.color(grap, source, entorno, Fillingsource, pen);
                Thread.Sleep(1000);
                root.color(grap, source, Filling, Fillingsource, pen);
                color(grap, source, Filling, Fillingsource, pen, root.left, post, inor, preor);
                color(grap, source, Filling, Fillingsource, pen, root.right, post, inor, preor);


            }
            else if (post)
            {
                if (root != null)
                {
                    color(grap, source, Filling, Fillingsource, pen, root.left, post, inor, preor);
                    color(grap, source, Filling, Fillingsource, pen, root.right, post, inor, preor);
                    root.color(grap, source, entorno, Fillingsource, pen);
                    Thread.Sleep(1000);
                    root.color(grap, source, Filling, Fillingsource, pen);

                }
            }
        }
    }
}
