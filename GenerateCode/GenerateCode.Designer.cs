namespace GenerateCode
{
    partial class GenerateCodeForm
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
            this.ckblTables = new System.Windows.Forms.CheckedListBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ckbModel = new System.Windows.Forms.CheckBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbDB = new System.Windows.Forms.CheckBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbBusiness = new System.Windows.Forms.CheckBox();
            this.txtBusiness = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckblTables
            // 
            this.ckblTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckblTables.FormattingEnabled = true;
            this.ckblTables.Location = new System.Drawing.Point(0, 0);
            this.ckblTables.Name = "ckblTables";
            this.ckblTables.Size = new System.Drawing.Size(200, 422);
            this.ckblTables.TabIndex = 0;
            this.ckblTables.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(12, 12);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "生存代码";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPath);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.btnBuild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 73);
            this.panel1.TabIndex = 2;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(540, 11);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 3;
            this.btnPath.Text = "保存路径";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(271, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(263, 20);
            this.txtPath.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckblTables);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 422);
            this.panel2.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ckbModel
            // 
            this.ckbModel.AutoSize = true;
            this.ckbModel.Location = new System.Drawing.Point(232, 106);
            this.ckbModel.Name = "ckbModel";
            this.ckbModel.Size = new System.Drawing.Size(55, 17);
            this.ckbModel.TabIndex = 4;
            this.ckbModel.Text = "Model";
            this.ckbModel.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(374, 104);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(241, 20);
            this.txtModel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "命名空间";
            // 
            // ckbDB
            // 
            this.ckbDB.AutoSize = true;
            this.ckbDB.Location = new System.Drawing.Point(232, 145);
            this.ckbDB.Name = "ckbDB";
            this.ckbDB.Size = new System.Drawing.Size(41, 17);
            this.ckbDB.TabIndex = 4;
            this.ckbDB.Text = "DB";
            this.ckbDB.UseVisualStyleBackColor = true;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(374, 143);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(241, 20);
            this.txtDB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "命名空间";
            // 
            // ckbBusiness
            // 
            this.ckbBusiness.AutoSize = true;
            this.ckbBusiness.Location = new System.Drawing.Point(232, 188);
            this.ckbBusiness.Name = "ckbBusiness";
            this.ckbBusiness.Size = new System.Drawing.Size(68, 17);
            this.ckbBusiness.TabIndex = 4;
            this.ckbBusiness.Text = "Business";
            this.ckbBusiness.UseVisualStyleBackColor = true;
            // 
            // txtBusiness
            // 
            this.txtBusiness.Location = new System.Drawing.Point(374, 186);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.Size = new System.Drawing.Size(241, 20);
            this.txtBusiness.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "命名空间";
            // 
            // GenerateCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusiness);
            this.Controls.Add(this.ckbBusiness);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.ckbDB);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.ckbModel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GenerateCodeForm";
            this.Text = "GenerateCode";
            this.Load += new System.EventHandler(this.GenerateCode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckblTables;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox ckbModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbDB;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbBusiness;
        private System.Windows.Forms.TextBox txtBusiness;
        private System.Windows.Forms.Label label3;
    }
}