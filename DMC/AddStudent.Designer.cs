namespace DMC
{
    partial class AddStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.degreetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.edit_btn_icon = new System.Windows.Forms.Button();
            this.del_btn_icon = new System.Windows.Forms.Button();
            this.cancel_btn_icon = new System.Windows.Forms.Button();
            this.save_btn_icon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(139, 143);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(115, 20);
            this.nametxt.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 132;
            this.label2.Text = "Name:";
            // 
            // degreetxt
            // 
            this.degreetxt.Location = new System.Drawing.Point(139, 248);
            this.degreetxt.Name = "degreetxt";
            this.degreetxt.Size = new System.Drawing.Size(115, 20);
            this.degreetxt.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 130;
            this.label1.Text = "Degree:";
            // 
            // regno
            // 
            this.regno.Location = new System.Drawing.Point(139, 195);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(115, 20);
            this.regno.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 128;
            this.label3.Text = "Reg No:";
            // 
            // edit_btn
            // 
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit_btn.Location = new System.Drawing.Point(573, 321);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(47, 37);
            this.edit_btn.TabIndex = 135;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView1.Location = new System.Drawing.Point(317, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.Size = new System.Drawing.Size(446, 181);
            this.dataGridView1.TabIndex = 134;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "COURSE_ID";
            this.Column1.HeaderText = "Course ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "COURSE_NAME";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CRDHRS";
            this.Column3.HeaderText = "Credit Hours";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MARKS";
            this.Column4.HeaderText = "Marks";
            this.Column4.Name = "Column4";
            // 
            // del_btn
            // 
            this.del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.del_btn.Location = new System.Drawing.Point(697, 324);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(66, 30);
            this.del_btn.TabIndex = 136;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.save_btn.Location = new System.Drawing.Point(702, 395);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(56, 37);
            this.save_btn.TabIndex = 138;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_btn.Location = new System.Drawing.Point(84, 395);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(71, 37);
            this.cancel_btn.TabIndex = 139;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
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
            this.edit_btn_icon.Location = new System.Drawing.Point(547, 325);
            this.edit_btn_icon.Name = "edit_btn_icon";
            this.edit_btn_icon.Size = new System.Drawing.Size(28, 27);
            this.edit_btn_icon.TabIndex = 140;
            this.edit_btn_icon.UseVisualStyleBackColor = true;
            // 
            // del_btn_icon
            // 
            this.del_btn_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("del_btn_icon.BackgroundImage")));
            this.del_btn_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del_btn_icon.FlatAppearance.BorderSize = 0;
            this.del_btn_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn_icon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn_icon.ForeColor = System.Drawing.Color.White;
            this.del_btn_icon.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.del_btn_icon.Location = new System.Drawing.Point(673, 324);
            this.del_btn_icon.Name = "del_btn_icon";
            this.del_btn_icon.Size = new System.Drawing.Size(28, 27);
            this.del_btn_icon.TabIndex = 141;
            this.del_btn_icon.UseVisualStyleBackColor = true;
            // 
            // cancel_btn_icon
            // 
            this.cancel_btn_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_btn_icon.BackgroundImage")));
            this.cancel_btn_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancel_btn_icon.FlatAppearance.BorderSize = 0;
            this.cancel_btn_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn_icon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn_icon.ForeColor = System.Drawing.Color.White;
            this.cancel_btn_icon.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_btn_icon.Location = new System.Drawing.Point(59, 400);
            this.cancel_btn_icon.Name = "cancel_btn_icon";
            this.cancel_btn_icon.Size = new System.Drawing.Size(25, 26);
            this.cancel_btn_icon.TabIndex = 142;
            this.cancel_btn_icon.UseVisualStyleBackColor = true;
            // 
            // save_btn_icon
            // 
            this.save_btn_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_btn_icon.BackgroundImage")));
            this.save_btn_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_btn_icon.FlatAppearance.BorderSize = 0;
            this.save_btn_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn_icon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn_icon.ForeColor = System.Drawing.Color.White;
            this.save_btn_icon.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.save_btn_icon.Location = new System.Drawing.Point(675, 400);
            this.save_btn_icon.Name = "save_btn_icon";
            this.save_btn_icon.Size = new System.Drawing.Size(28, 27);
            this.save_btn_icon.TabIndex = 143;
            this.save_btn_icon.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 144;
            this.label4.Text = "Add Students";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(321, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 37);
            this.button1.TabIndex = 145;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(128, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 37);
            this.button2.TabIndex = 148;
            this.button2.Text = "Add Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(812, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save_btn_icon);
            this.Controls.Add(this.cancel_btn_icon);
            this.Controls.Add(this.del_btn_icon);
            this.Controls.Add(this.edit_btn_icon);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.degreetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regno);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button edit_btn_icon;
        private System.Windows.Forms.Button del_btn_icon;
        private System.Windows.Forms.Button cancel_btn_icon;
        private System.Windows.Forms.Button save_btn_icon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox degreetxt;
        private System.Windows.Forms.Button button2;
    }
}