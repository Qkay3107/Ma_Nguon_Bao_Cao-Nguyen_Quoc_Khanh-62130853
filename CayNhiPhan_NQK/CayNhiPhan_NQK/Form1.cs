using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayNhiPhan_NQK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        int Dato = 0;
        int cont = 0;
        int n = 0;

        B_Tree bTree = new B_Tree(null);
        Node_Tree tree_Node = new Node_Tree();

        Graphics g;
        string text = "";

        Boolean existe(Node_Tree Node)
        {
            try { int x = Node.data; return true; }
            catch { return false; }
        }
        void preOrder(Node_Tree node)
        {
            if (existe(node))
            {
                text += text.Equals("") ? node.data + "" : " - " + node.data;
                preOrder(node.left);
                preOrder(node.right);
            }

        }
        void inOrder(Node_Tree node)
        {
            if (existe(node))
            {
                inOrder(node.left);
                text += text.Equals("") ? node.data + "" : " - " + node.data;
                inOrder(node.right);
            }
        }
        void postOrder(Node_Tree node)
        {
            if (existe(node))
            {
                postOrder(node.left);
                postOrder(node.right);
                text += text.Equals("") ? node.data + "" : " - " + node.data;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
         
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            txtPrintf.Text = "";
            if (txtInsert.Text == "")
            {
                MessageBox.Show("Vui lòng nhập node cần thêm");
            }
            else
            {

                Dato = int.Parse(txtInsert.Text);
                vs[n++] = Dato;
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Dữ liệu phải nằm trong khoảng từ 0->99", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bTree.Insert(Dato);
                    txtInsert.Clear();
                    txtInsert.Focus();

                    cont++;
                    Refresh();
                    Refresh();
                }
            }
        }
        int[] vs = new int[30];
        private const int Radio = 35;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.CenterToScreen();
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            g = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            bTree.VeCay(g, this.Font, Brushes.Brown, Brushes.White, pen, Brushes.Aqua);
            Rectangle rect = new Rectangle((int)(bTree.tda - Radio / 2), (int)(bTree.tdb - Radio / 2), Radio, Radio);
            Pen pencil = new Pen(Brushes.Aqua, 4);
            g.DrawRectangle(pencil, rect);


        }
        int TimPhanTu(int x)
        {
            for (int i = 0; i < n; i++)
                if (vs[i] == x)
                    return i;
            return -1;
        }

        void XoaPhanTu(int x)
        {
            int vt = TimPhanTu(x);
            for (int i = vt; i <= n - 2; i++)
                vs[i] = vs[i + 1];
            n--;

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            txtPrintf.Text = "";
            if (txtDelete.Text == "")
            {
                MessageBox.Show("Vui lòng nhập node cần xóa");
            }
            else
            {
                Dato = int.Parse(txtDelete.Text);
                XoaPhanTu(Dato);
                bTree.Delete(Dato);
                txtDelete.Clear();
                txtDelete.Focus();
                bTree.tda = 0;
                bTree.tdb = 0;
                cont++;
                Refresh();
                Refresh();

            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào node cần tìm");
            }
            else
            {

                Dato = int.Parse(txtFind.Text);
                bTree.Find(Dato);
                Refresh();
            }
        }

        private void btPrintf_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedItem == "Duyệt Trước")
            {
                preOrder(bTree.root);
                txtPrintf.Text = text.ToString();
                text = "";
            }

            if (this.comboBox2.SelectedItem == "Duyệt Giữa")
            {
                inOrder(bTree.root);
                txtPrintf.Text = text.ToString();
                text = "";
            }
            else
                if (this.comboBox2.SelectedItem == "Duyệt Sau")
            {
                postOrder(bTree.root);
                txtPrintf.Text = text.ToString();
                text = "";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                bTree.Delete(vs[i]);
                bTree.tda = 0;
                bTree.tdb = 0;
                Refresh();
                Refresh();

            }
            n = 0;
            cont = 0;
            txtPrintf.Text = string.Empty;
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                bTree.Delete(vs[i]);
                Refresh();
                Refresh();

            }
            n = 0;
            cont = 0;
            txtPrintf.Text = string.Empty;


            int k = Convert.ToInt32(numericUpDown1.Value);
            int number;
            bool kt;
            Random rand = new Random();
            do
            {
                kt = true;
                number = rand.Next(0, 99);
                for (int i = 0; i < n; i++)
                {
                    if (vs[i] == number)
                    {
                        kt = false;

                    }

                }
                if (kt == true)
                {
                    vs[n++] = number;

                }
            } while (n < k);
            for (int i = 0; i < n; i++)
            {
                bTree.Insert(vs[i]);
                Thread.Sleep(500);
                Refresh();
                Refresh();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
