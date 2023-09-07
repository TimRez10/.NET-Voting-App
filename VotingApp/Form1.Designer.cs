namespace VotingApp
{
    partial class VoteForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.lbl_step1 = new System.Windows.Forms.Label();
            this.lbl_step2 = new System.Windows.Forms.Label();
            this.lbl_step3 = new System.Windows.Forms.Label();
            this.partyList = new System.Windows.Forms.ListBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(210, 446);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(180, 70);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit Vote";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(193, 90);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(241, 26);
            this.txt_fname.TabIndex = 5;
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(101, 93);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(90, 20);
            this.lbl_fname.TabIndex = 6;
            this.lbl_fname.Text = "First Name:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(101, 122);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(90, 20);
            this.lbl_lname.TabIndex = 7;
            this.lbl_lname.Text = "Last Name:";
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(193, 122);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(241, 26);
            this.txt_lname.TabIndex = 8;
            // 
            // lbl_step1
            // 
            this.lbl_step1.AutoSize = true;
            this.lbl_step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step1.Location = new System.Drawing.Point(12, 54);
            this.lbl_step1.Name = "lbl_step1";
            this.lbl_step1.Size = new System.Drawing.Size(256, 20);
            this.lbl_step1.TabIndex = 9;
            this.lbl_step1.Text = "Step 1: Enter Your Information";
            // 
            // lbl_step2
            // 
            this.lbl_step2.AutoSize = true;
            this.lbl_step2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step2.Location = new System.Drawing.Point(12, 212);
            this.lbl_step2.Name = "lbl_step2";
            this.lbl_step2.Size = new System.Drawing.Size(209, 20);
            this.lbl_step2.TabIndex = 10;
            this.lbl_step2.Text = "Step 2: Select Your Vote";
            // 
            // lbl_step3
            // 
            this.lbl_step3.AutoSize = true;
            this.lbl_step3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step3.Location = new System.Drawing.Point(12, 397);
            this.lbl_step3.Name = "lbl_step3";
            this.lbl_step3.Size = new System.Drawing.Size(214, 20);
            this.lbl_step3.TabIndex = 11;
            this.lbl_step3.Text = "Step 3: Submit Your Vote";
            // 
            // partyList
            // 
            this.partyList.FormattingEnabled = true;
            this.partyList.ItemHeight = 20;
            this.partyList.Items.AddRange(new object[] {
            "RED Party",
            "BLU Party"});
            this.partyList.Location = new System.Drawing.Point(105, 253);
            this.partyList.Name = "partyList";
            this.partyList.Size = new System.Drawing.Size(329, 84);
            this.partyList.TabIndex = 12;
            this.partyList.SelectedIndexChanged += new System.EventHandler(this.partyList_SelectedIndexChanged);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_error.Location = new System.Drawing.Point(100, 546);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(320, 25);
            this.lbl_error.TabIndex = 13;
            this.lbl_error.Text = "Error: Information or vote is missing.";
            this.lbl_error.Visible = false;
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.partyList);
            this.Controls.Add(this.lbl_step3);
            this.Controls.Add(this.lbl_step2);
            this.Controls.Add(this.lbl_step1);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cast Your Vote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VoteForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label lbl_step1;
        private System.Windows.Forms.Label lbl_step2;
        private System.Windows.Forms.Label lbl_step3;
        private System.Windows.Forms.ListBox partyList;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

