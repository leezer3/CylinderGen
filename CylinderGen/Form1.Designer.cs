namespace CylinderGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bottomX = new System.Windows.Forms.NumericUpDown();
            this.bottomY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bottomZ = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.topZ = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.topY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.topX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.topradius = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.totalfaces = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bottomradius = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.texturewrap = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.both = new System.Windows.Forms.RadioButton();
            this.inside = new System.Windows.Forms.RadioButton();
            this.outside = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.neitherface = new System.Windows.Forms.RadioButton();
            this.bothface = new System.Windows.Forms.RadioButton();
            this.bottomface = new System.Windows.Forms.RadioButton();
            this.topface = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.normalsyes = new System.Windows.Forms.RadioButton();
            this.normalsno = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bottomX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topradius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomradius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturewrap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the center point of the bottom of your cylinder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X:";
            // 
            // bottomX
            // 
            this.bottomX.DecimalPlaces = 2;
            this.bottomX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.bottomX.Location = new System.Drawing.Point(55, 30);
            this.bottomX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.bottomX.Name = "bottomX";
            this.bottomX.Size = new System.Drawing.Size(120, 20);
            this.bottomX.TabIndex = 2;
            this.bottomX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bottomY
            // 
            this.bottomY.DecimalPlaces = 2;
            this.bottomY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.bottomY.Location = new System.Drawing.Point(55, 55);
            this.bottomY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.bottomY.Name = "bottomY";
            this.bottomY.Size = new System.Drawing.Size(120, 20);
            this.bottomY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // bottomZ
            // 
            this.bottomZ.DecimalPlaces = 2;
            this.bottomZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.bottomZ.Location = new System.Drawing.Point(55, 80);
            this.bottomZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.bottomZ.Name = "bottomZ";
            this.bottomZ.Size = new System.Drawing.Size(120, 20);
            this.bottomZ.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z:";
            // 
            // topZ
            // 
            this.topZ.DecimalPlaces = 2;
            this.topZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.topZ.Location = new System.Drawing.Point(55, 170);
            this.topZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.topZ.Name = "topZ";
            this.topZ.Size = new System.Drawing.Size(120, 20);
            this.topZ.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Z:";
            // 
            // topY
            // 
            this.topY.DecimalPlaces = 2;
            this.topY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.topY.Location = new System.Drawing.Point(55, 145);
            this.topY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.topY.Name = "topY";
            this.topY.Size = new System.Drawing.Size(120, 20);
            this.topY.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y:";
            // 
            // topX
            // 
            this.topX.DecimalPlaces = 2;
            this.topX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.topX.Location = new System.Drawing.Point(55, 120);
            this.topX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.topX.Name = "topX";
            this.topX.Size = new System.Drawing.Size(120, 20);
            this.topX.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Please enter the center point of the top of your cylinder:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Please enter the radii of your cylinder:";
            // 
            // topradius
            // 
            this.topradius.DecimalPlaces = 2;
            this.topradius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.topradius.Location = new System.Drawing.Point(55, 207);
            this.topradius.Name = "topradius";
            this.topradius.Size = new System.Drawing.Size(120, 20);
            this.topradius.TabIndex = 15;
            this.topradius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Please enter the total number of faces for your cylinder:";
            // 
            // totalfaces
            // 
            this.totalfaces.Location = new System.Drawing.Point(55, 248);
            this.totalfaces.Name = "totalfaces";
            this.totalfaces.Size = new System.Drawing.Size(120, 20);
            this.totalfaces.TabIndex = 18;
            this.totalfaces.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Top:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(181, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Bottom";
            // 
            // bottomradius
            // 
            this.bottomradius.DecimalPlaces = 2;
            this.bottomradius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.bottomradius.Location = new System.Drawing.Point(233, 207);
            this.bottomradius.Name = "bottomradius";
            this.bottomradius.Size = new System.Drawing.Size(120, 20);
            this.bottomradius.TabIndex = 21;
            this.bottomradius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Select the texture for your cylinder:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Select...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 533);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Set the filename for your cylinder:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 480);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(255, 26);
            this.label15.TabIndex = 25;
            this.label15.Text = "Set the number of times the texture is to be wrapped \r\naround the cylinder:";
            // 
            // texturewrap
            // 
            this.texturewrap.DecimalPlaces = 2;
            this.texturewrap.Location = new System.Drawing.Point(54, 510);
            this.texturewrap.Name = "texturewrap";
            this.texturewrap.Size = new System.Drawing.Size(120, 20);
            this.texturewrap.TabIndex = 26;
            this.texturewrap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 549);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "cylinder1.b3d";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(235, 26);
            this.label16.TabIndex = 28;
            this.label16.Text = "Set whether the outside or inside of your cylinder\r\nshould be visible:";
            // 
            // both
            // 
            this.both.AutoSize = true;
            this.both.Location = new System.Drawing.Point(122, 6);
            this.both.Name = "both";
            this.both.Size = new System.Drawing.Size(47, 17);
            this.both.TabIndex = 2;
            this.both.TabStop = true;
            this.both.Text = "Both";
            this.both.UseVisualStyleBackColor = true;
            // 
            // inside
            // 
            this.inside.AutoSize = true;
            this.inside.Location = new System.Drawing.Point(63, 6);
            this.inside.Name = "inside";
            this.inside.Size = new System.Drawing.Size(53, 17);
            this.inside.TabIndex = 1;
            this.inside.TabStop = true;
            this.inside.Text = "Inside";
            this.inside.UseVisualStyleBackColor = true;
            // 
            // outside
            // 
            this.outside.AutoSize = true;
            this.outside.Checked = true;
            this.outside.Location = new System.Drawing.Point(0, 6);
            this.outside.Name = "outside";
            this.outside.Size = new System.Drawing.Size(61, 17);
            this.outside.TabIndex = 0;
            this.outside.TabStop = true;
            this.outside.Text = "Outside";
            this.outside.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.both);
            this.panel1.Controls.Add(this.outside);
            this.panel1.Controls.Add(this.inside);
            this.panel1.Location = new System.Drawing.Point(22, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 31);
            this.panel1.TabIndex = 30;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.neitherface);
            this.panel2.Controls.Add(this.bothface);
            this.panel2.Controls.Add(this.bottomface);
            this.panel2.Controls.Add(this.topface);
            this.panel2.Location = new System.Drawing.Point(22, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 26);
            this.panel2.TabIndex = 31;
            // 
            // neitherface
            // 
            this.neitherface.AutoSize = true;
            this.neitherface.Checked = true;
            this.neitherface.Location = new System.Drawing.Point(211, 3);
            this.neitherface.Name = "neitherface";
            this.neitherface.Size = new System.Drawing.Size(59, 17);
            this.neitherface.TabIndex = 3;
            this.neitherface.TabStop = true;
            this.neitherface.Text = "Neither";
            this.neitherface.UseVisualStyleBackColor = true;
            // 
            // bothface
            // 
            this.bothface.AutoSize = true;
            this.bothface.Location = new System.Drawing.Point(162, 3);
            this.bothface.Name = "bothface";
            this.bothface.Size = new System.Drawing.Size(47, 17);
            this.bothface.TabIndex = 2;
            this.bothface.TabStop = true;
            this.bothface.Text = "Both";
            this.bothface.UseVisualStyleBackColor = true;
            // 
            // bottomface
            // 
            this.bottomface.AutoSize = true;
            this.bottomface.Location = new System.Drawing.Point(78, 3);
            this.bottomface.Name = "bottomface";
            this.bottomface.Size = new System.Drawing.Size(82, 17);
            this.bottomface.TabIndex = 1;
            this.bottomface.TabStop = true;
            this.bottomface.Text = "Bottom Only";
            this.bottomface.UseVisualStyleBackColor = true;
            // 
            // topface
            // 
            this.topface.AutoSize = true;
            this.topface.Location = new System.Drawing.Point(4, 4);
            this.topface.Name = "topface";
            this.topface.Size = new System.Drawing.Size(68, 17);
            this.topface.TabIndex = 0;
            this.topface.TabStop = true;
            this.topface.Text = "Top Only";
            this.topface.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 337);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(220, 26);
            this.label17.TabIndex = 32;
            this.label17.Text = "Set whether the top and bottom faces of your\r\ncylinder should be visible:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 395);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(257, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Select whether custom normals should be generated:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.normalsno);
            this.panel3.Controls.Add(this.normalsyes);
            this.panel3.Location = new System.Drawing.Point(22, 411);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 20);
            this.panel3.TabIndex = 34;
            // 
            // normalsyes
            // 
            this.normalsyes.AutoSize = true;
            this.normalsyes.Checked = true;
            this.normalsyes.Location = new System.Drawing.Point(4, 1);
            this.normalsyes.Name = "normalsyes";
            this.normalsyes.Size = new System.Drawing.Size(43, 17);
            this.normalsyes.TabIndex = 0;
            this.normalsyes.TabStop = true;
            this.normalsyes.Text = "Yes";
            this.normalsyes.UseVisualStyleBackColor = true;
            // 
            // normalsno
            // 
            this.normalsno.AutoSize = true;
            this.normalsno.Location = new System.Drawing.Point(53, 0);
            this.normalsno.Name = "normalsno";
            this.normalsno.Size = new System.Drawing.Size(39, 17);
            this.normalsno.TabIndex = 1;
            this.normalsno.Text = "No";
            this.normalsno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.texturewrap);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bottomradius);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalfaces);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topradius);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.topZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.topY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.topX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bottomZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bottomY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bottomX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cylinder Generator for OpenBVE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bottomX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topradius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomradius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturewrap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bottomX;
        private System.Windows.Forms.NumericUpDown bottomY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bottomZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown topZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown topY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown topX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown topradius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown totalfaces;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown bottomradius;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown texturewrap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton both;
        private System.Windows.Forms.RadioButton inside;
        private System.Windows.Forms.RadioButton outside;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton bothface;
        private System.Windows.Forms.RadioButton bottomface;
        private System.Windows.Forms.RadioButton topface;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton neitherface;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton normalsno;
        private System.Windows.Forms.RadioButton normalsyes;
    }
}

