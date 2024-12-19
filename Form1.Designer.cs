namespace ChuyenDoi
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
            cbbGrUnit = new ComboBox();
            cbbTo = new ComboBox();
            cbbFrom = new ComboBox();
            textValue = new TextBox();
            dgvSave = new DataGridView();
            labelKQ = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSave).BeginInit();
            SuspendLayout();
            // 
            // cbbGrUnit
            // 
            cbbGrUnit.FormattingEnabled = true;
            cbbGrUnit.Location = new Point(12, 12);
            cbbGrUnit.Name = "cbbGrUnit";
            cbbGrUnit.Size = new Size(182, 33);
            cbbGrUnit.TabIndex = 0;
            // 
            // cbbTo
            // 
            cbbTo.FormattingEnabled = true;
            cbbTo.Location = new Point(428, 51);
            cbbTo.Name = "cbbTo";
            cbbTo.Size = new Size(182, 33);
            cbbTo.TabIndex = 2;
            // 
            // cbbFrom
            // 
            cbbFrom.FormattingEnabled = true;
            cbbFrom.Location = new Point(12, 51);
            cbbFrom.Name = "cbbFrom";
            cbbFrom.Size = new Size(182, 33);
            cbbFrom.TabIndex = 1;
            // 
            // textValue
            // 
            textValue.Location = new Point(12, 103);
            textValue.Name = "textValue";
            textValue.Size = new Size(182, 31);
            textValue.TabIndex = 3;
            // 
            // dgvSave
            // 
            dgvSave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSave.Location = new Point(12, 213);
            dgvSave.Name = "dgvSave";
            dgvSave.RowHeadersWidth = 62;
            dgvSave.RowTemplate.Height = 33;
            dgvSave.Size = new Size(843, 225);
            dgvSave.TabIndex = 4;
            // 
            // labelKQ
            // 
            labelKQ.AutoSize = true;
            labelKQ.Location = new Point(200, 106);
            labelKQ.Name = "labelKQ";
            labelKQ.Size = new Size(75, 25);
            labelKQ.TabIndex = 5;
            labelKQ.Text = "Kết Quả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 450);
            Controls.Add(labelKQ);
            Controls.Add(dgvSave);
            Controls.Add(textValue);
            Controls.Add(cbbFrom);
            Controls.Add(cbbTo);
            Controls.Add(cbbGrUnit);
            Name = "Form1";
            Text = "Chuyển Đổi Đơn Vị";
            ((System.ComponentModel.ISupportInitialize)dgvSave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbGrUnit;
        private ComboBox cbbTo;
        private ComboBox cbbFrom;
        private TextBox textValue;
        private DataGridView dgvSave;
        private Label labelKQ;
    }
}
