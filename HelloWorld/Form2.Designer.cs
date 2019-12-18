namespace HelloWorld
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("David");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("La femme du David");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Jo", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Shaggy");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Bobby Shu", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Seigneur", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.addressL = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.cityLb = new System.Windows.Forms.ListBox();
            this.maleRb = new System.Windows.Forms.RadioButton();
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.jetskiRb = new System.Windows.Forms.RadioButton();
            this.csharpCB = new System.Windows.Forms.CheckBox();
            this.aspCB = new System.Windows.Forms.CheckBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imgPB = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addressTb);
            this.groupBox1.Controls.Add(this.nameTb);
            this.groupBox1.Controls.Add(this.addressL);
            this.groupBox1.Controls.Add(this.nameL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(73, 75);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(100, 20);
            this.addressTb.TabIndex = 3;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(73, 28);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 2;
            // 
            // addressL
            // 
            this.addressL.AutoSize = true;
            this.addressL.Location = new System.Drawing.Point(15, 75);
            this.addressL.Name = "addressL";
            this.addressL.Size = new System.Drawing.Size(45, 13);
            this.addressL.TabIndex = 1;
            this.addressL.Text = "Address";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(15, 28);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(38, 13);
            this.nameL.TabIndex = 0;
            this.nameL.Text = "Name:";
            // 
            // cityLb
            // 
            this.cityLb.FormattingEnabled = true;
            this.cityLb.Items.AddRange(new object[] {
            "Dunkerque",
            "Delano",
            "Andore",
            "Bagdad",
            "Le-Pont-de-Claix"});
            this.cityLb.Location = new System.Drawing.Point(13, 241);
            this.cityLb.Name = "cityLb";
            this.cityLb.Size = new System.Drawing.Size(315, 147);
            this.cityLb.TabIndex = 1;
            this.cityLb.SelectedIndexChanged += new System.EventHandler(this.cityLb_SelectedIndexChanged);
            // 
            // maleRb
            // 
            this.maleRb.AutoSize = true;
            this.maleRb.Location = new System.Drawing.Point(413, 35);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(48, 17);
            this.maleRb.TabIndex = 2;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "Male";
            this.maleRb.UseVisualStyleBackColor = true;
            this.maleRb.UseWaitCursor = true;
            // 
            // femaleRb
            // 
            this.femaleRb.AutoSize = true;
            this.femaleRb.Location = new System.Drawing.Point(413, 59);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(59, 17);
            this.femaleRb.TabIndex = 3;
            this.femaleRb.TabStop = true;
            this.femaleRb.Text = "Female";
            this.femaleRb.UseVisualStyleBackColor = true;
            // 
            // jetskiRb
            // 
            this.jetskiRb.AutoSize = true;
            this.jetskiRb.Location = new System.Drawing.Point(413, 82);
            this.jetskiRb.Name = "jetskiRb";
            this.jetskiRb.Size = new System.Drawing.Size(52, 17);
            this.jetskiRb.TabIndex = 4;
            this.jetskiRb.TabStop = true;
            this.jetskiRb.Text = "Jetski";
            this.jetskiRb.UseVisualStyleBackColor = true;
            // 
            // csharpCB
            // 
            this.csharpCB.AutoSize = true;
            this.csharpCB.Location = new System.Drawing.Point(413, 151);
            this.csharpCB.Name = "csharpCB";
            this.csharpCB.Size = new System.Drawing.Size(40, 17);
            this.csharpCB.TabIndex = 5;
            this.csharpCB.Text = "C#";
            this.csharpCB.UseVisualStyleBackColor = true;
            // 
            // aspCB
            // 
            this.aspCB.AutoSize = true;
            this.aspCB.Location = new System.Drawing.Point(413, 175);
            this.aspCB.Name = "aspCB";
            this.aspCB.Size = new System.Drawing.Size(47, 17);
            this.aspCB.TabIndex = 6;
            this.aspCB.Text = "ASP";
            this.aspCB.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(397, 365);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(507, 365);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(507, 35);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nœud1";
            treeNode1.Text = "David";
            treeNode2.Name = "Nœud2";
            treeNode2.Text = "La femme du David";
            treeNode3.Name = "joNode";
            treeNode3.Text = "Jo";
            treeNode4.Name = "Nœud5";
            treeNode4.Text = "Shaggy";
            treeNode5.Name = "Nœud4";
            treeNode5.Text = "Bobby Shu";
            treeNode6.Name = "Nœud3";
            treeNode6.Text = "Seigneur";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(160, 120);
            this.treeView1.TabIndex = 9;
            // 
            // imgPB
            // 
            this.imgPB.Image = global::HelloWorld.Properties.Resources.solaire_speed;
            this.imgPB.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgPB.InitialImage")));
            this.imgPB.Location = new System.Drawing.Point(507, 184);
            this.imgPB.Name = "imgPB";
            this.imgPB.Size = new System.Drawing.Size(160, 107);
            this.imgPB.TabIndex = 10;
            this.imgPB.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 405);
            this.Controls.Add(this.imgPB);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.aspCB);
            this.Controls.Add(this.csharpCB);
            this.Controls.Add(this.jetskiRb);
            this.Controls.Add(this.femaleRb);
            this.Controls.Add(this.maleRb);
            this.Controls.Add(this.cityLb);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label addressL;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.ListBox cityLb;
        private System.Windows.Forms.RadioButton maleRb;
        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.RadioButton jetskiRb;
        private System.Windows.Forms.CheckBox csharpCB;
        private System.Windows.Forms.CheckBox aspCB;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox imgPB;
    }
}