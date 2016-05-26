namespace MyMine
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.游戏GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开局NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.初级BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中级IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_header = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel_time = new System.Windows.Forms.TableLayoutPanel();
            this.imageList_num = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_hundreds = new System.Windows.Forms.PictureBox();
            this.pb_tens = new System.Windows.Forms.PictureBox();
            this.pb_units = new System.Windows.Forms.PictureBox();
            this.MenuStrip_Main.SuspendLayout();
            this.tableLayoutPanel_header.SuspendLayout();
            this.tableLayoutPanel_time.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hundreds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_units)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏GToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(284, 25);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // 游戏GToolStripMenuItem
            // 
            this.游戏GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开局NToolStripMenuItem,
            this.toolStripMenuItem1,
            this.初级BToolStripMenuItem,
            this.中级IToolStripMenuItem,
            this.高级EToolStripMenuItem,
            this.toolStripMenuItem2,
            this.设置SToolStripMenuItem});
            this.游戏GToolStripMenuItem.Name = "游戏GToolStripMenuItem";
            this.游戏GToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.游戏GToolStripMenuItem.Text = "游戏(&G)";
            // 
            // 开局NToolStripMenuItem
            // 
            this.开局NToolStripMenuItem.Name = "开局NToolStripMenuItem";
            this.开局NToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.开局NToolStripMenuItem.Text = "开局(&N)";
            this.开局NToolStripMenuItem.Click += new System.EventHandler(this.开局NToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // 初级BToolStripMenuItem
            // 
            this.初级BToolStripMenuItem.Name = "初级BToolStripMenuItem";
            this.初级BToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.初级BToolStripMenuItem.Text = "初级(&B)";
            this.初级BToolStripMenuItem.Click += new System.EventHandler(this.初级BToolStripMenuItem_Click);
            // 
            // 中级IToolStripMenuItem
            // 
            this.中级IToolStripMenuItem.Name = "中级IToolStripMenuItem";
            this.中级IToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.中级IToolStripMenuItem.Text = "中级(&I)";
            this.中级IToolStripMenuItem.Click += new System.EventHandler(this.中级IToolStripMenuItem_Click);
            // 
            // 高级EToolStripMenuItem
            // 
            this.高级EToolStripMenuItem.Name = "高级EToolStripMenuItem";
            this.高级EToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.高级EToolStripMenuItem.Text = "高级(&E)";
            this.高级EToolStripMenuItem.Click += new System.EventHandler(this.高级EToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(115, 6);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            this.设置SToolStripMenuItem.Click += new System.EventHandler(this.设置SToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel_header
            // 
            this.tableLayoutPanel_header.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel_header.ColumnCount = 7;
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel_header.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel_header.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel_header.Controls.Add(this.tableLayoutPanel_time, 5, 0);
            this.tableLayoutPanel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_header.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel_header.Name = "tableLayoutPanel_header";
            this.tableLayoutPanel_header.RowCount = 1;
            this.tableLayoutPanel_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_header.Size = new System.Drawing.Size(284, 40);
            this.tableLayoutPanel_header.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel_time
            // 
            this.tableLayoutPanel_time.ColumnCount = 4;
            this.tableLayoutPanel_time.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel_time.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel_time.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel_time.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel_time.Controls.Add(this.pb_hundreds, 0, 0);
            this.tableLayoutPanel_time.Controls.Add(this.pb_tens, 1, 0);
            this.tableLayoutPanel_time.Controls.Add(this.pb_units, 2, 0);
            this.tableLayoutPanel_time.Location = new System.Drawing.Point(227, 6);
            this.tableLayoutPanel_time.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.tableLayoutPanel_time.Name = "tableLayoutPanel_time";
            this.tableLayoutPanel_time.RowCount = 1;
            this.tableLayoutPanel_time.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_time.Size = new System.Drawing.Size(40, 28);
            this.tableLayoutPanel_time.TabIndex = 2;
            // 
            // imageList_num
            // 
            this.imageList_num.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_num.ImageStream")));
            this.imageList_num.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_num.Images.SetKeyName(0, "0.png");
            this.imageList_num.Images.SetKeyName(1, "1.png");
            this.imageList_num.Images.SetKeyName(2, "2.png");
            this.imageList_num.Images.SetKeyName(3, "3.png");
            this.imageList_num.Images.SetKeyName(4, "4.png");
            this.imageList_num.Images.SetKeyName(5, "5.png");
            this.imageList_num.Images.SetKeyName(6, "6.png");
            this.imageList_num.Images.SetKeyName(7, "7.png");
            this.imageList_num.Images.SetKeyName(8, "8.png");
            this.imageList_num.Images.SetKeyName(9, "9.png");
            this.imageList_num.Images.SetKeyName(10, "-.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(40, 28);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MyMine.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::MyMine.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(13, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::MyMine.Properties.Resources._0;
            this.pictureBox3.Location = new System.Drawing.Point(26, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::MyMine.Properties.Resources.face_normal;
            this.button1.Location = new System.Drawing.Point(125, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_hundreds
            // 
            this.pb_hundreds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_hundreds.Image = global::MyMine.Properties.Resources._0;
            this.pb_hundreds.Location = new System.Drawing.Point(0, 3);
            this.pb_hundreds.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pb_hundreds.Name = "pb_hundreds";
            this.pb_hundreds.Size = new System.Drawing.Size(13, 22);
            this.pb_hundreds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hundreds.TabIndex = 0;
            this.pb_hundreds.TabStop = false;
            // 
            // pb_tens
            // 
            this.pb_tens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_tens.Image = global::MyMine.Properties.Resources._0;
            this.pb_tens.Location = new System.Drawing.Point(13, 3);
            this.pb_tens.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pb_tens.Name = "pb_tens";
            this.pb_tens.Size = new System.Drawing.Size(13, 22);
            this.pb_tens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_tens.TabIndex = 1;
            this.pb_tens.TabStop = false;
            // 
            // pb_units
            // 
            this.pb_units.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_units.Image = global::MyMine.Properties.Resources._0;
            this.pb_units.Location = new System.Drawing.Point(26, 3);
            this.pb_units.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pb_units.Name = "pb_units";
            this.pb_units.Size = new System.Drawing.Size(13, 22);
            this.pb_units.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_units.TabIndex = 2;
            this.pb_units.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel_header);
            this.Controls.Add(this.MenuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扫雷";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.tableLayoutPanel_header.ResumeLayout(false);
            this.tableLayoutPanel_time.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hundreds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_units)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 游戏GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开局NToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 初级BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中级IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级EToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_time;
        private System.Windows.Forms.PictureBox pb_hundreds;
        private System.Windows.Forms.PictureBox pb_tens;
        private System.Windows.Forms.PictureBox pb_units;
        private System.Windows.Forms.ImageList imageList_num;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

