namespace WikiPrototype
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            txtBoxName = new TextBox();
            lblName = new Label();
            lblCategory = new Label();
            lblStructure = new Label();
            lblDefinition = new Label();
            txtBoxCategory = new TextBox();
            txtBoxStructure = new TextBox();
            txtBoxDefinition = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            btnSearch = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(309, 27);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 184);
            listBox1.TabIndex = 0;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(75, 25);
            txtBoxName.Margin = new Padding(3, 2, 3, 2);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(110, 23);
            txtBoxName.TabIndex = 1;
            txtBoxName.MouseDoubleClick += txtBoxName_MouseDoubleClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(10, 52);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // lblStructure
            // 
            lblStructure.AutoSize = true;
            lblStructure.Location = new Point(10, 76);
            lblStructure.Name = "lblStructure";
            lblStructure.Size = new Size(55, 15);
            lblStructure.TabIndex = 4;
            lblStructure.Text = "Structure";
            // 
            // lblDefinition
            // 
            lblDefinition.AutoSize = true;
            lblDefinition.Location = new Point(4, 101);
            lblDefinition.Name = "lblDefinition";
            lblDefinition.Size = new Size(59, 15);
            lblDefinition.TabIndex = 5;
            lblDefinition.Text = "Definition";
            // 
            // txtBoxCategory
            // 
            txtBoxCategory.Location = new Point(75, 50);
            txtBoxCategory.Margin = new Padding(3, 2, 3, 2);
            txtBoxCategory.Name = "txtBoxCategory";
            txtBoxCategory.Size = new Size(110, 23);
            txtBoxCategory.TabIndex = 6;
            // 
            // txtBoxStructure
            // 
            txtBoxStructure.Location = new Point(75, 74);
            txtBoxStructure.Margin = new Padding(3, 2, 3, 2);
            txtBoxStructure.Name = "txtBoxStructure";
            txtBoxStructure.Size = new Size(110, 23);
            txtBoxStructure.TabIndex = 7;
            // 
            // txtBoxDefinition
            // 
            txtBoxDefinition.Location = new Point(75, 99);
            txtBoxDefinition.Margin = new Padding(3, 2, 3, 2);
            txtBoxDefinition.Name = "txtBoxDefinition";
            txtBoxDefinition.Size = new Size(110, 23);
            txtBoxDefinition.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(209, 23);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(209, 50);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(209, 76);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(209, 157);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(209, 183);
            btnOpen.Margin = new Padding(3, 2, 3, 2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(82, 22);
            btnOpen.TabIndex = 13;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(209, 102);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 216);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(640, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 238);
            Controls.Add(statusStrip1);
            Controls.Add(btnSearch);
            Controls.Add(btnOpen);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxDefinition);
            Controls.Add(txtBoxStructure);
            Controls.Add(txtBoxCategory);
            Controls.Add(lblDefinition);
            Controls.Add(lblStructure);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Controls.Add(txtBoxName);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox txtBoxName;
        private Label lblName;
        private Label lblCategory;
        private Label lblStructure;
        private Label lblDefinition;
        private TextBox txtBoxCategory;
        private TextBox txtBoxStructure;
        private TextBox txtBoxDefinition;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Button btnOpen;
        private Button btnSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}