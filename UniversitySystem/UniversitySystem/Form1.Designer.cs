namespace UniversitySystem
{
    partial class FSUSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSUSystem));
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnInstructor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(68, 304);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(102, 37);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Search";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnInstructor
            // 
            this.btnInstructor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructor.Location = new System.Drawing.Point(68, 552);
            this.btnInstructor.Name = "btnInstructor";
            this.btnInstructor.Size = new System.Drawing.Size(102, 37);
            this.btnInstructor.TabIndex = 1;
            this.btnInstructor.Text = "Search";
            this.btnInstructor.UseVisualStyleBackColor = true;
            this.btnInstructor.Click += new System.EventHandler(this.btnInstructor_Click);
            // 
            // FSUSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnInstructor);
            this.Controls.Add(this.btnStudent);
            this.Name = "FSUSystem";
            this.Text = "FSU Directory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnInstructor;
    }
}

