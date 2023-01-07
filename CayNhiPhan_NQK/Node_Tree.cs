using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CayNhiPhan_NQK
{
    class Node_Tree
    {
        public int data;
        public Node_Tree left;
        public Node_Tree right;
        public Node_Tree goc;

        public int chieuCao;
        public int bac;

        public int timX;
        public int timY;
        public bool truyCapL = false;
        public bool truyCapR = false;
        public bool daXet = false;

        public B_Tree tree
        {
            get { return tree; }
            set { tree = value; }
        }
        public Node_Tree()
        {

        }
        public Node_Tree(int new_data, Node_Tree new_left, Node_Tree new_right, Node_Tree new_goc)
        {
            data = new_data;
            left = new_left;
            right = new_right;
            goc = new_goc;
            chieuCao = 0;
        }
        public Node_Tree Insert(int x, Node_Tree t, int cap, Node_Tree new_goc = null)
        {
            if (t==null)
            {
                t=new Node_Tree(x,null,null,new_goc);
                t.bac = cap;
            }
            else if (x < t.data)
            {
                cap++;
                t.left = Insert(x, t.left, cap, t);
            }
            else if (x > t.data)
            {
                cap++;
                t.right = Insert(x, t.right, cap, t);
            }   
            else
            {
                MessageBox.Show("Node đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            return t;
        }

        public static int Cao(Node_Tree t)
        {
            return t==null ? -1 : t.bac;
        }
        public void Delete(int x, ref Node_Tree t)
        {
            if (t!=null)
            {
                if (x < t.data)
                {
                    Delete(x, ref t.left);
                }
                else
                {
                    if (x > t.data)
                    {
                        Delete(x, ref t.right);
                    }
                    else
                    {
                        Node_Tree Delete_Node = t;
                        if (Delete_Node.right == null)
                        {
                            t = Delete_Node.left;
                        }    
                        else
                        {
                            if (Delete_Node.left == null)
                            {
                                t = Delete_Node.right;
                            }    
                            else
                            {
                                if (Cao(t.left) - Cao(t.right)>0)
                                {
                                    Node_Tree PNode = null;
                                    Node_Tree P = t.left;
                                    bool co = false;
                                    while (P.right != null)
                                    {
                                        PNode = P;
                                        P = P.right;
                                        co = true;
                                    }    
                                    t.data=P.data;
                                    Delete_Node = P;
                                    if (co == true)
                                    {
                                        PNode.right = P.right;
                                    }    
                                    else
                                    {
                                        t.left = P.left;
                                    }    
                                } 
                                else
                                {
                                    if (Cao(t.right)-Cao(t.left)>0)
                                    {
                                        Node_Tree PNode = null;
                                        Node_Tree P = t.right;

                                        bool co = false;

                                        while (P.left != null)
                                        {
                                            PNode = P;
                                            P = P.left;
                                            co = true;

                                        }

                                        t.data = P.data;
                                        Delete_Node = P;

                                        if (co == true)
                                        {
                                            PNode.left = P.right;
                                        }
                                        else
                                        {
                                            t.right = P.right;
                                        }
                                    } 
                                    else
                                    {
                                        if (Cao(t.right) - Cao(t.left) == 0)
                                        {
                                            Node_Tree PNode = null;
                                            Node_Tree P = t.left;
                                            bool co = false;

                                            while (P.right != null)
                                            {
                                                PNode = P;
                                                P = P.left;
                                                co = false;
                                            }

                                            t.data = P.data;
                                            Delete_Node = P;

                                            if (co == true)
                                            {
                                                PNode.right = P.left;

                                            }
                                            else
                                            {
                                                t.left = P.left;
                                            }
                                        }
                                    }    
                                }    
                            }    
                        }    
                    }
                }
            }
            else
            {
                MessageBox.Show("Node không tồn tại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Find(int x, Node_Tree t)
        {
            if (t != null)
            {
                if (x < t.data)
                {

                    Find(x, t.left);
                }
                else if (x > t.data)
                {
                    Find(x, t.right);
                }

                else
                {
                    if (x == t.data)
                    {

                        timX = t.TDX;
                        timY = t.TDY;

                    }
                }
            }
            else
            {
                MessageBox.Show("Node không tồn tại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region "ViTri"
        private const int Radio = 35;
        private const int DistanciaH = 200;
        private const int DistanciaV = 30;
        private int TDX;
        private int TDY;



        public void ViTriNode(ref int xmin, int ymin)
        {
            int aux1, aux2;
            TDY = (int)(ymin + Radio / 2);


            if (left != null)
            {
                left.ViTriNode(ref xmin, ymin + Radio + DistanciaV);
            }

            if ((left != null) && (right != null))
            {
                xmin += DistanciaH;
            }

            if (right != null)
            {
                right.ViTriNode(ref xmin, ymin + Radio + DistanciaV);

            }

            if (left != null && right != null)
            {
                TDX = (int)((left.TDX + right.TDX) / 2);

            }
            else if (left != null)
            {
                aux1 = left.TDX;
                left.TDX = TDX - 80;
                TDX = aux1;
            }
            else if (right != null)
            {
                aux2 = right.TDX;
                right.TDX = TDX + 80;
                TDX = aux2;

            }
            else
            {
                TDX = (int)(xmin + Radio / 2);
                xmin += Radio;

            }
        }

        public void VeNhanhNode(Graphics grap, Pen pen)
        {

            if (left != null)
            {
                grap.DrawLine(pen, TDX, TDY, left.TDX, left.TDY);
                left.VeNhanhNode(grap, pen);
            }

            if (right != null)
            {
                grap.DrawLine(pen, TDX, TDY, right.TDX, right.TDY);
                right.VeNhanhNode(grap, pen);
            }
        }

        public void VeNode(Graphics grap, Font source, Brush Filling, Brush FillingSoure, Pen pen, Brush encuentro)
        {
            Rectangle rect = new Rectangle((int)(TDX - Radio / 2), (int)(TDY - Radio / 2), Radio, Radio);
            grap.FillRectangle(encuentro, rect);
            grap.FillRectangle(Filling, rect);
            grap.DrawRectangle(pen, rect);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;


            grap.DrawString(data.ToString(), source, FillingSoure, TDX, TDY, formato);


            if (left != null)
            {
                left.VeNode(grap, source, Filling, FillingSoure, pen, encuentro);

            }
            if (right != null)
            {
                right.VeNode(grap, source, Filling, FillingSoure, pen, encuentro);
            }
        }
        public void color(Graphics grap, Font source, Brush Filling, Brush FillingSoure, Pen pen)
        {
            Rectangle rect = new Rectangle((int)(TDX - Radio / 2), (int)(TDY - Radio / 2), Radio, Radio);
            grap.FillRectangle(Filling, rect);
            grap.DrawRectangle(pen, rect);

            StringFormat Format = new StringFormat();
            Format.Alignment = StringAlignment.Center;
            grap.DrawString(data.ToString(), source, FillingSoure, TDX, TDY, Format);

        }

        #endregion
    }
}
