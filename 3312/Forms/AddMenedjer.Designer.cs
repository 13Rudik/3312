
namespace _3312.Forms
{
    partial class AddMenedjer
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
            this.tbMenedjerFio = new System.Windows.Forms.TextBox();
            this.tbMenedjerProc = new System.Windows.Forms.TextBox();
            this.lMenedjer = new System.Windows.Forms.Label();
            this.lMenedjerFio = new System.Windows.Forms.Label();
            this.lMenedjerProc = new System.Windows.Forms.Label();
            this.tbMenedjerOklad = new System.Windows.Forms.TextBox();
            this.lMenedjerOklad = new System.Windows.Forms.Label();
            this.bMenedjerAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMenedjerFio
            // 
            this.tbMenedjerFio.Location = new System.Drawing.Point(85, 35);
            this.tbMenedjerFio.Name = "tbMenedjerFio";
            this.tbMenedjerFio.Size = new System.Drawing.Size(100, 20);
            this.tbMenedjerFio.TabIndex = 1;
            // 
            // tbMenedjerProc
            // 
            this.tbMenedjerProc.Location = new System.Drawing.Point(108, 73);
            this.tbMenedjerProc.Name = "tbMenedjerProc";
            this.tbMenedjerProc.Size = new System.Drawing.Size(100, 20);
            this.tbMenedjerProc.TabIndex = 2;
            // 
            // lMenedjer
            // 
            this.lMenedjer.AutoSize = true;
            this.lMenedjer.Location = new System.Drawing.Point(31, 35);
            this.lMenedjer.Name = "lMenedjer";
            this.lMenedjer.Size = new System.Drawing.Size(0, 13);
            this.lMenedjer.TabIndex = 3;
            // 
            // lMenedjerFio
            // 
            this.lMenedjerFio.AutoSize = true;
            this.lMenedjerFio.Location = new System.Drawing.Point(25, 42);
            this.lMenedjerFio.Name = "lMenedjerFio";
            this.lMenedjerFio.Size = new System.Drawing.Size(24, 13);
            this.lMenedjerFio.TabIndex = 4;
            this.lMenedjerFio.Text = "FIO";
            // 
            // lMenedjerProc
            // 
            this.lMenedjerProc.AutoSize = true;
            this.lMenedjerProc.Location = new System.Drawing.Point(12, 76);
            this.lMenedjerProc.Name = "lMenedjerProc";
            this.lMenedjerProc.Size = new System.Drawing.Size(77, 13);
            this.lMenedjerProc.TabIndex = 5;
            this.lMenedjerProc.Text = "Procent Prodaj";
            // 
            // tbMenedjerOklad
            // 
            this.tbMenedjerOklad.Location = new System.Drawing.Point(85, 110);
            this.tbMenedjerOklad.Name = "tbMenedjerOklad";
            this.tbMenedjerOklad.Size = new System.Drawing.Size(100, 20);
            this.tbMenedjerOklad.TabIndex = 7;
            // 
            // lMenedjerOklad
            // 
            this.lMenedjerOklad.AutoSize = true;
            this.lMenedjerOklad.Location = new System.Drawing.Point(25, 113);
            this.lMenedjerOklad.Name = "lMenedjerOklad";
            this.lMenedjerOklad.Size = new System.Drawing.Size(35, 13);
            this.lMenedjerOklad.TabIndex = 8;
            this.lMenedjerOklad.Text = "Oklad";
            // 
            // bMenedjerAdd
            // 
            this.bMenedjerAdd.Location = new System.Drawing.Point(12, 152);
            this.bMenedjerAdd.Name = "bMenedjerAdd";
            this.bMenedjerAdd.Size = new System.Drawing.Size(277, 23);
            this.bMenedjerAdd.TabIndex = 9;
            this.bMenedjerAdd.Text = "AddMenedjer";
            this.bMenedjerAdd.UseVisualStyleBackColor = true;
            this.bMenedjerAdd.Click += new System.EventHandler(this.bMenedjerAdd_Click);
            // 
            // AddMenedjer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 187);
            this.Controls.Add(this.bMenedjerAdd);
            this.Controls.Add(this.lMenedjerOklad);
            this.Controls.Add(this.tbMenedjerOklad);
            this.Controls.Add(this.lMenedjerProc);
            this.Controls.Add(this.lMenedjerFio);
            this.Controls.Add(this.lMenedjer);
            this.Controls.Add(this.tbMenedjerProc);
            this.Controls.Add(this.tbMenedjerFio);
            this.Name = "AddMenedjer";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMenedjerFio;
        private System.Windows.Forms.TextBox tbMenedjerProc;
        private System.Windows.Forms.Label lMenedjer;
        private System.Windows.Forms.Label lMenedjerFio;
        private System.Windows.Forms.Label lMenedjerProc;
        private System.Windows.Forms.TextBox tbMenedjerOklad;
        private System.Windows.Forms.Label lMenedjerOklad;
        private System.Windows.Forms.Button bMenedjerAdd;
    }
}