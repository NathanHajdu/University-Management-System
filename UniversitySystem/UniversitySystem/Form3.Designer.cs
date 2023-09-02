namespace UniversitySystem
{
    partial class instructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructorForm));
            this.btnInstructor = new System.Windows.Forms.Button();
            this.IIDField = new System.Windows.Forms.TextBox();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.fSUSystemDataSet = new UniversitySystem.FSUSystemDataSet();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter = new UniversitySystem.FSUSystemDataSetTableAdapters.InstructorTableAdapter();
            this.tableAdapterManager = new UniversitySystem.FSUSystemDataSetTableAdapters.TableAdapterManager();
            this.instructorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.instructorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.instructorGrid = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fSUSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingNavigator)).BeginInit();
            this.instructorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instructorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstructor
            // 
            this.btnInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructor.Location = new System.Drawing.Point(66, 201);
            this.btnInstructor.Name = "btnInstructor";
            this.btnInstructor.Size = new System.Drawing.Size(94, 30);
            this.btnInstructor.TabIndex = 5;
            this.btnInstructor.Text = "Search";
            this.btnInstructor.UseVisualStyleBackColor = true;
            this.btnInstructor.Click += new System.EventHandler(this.btnInstructor_Click);
            // 
            // IIDField
            // 
            this.IIDField.Location = new System.Drawing.Point(211, 167);
            this.IIDField.Name = "IIDField";
            this.IIDField.Size = new System.Drawing.Size(100, 20);
            this.IIDField.TabIndex = 4;
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructorLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instructorLabel.Location = new System.Drawing.Point(62, 165);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(140, 20);
            this.instructorLabel.TabIndex = 3;
            this.instructorLabel.Text = "Instructor ID (IID):";
            // 
            // fSUSystemDataSet
            // 
            this.fSUSystemDataSet.DataSetName = "FSUSystemDataSet";
            this.fSUSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataMember = "Instructor";
            this.instructorBindingSource.DataSource = this.fSUSystemDataSet;
            // 
            // instructorTableAdapter
            // 
            this.instructorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.InstructorTableAdapter = this.instructorTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TakesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UniversitySystem.FSUSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // instructorBindingNavigator
            // 
            this.instructorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.instructorBindingNavigator.BindingSource = this.instructorBindingSource;
            this.instructorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.instructorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.instructorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.instructorBindingNavigatorSaveItem});
            this.instructorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.instructorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.instructorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.instructorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.instructorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.instructorBindingNavigator.Name = "instructorBindingNavigator";
            this.instructorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.instructorBindingNavigator.Size = new System.Drawing.Size(1000, 25);
            this.instructorBindingNavigator.TabIndex = 6;
            this.instructorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // instructorBindingNavigatorSaveItem
            // 
            this.instructorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.instructorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("instructorBindingNavigatorSaveItem.Image")));
            this.instructorBindingNavigatorSaveItem.Name = "instructorBindingNavigatorSaveItem";
            this.instructorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.instructorBindingNavigatorSaveItem.Text = "Save Data";
            this.instructorBindingNavigatorSaveItem.Click += new System.EventHandler(this.instructorBindingNavigatorSaveItem_Click);
            // 
            // instructorGrid
            // 
            this.instructorGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.instructorGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructorGrid.Location = new System.Drawing.Point(71, 335);
            this.instructorGrid.Name = "instructorGrid";
            this.instructorGrid.Size = new System.Drawing.Size(672, 231);
            this.instructorGrid.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(66, 290);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 29);
            this.nameLabel.TabIndex = 8;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.LightSkyBlue;
            this.divider.ForeColor = System.Drawing.Color.Transparent;
            this.divider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.divider.Location = new System.Drawing.Point(68, 263);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(315, 2);
            this.divider.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(198, 581);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 30);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMain.Location = new System.Drawing.Point(69, 581);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(113, 30);
            this.btnMain.TabIndex = 12;
            this.btnMain.Text = "Back to Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // instructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 674);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.instructorGrid);
            this.Controls.Add(this.instructorBindingNavigator);
            this.Controls.Add(this.btnInstructor);
            this.Controls.Add(this.IIDField);
            this.Controls.Add(this.instructorLabel);
            this.Name = "instructorForm";
            this.Text = "Instructor Directory";
            this.Load += new System.EventHandler(this.instructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fSUSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingNavigator)).EndInit();
            this.instructorBindingNavigator.ResumeLayout(false);
            this.instructorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instructorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstructor;
        private System.Windows.Forms.TextBox IIDField;
        private System.Windows.Forms.Label instructorLabel;
        private FSUSystemDataSet fSUSystemDataSet;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private FSUSystemDataSetTableAdapters.InstructorTableAdapter instructorTableAdapter;
        private FSUSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator instructorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton instructorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView instructorGrid;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMain;
    }
}