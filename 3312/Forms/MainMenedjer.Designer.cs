
namespace _3312
{
    partial class MainMenedjer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bMenedjerMain = new System.Windows.Forms.Button();
            this.dgvMenedjer = new System.Windows.Forms.DataGridView();
            this.bMenedjerAdd = new System.Windows.Forms.Button();
            this.TbChangeMenedjerBut = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenedjer)).BeginInit();
            this.SuspendLayout();
            // 
            // bMenedjerMain
            // 
            this.bMenedjerMain.BackColor = System.Drawing.Color.Black;
            this.bMenedjerMain.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMenedjerMain.Location = new System.Drawing.Point(12, 105);
            this.bMenedjerMain.Name = "bMenedjerMain";
            this.bMenedjerMain.Size = new System.Drawing.Size(157, 150);
            this.bMenedjerMain.TabIndex = 0;
            this.bMenedjerMain.Text = "MenedjerLoad";
            this.bMenedjerMain.UseVisualStyleBackColor = false;
            this.bMenedjerMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMenedjer
            // 
            this.dgvMenedjer.AllowUserToAddRows = false;
            this.dgvMenedjer.AllowUserToDeleteRows = false;
            this.dgvMenedjer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenedjer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenedjer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenedjer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenedjer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fio,
            this.proc,
            this.oklad});
            this.dgvMenedjer.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMenedjer.Location = new System.Drawing.Point(164, 105);
            this.dgvMenedjer.Name = "dgvMenedjer";
            this.dgvMenedjer.ReadOnly = true;
            this.dgvMenedjer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenedjer.Size = new System.Drawing.Size(498, 150);
            this.dgvMenedjer.TabIndex = 1;
            this.dgvMenedjer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bMenedjerAdd
            // 
            this.bMenedjerAdd.BackColor = System.Drawing.Color.Black;
            this.bMenedjerAdd.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMenedjerAdd.Location = new System.Drawing.Point(660, 105);
            this.bMenedjerAdd.Name = "bMenedjerAdd";
            this.bMenedjerAdd.Size = new System.Drawing.Size(149, 150);
            this.bMenedjerAdd.TabIndex = 2;
            this.bMenedjerAdd.Text = "LoadAddForm";
            this.bMenedjerAdd.UseVisualStyleBackColor = false;
            this.bMenedjerAdd.Click += new System.EventHandler(this.bMenedjerAdd_Click);
            // 
            // TbChangeMenedjerBut
            // 
            this.TbChangeMenedjerBut.BackColor = System.Drawing.Color.Aqua;
            this.TbChangeMenedjerBut.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChangeMenedjerBut.ForeColor = System.Drawing.Color.Black;
            this.TbChangeMenedjerBut.Location = new System.Drawing.Point(12, 12);
            this.TbChangeMenedjerBut.Name = "TbChangeMenedjerBut";
            this.TbChangeMenedjerBut.Size = new System.Drawing.Size(798, 97);
            this.TbChangeMenedjerBut.TabIndex = 3;
            this.TbChangeMenedjerBut.Text = "ChangeMenedjer";
            this.TbChangeMenedjerBut.UseVisualStyleBackColor = false;
            this.TbChangeMenedjerBut.Click += new System.EventHandler(this.TbChangeMenedjerBut_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // fio
            // 
            this.fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fio.HeaderText = "FIO";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // proc
            // 
            this.proc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proc.HeaderText = "Procent Prodaj";
            this.proc.Name = "proc";
            this.proc.ReadOnly = true;
            // 
            // oklad
            // 
            this.oklad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oklad.HeaderText = "Oklad";
            this.oklad.Name = "oklad";
            this.oklad.ReadOnly = true;
            // 
            // MainMenedjer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(822, 268);
            this.Controls.Add(this.TbChangeMenedjerBut);
            this.Controls.Add(this.bMenedjerAdd);
            this.Controls.Add(this.dgvMenedjer);
            this.Controls.Add(this.bMenedjerMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Name = "MainMenedjer";
            this.Text = "MainMenedjer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenedjer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMenedjerMain;
        private System.Windows.Forms.DataGridView dgvMenedjer;
        private System.Windows.Forms.Button bMenedjerAdd;
        private System.Windows.Forms.Button TbChangeMenedjerBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn proc;
        private System.Windows.Forms.DataGridViewTextBoxColumn oklad;
    }
}

