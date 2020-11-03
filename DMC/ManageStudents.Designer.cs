namespace DMC
{
    partial class ManageStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudents));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.REG_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEGREE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COURSES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.edit_btn_icon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REG_NUMBER,
            this.NAME,
            this.DEGREE,
            this.COURSES});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView1.Location = new System.Drawing.Point(189, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.Size = new System.Drawing.Size(446, 244);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // REG_NUMBER
            // 
            this.REG_NUMBER.HeaderText = "Registration Number";
            this.REG_NUMBER.Name = "REG_NUMBER";
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Name";
            this.NAME.Name = "NAME";
            // 
            // DEGREE
            // 
            this.DEGREE.HeaderText = "Degree";
            this.DEGREE.Name = "DEGREE";
            // 
            // COURSES
            // 
            this.COURSES.HeaderText = "Courses";
            this.COURSES.Name = "COURSES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 29);
            this.label4.TabIndex = 145;
            this.label4.Text = "Manage Students";
            // 
            // edit_btn
            // 
            this.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit_btn.Location = new System.Drawing.Point(509, 367);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(126, 42);
            this.edit_btn.TabIndex = 128;
            this.edit_btn.Text = "Edit Details";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // edit_btn_icon
            // 
            this.edit_btn_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_btn_icon.BackgroundImage")));
            this.edit_btn_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_btn_icon.FlatAppearance.BorderSize = 0;
            this.edit_btn_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn_icon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn_icon.ForeColor = System.Drawing.Color.White;
            this.edit_btn_icon.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit_btn_icon.Location = new System.Drawing.Point(488, 376);
            this.edit_btn_icon.Name = "edit_btn_icon";
            this.edit_btn_icon.Size = new System.Drawing.Size(27, 23);
            this.edit_btn_icon.TabIndex = 129;
            this.edit_btn_icon.UseVisualStyleBackColor = true;
            this.edit_btn_icon.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(189, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 37);
            this.button1.TabIndex = 146;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edit_btn_icon);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.Name = "ManageStudents";
            this.Text = "ManageStudents";
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn REG_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEGREE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COURSES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button edit_btn_icon;
        private System.Windows.Forms.Button button1;
    }
}