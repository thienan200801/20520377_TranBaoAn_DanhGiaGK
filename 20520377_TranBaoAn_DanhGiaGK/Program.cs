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

            Label msLabel = new Label();
            msLabel.Text = "Ma so";
            msLabel.Location = new Point(600, 100);
            f.Controls.Add(msLabel);

            TextBox ms = new TextBox();
            ms.Location = new Point(700, 100);
            f.Controls.Add(ms);
            //
            Label tenLabel = new Label();
            tenLabel.Text = "Ten";
            tenLabel.Location = new Point(600, 200);
            f.Controls.Add(tenLabel);

            TextBox ten = new TextBox();
            ten.Location = new Point(700, 200);
            f.Controls.Add(ms);

            //
            Label giaLabel = new Label();
            giaLabel.Text = "Ma so";
            giaLabel.Location = new Point(600, 300);
            f.Controls.Add(giaLabel);

            TextBox gia = new TextBox();
            gia.Location = new Point(700, 300);
            f.Controls.Add(gia);
            //

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
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                Console.WriteLine(filepath);

                //TreeNode tNode;
                //tNode = treeView1.Nodes.Add("Websites");

                //treeView1.Nodes[0].Nodes.Add("Net-informations.com");
                //treeView1.Nodes[0].Nodes[0].Nodes.Add("CLR");

                //treeView1.Nodes[0].Nodes.Add("Vb.net-informations.com");
                //treeView1.Nodes[0].Nodes[1].Nodes.Add("String Tutorial");
                //treeView1.Nodes[0].Nodes[1].Nodes.Add("Excel Tutorial");

                //treeView1.Nodes[0].Nodes.Add("Csharp.net-informations.com");
                //treeView1.Nodes[0].Nodes[2].Nodes.Add("ADO.NET");
                //treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add("Dataset");
            }    
        }

        private static void ThemMatHang(object sender, EventArgs e)
        {
            
        }

        private static void ThemNganhHang(object sender, EventArgs e)
        {
           
        }


    }
}
