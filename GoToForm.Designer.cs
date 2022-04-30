namespace Notebook
{
    partial class GoToForm
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
            this.tbLineNum = new System.Windows.Forms.NumericUpDown();
            this.butGo = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.labGo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLineNum
            // 
            this.tbLineNum.Location = new System.Drawing.Point(15, 25);
            this.tbLineNum.Name = "tbLineNum";
            this.tbLineNum.Size = new System.Drawing.Size(126, 20);
            this.tbLineNum.TabIndex = 0;
            // 
            // butGo
            // 
            this.butGo.Location = new System.Drawing.Point(15, 48);
            this.butGo.Name = "butGo";
            this.butGo.Size = new System.Drawing.Size(60, 23);
            this.butGo.TabIndex = 1;
            this.butGo.Text = "&Перейти";
            this.butGo.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(81, 48);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(60, 23);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "&Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // labGo
            // 
            this.labGo.AutoSize = true;
            this.labGo.Location = new System.Drawing.Point(12, 9);
            this.labGo.Name = "labGo";
            this.labGo.Size = new System.Drawing.Size(125, 13);
            this.labGo.TabIndex = 3;
            this.labGo.Text = "Введите номер строки:";
            // 
            // GoToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 81);
            this.Controls.Add(this.labGo);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butGo);
            this.Controls.Add(this.tbLineNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToForm";
            this.ShowIcon = false;
            this.Text = "Перейти";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butGo;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label labGo;
        public System.Windows.Forms.NumericUpDown tbLineNum;
    }
}