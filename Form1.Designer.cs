namespace To_Do_List
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
            this.Tasks = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.LightGray;
            this.Tasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tasks.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasks.ForeColor = System.Drawing.Color.Black;
            this.Tasks.FormattingEnabled = true;
            this.Tasks.Location = new System.Drawing.Point(0, 0);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(566, 574);
            this.Tasks.TabIndex = 0;
            this.Tasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Tasks_ItemCheck);
            this.Tasks.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Tasks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mudir MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(587, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Mudir MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label.ForeColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(581, 219);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(134, 44);
            this.label.TabIndex = 4;
            this.label.Text = "Remove";
            // 
            // pbInfo
            // 
            this.pbInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbInfo.Image = global::To_Do_List.Properties.Resources.info;
            this.pbInfo.Location = new System.Drawing.Point(738, 382);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(120, 84);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 5;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.Info_Click);
            // 
            // pbRemove
            // 
            this.pbRemove.BackColor = System.Drawing.Color.Transparent;
            this.pbRemove.Image = global::To_Do_List.Properties.Resources.delete;
            this.pbRemove.Location = new System.Drawing.Point(738, 199);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(120, 84);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemove.TabIndex = 3;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.Image = global::To_Do_List.Properties.Resources.plus;
            this.pbAdd.Location = new System.Drawing.Point(738, 29);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(120, 84);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 1;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mudir MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(595, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 61);
            this.label2.TabIndex = 6;
            this.label2.Text = "Info";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(572, 523);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(321, 51);
            this.progressBar1.TabIndex = 7;
            // 
            // labProgress
            // 
            this.labProgress.AutoSize = true;
            this.labProgress.BackColor = System.Drawing.Color.White;
            this.labProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProgress.ForeColor = System.Drawing.Color.Black;
            this.labProgress.Location = new System.Drawing.Point(711, 540);
            this.labProgress.Name = "labProgress";
            this.labProgress.Size = new System.Drawing.Size(28, 16);
            this.labProgress.TabIndex = 8;
            this.labProgress.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(895, 574);
            this.Controls.Add(this.labProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.Tasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "To-Do-List";
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Tasks;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labProgress;
    }
}

