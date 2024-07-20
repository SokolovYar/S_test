using System.Windows.Forms;

namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            treeView = new TreeView();
            contextMenu_TreeView = new ContextMenuStrip(components);
            addNewSectionToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            removeSelectedToolStripMenuItem = new ToolStripMenuItem();
            addQuestionToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem1 = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            checkBox4 = new CheckBox();
            textBox4 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            checkBox3 = new CheckBox();
            textBox3 = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            checkBox2 = new CheckBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            DescriptionTableLayoutPanel = new TableLayoutPanel();
            QPictureBox = new PictureBox();
            Description_textBox = new TextBox();
            Description_contextMenuStrip = new ContextMenuStrip(components);
            addImageToolStripMenuItem = new ToolStripMenuItem();
            removeImageToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel3 = new TableLayoutPanel();
            openFileDialog = new OpenFileDialog();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenu_TreeView.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            DescriptionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QPictureBox).BeginInit();
            Description_contextMenuStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(942, 527);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(942, 551);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(942, 527);
            splitContainer1.SplitterDistance = 329;
            splitContainer1.TabIndex = 0;
            // 
            // treeView
            // 
            treeView.ContextMenuStrip = contextMenu_TreeView;
            treeView.Dock = DockStyle.Fill;
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.Size = new Size(329, 527);
            treeView.TabIndex = 0;
            treeView.AfterSelect += TreeView_AfterSelect;
            // 
            // contextMenu_TreeView
            // 
            contextMenu_TreeView.Items.AddRange(new ToolStripItem[] { addNewSectionToolStripMenuItem, removeSelectedToolStripMenuItem });
            contextMenu_TreeView.Name = "contextMenu_TreeView";
            contextMenu_TreeView.Size = new Size(123, 48);
            // 
            // addNewSectionToolStripMenuItem
            // 
            addNewSectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem, editToolStripMenuItem });
            addNewSectionToolStripMenuItem.Name = "addNewSectionToolStripMenuItem";
            addNewSectionToolStripMenuItem.Size = new Size(122, 22);
            addNewSectionToolStripMenuItem.Text = "Section";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(117, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(117, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(117, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // removeSelectedToolStripMenuItem
            // 
            removeSelectedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addQuestionToolStripMenuItem, removeToolStripMenuItem1 });
            removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            removeSelectedToolStripMenuItem.Size = new Size(122, 22);
            removeSelectedToolStripMenuItem.Text = "Question";
            // 
            // addQuestionToolStripMenuItem
            // 
            addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            addQuestionToolStripMenuItem.Size = new Size(117, 22);
            addQuestionToolStripMenuItem.Text = "Add";
            addQuestionToolStripMenuItem.Click += addToolStripMenuItem1_Click;
            // 
            // removeToolStripMenuItem1
            // 
            removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            removeToolStripMenuItem1.Size = new Size(117, 22);
            removeToolStripMenuItem1.Text = "Remove";
            removeToolStripMenuItem1.Click += removeToolStripMenuItem1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(DescriptionTableLayoutPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.4428272F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.88857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8885746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.88857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8914528F));
            tableLayoutPanel1.Size = new Size(609, 527);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.509804F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.4902F));
            tableLayoutPanel6.Controls.Add(checkBox4, 0, 0);
            tableLayoutPanel6.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 438);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(603, 86);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Dock = DockStyle.Fill;
            checkBox4.Location = new Point(3, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(21, 80);
            checkBox4.TabIndex = 0;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(30, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(570, 80);
            textBox4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.509804F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.4902F));
            tableLayoutPanel5.Controls.Add(checkBox3, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 350);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(603, 82);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Dock = DockStyle.Fill;
            checkBox3.Location = new Point(3, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(21, 76);
            checkBox3.TabIndex = 0;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(30, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(570, 76);
            textBox3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.509804F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.4902F));
            tableLayoutPanel4.Controls.Add(checkBox2, 0, 0);
            tableLayoutPanel4.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 262);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(603, 82);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Dock = DockStyle.Fill;
            checkBox2.Location = new Point(3, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(21, 76);
            checkBox2.TabIndex = 0;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(30, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(570, 76);
            textBox2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 24);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 4);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 4;
            label1.Text = "Points for answer:";
            // 
            // button1
            // 
            button1.Location = new Point(0, 1);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 3;
            button1.Text = "Save question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(252, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(82, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.509804F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.4902F));
            tableLayoutPanel2.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 174);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(603, 82);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(21, 76);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(30, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(570, 76);
            textBox1.TabIndex = 1;
            // 
            // DescriptionTableLayoutPanel
            // 
            DescriptionTableLayoutPanel.ColumnCount = 2;
            DescriptionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            DescriptionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            DescriptionTableLayoutPanel.Controls.Add(QPictureBox, 1, 0);
            DescriptionTableLayoutPanel.Controls.Add(Description_textBox, 0, 0);
            DescriptionTableLayoutPanel.Dock = DockStyle.Fill;
            DescriptionTableLayoutPanel.Location = new Point(3, 3);
            DescriptionTableLayoutPanel.Name = "DescriptionTableLayoutPanel";
            DescriptionTableLayoutPanel.RowCount = 1;
            DescriptionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DescriptionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            DescriptionTableLayoutPanel.Size = new Size(603, 135);
            DescriptionTableLayoutPanel.TabIndex = 8;
            // 
            // QPictureBox
            // 
            QPictureBox.Dock = DockStyle.Fill;
            QPictureBox.Location = new Point(425, 3);
            QPictureBox.Name = "QPictureBox";
            QPictureBox.Size = new Size(175, 129);
            QPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            QPictureBox.TabIndex = 0;
            QPictureBox.TabStop = false;
            QPictureBox.Click += QPictureBox_Click;
            // 
            // Description_textBox
            // 
            Description_textBox.ContextMenuStrip = Description_contextMenuStrip;
            Description_textBox.Dock = DockStyle.Fill;
            Description_textBox.Location = new Point(3, 3);
            Description_textBox.Multiline = true;
            Description_textBox.Name = "Description_textBox";
            Description_textBox.Size = new Size(416, 129);
            Description_textBox.TabIndex = 1;
            // 
            // Description_contextMenuStrip
            // 
            Description_contextMenuStrip.Items.AddRange(new ToolStripItem[] { addImageToolStripMenuItem, removeImageToolStripMenuItem });
            Description_contextMenuStrip.Name = "Description_contextMenuStrip";
            Description_contextMenuStrip.Size = new Size(181, 70);
            // 
            // addImageToolStripMenuItem
            // 
            addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            addImageToolStripMenuItem.Size = new Size(180, 22);
            addImageToolStripMenuItem.Text = "Add image";
            addImageToolStripMenuItem.Click += addImageToolStripMenuItem_Click;
            // 
            // removeImageToolStripMenuItem
            // 
            removeImageToolStripMenuItem.Name = "removeImageToolStripMenuItem";
            removeImageToolStripMenuItem.Size = new Size(180, 22);
            removeImageToolStripMenuItem.Text = "Remove image";
            removeImageToolStripMenuItem.Click += removeImageToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(942, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.RestoreDirectory = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 551);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "S-Test editor";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenu_TreeView.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            DescriptionTableLayoutPanel.ResumeLayout(false);
            DescriptionTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QPictureBox).EndInit();
            Description_contextMenuStrip.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private SplitContainer splitContainer1;
        private TreeView treeView;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox checkBox1;
        private TableLayoutPanel tableLayoutPanel3;

        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel6;
        private CheckBox checkBox4;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox checkBox3;
        private TextBox textBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox checkBox2;
        private TextBox textBox2;
        private ContextMenuStrip contextMenu_TreeView;
        private ToolStripMenuItem addNewSectionToolStripMenuItem;
        private ToolStripMenuItem removeSelectedToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem addQuestionToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private TableLayoutPanel DescriptionTableLayoutPanel;
        private PictureBox QPictureBox;
        private TextBox Description_textBox;
        private ContextMenuStrip Description_contextMenuStrip;
        private ToolStripMenuItem addImageToolStripMenuItem;
        private ToolStripMenuItem removeImageToolStripMenuItem;
        private OpenFileDialog openFileDialog;
    }
}
