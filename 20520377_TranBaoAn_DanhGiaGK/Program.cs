using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20520377_TranBaoAn_DanhGiaGK
{
    internal class Program
    {
        static Form f = new Form();
        static TreeView treeView1;

        static void Main(string[] args)
        {

            Button NganhHangButton = new Button();
            NganhHangButton.Text = "Them nganh hang";
            NganhHangButton.Location = new Point(30, 30);
            NganhHangButton.Size = new Size(200, 30);
            NganhHangButton.Font = new Font("calibri", 12);
            NganhHangButton.Click += new EventHandler(ThemNganhHang);
            f.Size = new Size(2000, 1000);
            f.Controls.Add(NganhHangButton);

            Button MatHangButton = new Button();
            MatHangButton.Text = "Them mat hang";
            MatHangButton.Location = new Point(250, 30);
            MatHangButton.Size = new Size(200, 30);
            MatHangButton.Font = new Font("calibri", 12);
            MatHangButton.Click += new EventHandler(ThemMatHang);
            f.Size = new Size(2000, 1000);
            f.Controls.Add(MatHangButton);

            Button load = new Button();
            load.Text = "Load";
            load.Location = new Point(500, 500);
            load.Size = new Size(200, 30);
            load.Font = new Font("calibri", 12);
            load.Click += new EventHandler(loadFile);

            f.Size = new Size(2000, 1000);
            f.Controls.Add(load);

            Application.Run(f);
        }

        private static void loadFile(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\ThienAn\OneDrive - gm.uit.edu.vn\Documents");

            Console.WriteLine("Contents of WriteText.txt = {0}", text);
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    string filepath = ofd.FileName;
            //    Console.WriteLine(filepath);

            //    TreeNode tNode;
            //    tNode = treeView1.Nodes.Add("Websites");

            //    treeView1.Nodes[0].Nodes.Add("Net-informations.com");
            //    treeView1.Nodes[0].Nodes[0].Nodes.Add("CLR");

            //    treeView1.Nodes[0].Nodes.Add("Vb.net-informations.com");
            //    treeView1.Nodes[0].Nodes[1].Nodes.Add("String Tutorial");
            //    treeView1.Nodes[0].Nodes[1].Nodes.Add("Excel Tutorial");

            //    treeView1.Nodes[0].Nodes.Add("Csharp.net-informations.com");
            //    treeView1.Nodes[0].Nodes[2].Nodes.Add("ADO.NET");
            //    treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add("Dataset");

            //    f.Controls.Add(treeView1);
            //}    
        }

        private static void ThemMatHang(object sender, EventArgs e)
        {
            Form f1 = new Form();
            f1.Size = new Size(700, 700);
            Label msLabel = new Label();
            msLabel.Text = "Ma so";
            msLabel.Location = new Point(100, 100);
            f1.Controls.Add(msLabel);

            TextBox ms = new TextBox();
            ms.Location = new Point(300, 100);
            f1.Controls.Add(ms);
            //
            Label tenLabel = new Label();
            tenLabel.Text = "Ten";
            tenLabel.Location = new Point(100, 200);
            f1.Controls.Add(tenLabel);

            TextBox ten = new TextBox();
            ten.Location = new Point(300, 200);
            f1.Controls.Add(ten);
            //
            Label giaLabel = new Label();
            giaLabel.Text = "Gia";
            giaLabel.Location = new Point(100, 300);
            f1.Controls.Add(giaLabel);

            TextBox gia = new TextBox();
            gia.Location = new Point(300, 300);
            f1.Controls.Add(gia);

            f1.ShowDialog();
        }

        private static void ThemNganhHang(object sender, EventArgs e)
        {
            Form f2 = new Form();
            f2.Size = new Size(700, 700);
            Label msLabel = new Label();
            msLabel.Text = "Ma so";
            msLabel.Location = new Point(100, 100);
            f2.Controls.Add(msLabel);

            TextBox ms = new TextBox();
            ms.Location = new Point(300, 100);
            f2.Controls.Add(ms);
            //
            Label tenLabel = new Label();
            tenLabel.Text = "Ten";
            tenLabel.Location = new Point(100, 200);
            f2.Controls.Add(tenLabel);

            TextBox ten = new TextBox();
            ten.Location = new Point(300, 200);
            f2.Controls.Add(ten);
            f2.ShowDialog();
        }


    }
}
