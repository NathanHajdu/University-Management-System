namespace UniversitySystem
{
    partial class studentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentForm));
            this.studentLabel = new System.Windows.Forms.Label();
            this.SIDField = new System.Windows.Forms.TextBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.takesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fSUSystemDataSet = new UniversitySystem.FSUSystemDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.takesTableAdapter = new UniversitySystem.FSUSystemDataSetTableAdapters.TakesTableAdapter();
            this.tableAdapterManager = new UniversitySystem.FSUSystemDataSetTableAdapters.TableAdapterManager();
            this.studentTableAdapter = new UniversitySystem.FSUSystemDataSetTableAdapters.StudentTableAdapter();
            this.divider = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.btnMain = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.takesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentLabel.Location = new System.Drawing.Point(65, 177);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(128, 20);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Student ID (SID):";
            // 
            // SIDField
            // 
            this.SIDField.Location = new System.Drawing.Point(199, 179);
            this.SIDField.Name = "SIDField";
            this.SIDField.Size = new System.Drawing.Size(100, 20);
            this.SIDField.TabIndex = 1;
            // 
            // btnStudent
            // 
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(69, 215);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(94, 30);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Search";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // takesBindingSource
            // 
            this.takesBindingSource.DataMember = "Takes";
            this.takesBindingSource.DataSource = this.fSUSystemDataSet;
            // 
            // fSUSystemDataSet
            // 
            this.fSUSystemDataSet.DataSetName = "FSUSystemDataSet";
            this.fSUSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.fSUSystemDataSet;
            // 
            // takesTableAdapter
            // 
            this.takesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.InstructorTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TakesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UniversitySystem.FSUSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.LightSkyBlue;
            this.divider.ForeColor = System.Drawing.Color.Transparent;
            this.divider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.divider.Location = new System.Drawing.Point(69, 281);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(315, 2);
            this.divider.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(199, 592);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 30);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // studentGrid
            // 
            this.studentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.studentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Location = new System.Drawing.Point(70, 353);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.Size = new System.Drawing.Size(694, 213);
            this.studentGrid.TabIndex = 16;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMain.Location = new System.Drawing.Point(70, 592);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(113, 30);
            this.btnMain.TabIndex = 17;
            this.btnMain.Text = "Back to Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(67, 311);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 29);
            this.nameLabel.TabIndex = 13;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 679);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.studentGrid);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.SIDField);
            this.Controls.Add(this.studentLabel);
            this.Name = "studentForm";
            this.Text = "Student Directory";
            this.Load += new System.EventHandler(this.studentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.takesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.TextBox SIDField;
        private System.Windows.Forms.Button btnStudent;
        private FSUSystemDataSet fSUSystemDataSet;
        private System.Windows.Forms.BindingSource takesBindingSource;
        private FSUSystemDataSetTableAdapters.TakesTableAdapter takesTableAdapter;
        private FSUSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private FSUSystemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label nameLabel;
    }
}