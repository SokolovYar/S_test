namespace S_Editor
{
    partial class SectionAdjust
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
            label_SectionDescription = new Label();
            textBox_Description = new TextBox();
            checkBox_isRandom = new CheckBox();
            label_count = new Label();
            label_qCount = new Label();
            label_toAsk = new Label();
            numericUpDown_QToAsk = new NumericUpDown();
            btn_Cancel = new Button();
            btn_OK = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_QToAsk).BeginInit();
            SuspendLayout();
            // 
            // label_SectionDescription
            // 
            label_SectionDescription.AutoSize = true;
            label_SectionDescription.Location = new Point(11, 7);
            label_SectionDescription.Name = "label_SectionDescription";
            label_SectionDescription.Size = new Size(111, 15);
            label_SectionDescription.TabIndex = 1;
            label_SectionDescription.Text = "Section description:";
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(12, 26);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(514, 77);
            textBox_Description.TabIndex = 3;
            // 
            // checkBox_isRandom
            // 
            checkBox_isRandom.AutoSize = true;
            checkBox_isRandom.Location = new Point(441, 110);
            checkBox_isRandom.Name = "checkBox_isRandom";
            checkBox_isRandom.Size = new Size(85, 19);
            checkBox_isRandom.TabIndex = 4;
            checkBox_isRandom.Text = "Randomize";
            checkBox_isRandom.UseVisualStyleBackColor = true;
            // 
            // label_count
            // 
            label_count.AutoSize = true;
            label_count.Location = new Point(12, 112);
            label_count.Name = "label_count";
            label_count.Size = new Size(106, 15);
            label_count.TabIndex = 5;
            label_count.Text = "Count of question:";
            // 
            // label_qCount
            // 
            label_qCount.AutoSize = true;
            label_qCount.Location = new Point(123, 112);
            label_qCount.Name = "label_qCount";
            label_qCount.Size = new Size(13, 15);
            label_qCount.TabIndex = 6;
            label_qCount.Text = "1";
            // 
            // label_toAsk
            // 
            label_toAsk.AutoSize = true;
            label_toAsk.Location = new Point(184, 110);
            label_toAsk.Name = "label_toAsk";
            label_toAsk.Size = new Size(97, 15);
            label_toAsk.TabIndex = 7;
            label_toAsk.Text = "Questions to ask:";
            // 
            // numericUpDown_QToAsk
            // 
            numericUpDown_QToAsk.Location = new Point(287, 106);
            numericUpDown_QToAsk.Name = "numericUpDown_QToAsk";
            numericUpDown_QToAsk.Size = new Size(76, 23);
            numericUpDown_QToAsk.TabIndex = 8;
            numericUpDown_QToAsk.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(451, 145);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 9;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(370, 145);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(75, 23);
            btn_OK.TabIndex = 10;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // SectionAdjust
            // 
            AcceptButton = btn_OK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(536, 179);
            Controls.Add(btn_OK);
            Controls.Add(btn_Cancel);
            Controls.Add(numericUpDown_QToAsk);
            Controls.Add(label_toAsk);
            Controls.Add(label_qCount);
            Controls.Add(label_count);
            Controls.Add(checkBox_isRandom);
            Controls.Add(textBox_Description);
            Controls.Add(label_SectionDescription);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SectionAdjust";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Section adjustment";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_QToAsk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_SectionDescription;
        private TextBox textBox_Description;
        private CheckBox checkBox_isRandom;
        private Label label_count;
        private Label label_qCount;
        private Label label_toAsk;
        private NumericUpDown numericUpDown_QToAsk;
        private Button btn_Cancel;
        private Button btn_OK;
    }
}