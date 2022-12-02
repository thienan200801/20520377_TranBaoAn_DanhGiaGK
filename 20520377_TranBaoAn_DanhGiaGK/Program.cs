using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        static string saveTxt = "";


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
            load.Location = new Point(100, 400);
            load.Size = new Size(100, 30);
            load.Font = new Font("calibri", 12);
            load.Click += new EventHandler(loadFile);

            Button saveBtn = new Button();
            saveBtn.Text = "Save";
            saveBtn.Location = new Point(300, 400);
            saveBtn.Size = new Size(100, 30);
            saveBtn.Font = new Font("calibri", 12);
            saveBtn.Click += new EventHandler(saveFile);

            f.Size = new Size(2000, 1000);
            f.Controls.Add(load);
            f.Controls.Add(saveBtn);

            Application.Run(f);
        }

        private static void saveFile(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("@C:\\db1.txt");
            sw.WriteLine(saveTxt);
        }

        private static void loadFile(object sender, EventArgs e)
        {

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

            saveTxt += ms.Text + "|" + ten + "|" + gia;

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

            saveTxt += ms.Text + "|" + ten;

            f2.ShowDialog();
        }


    }
}
