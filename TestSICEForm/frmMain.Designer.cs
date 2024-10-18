namespace TestSICEForm
{
    partial class frmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPregunta1 = new System.Windows.Forms.TabPage();
            this.tabPregunta2 = new System.Windows.Forms.TabPage();
            this.tabPregunta3 = new System.Windows.Forms.TabPage();
            this.tabPregunta4 = new System.Windows.Forms.TabPage();
            this.tabPregunta5 = new System.Windows.Forms.TabPage();
            this.tabPregunta6 = new System.Windows.Forms.TabPage();
            this.dgvPregunta2 = new System.Windows.Forms.DataGridView();
            this.dgvPregunta4 = new System.Windows.Forms.DataGridView();
            this.dgvPregunta5 = new System.Windows.Forms.DataGridView();
            this.dgvPregunta3 = new System.Windows.Forms.DataGridView();
            this.dgvPregunta1 = new System.Windows.Forms.DataGridView();
            this.dgvPregunta6 = new System.Windows.Forms.DataGridView();
            this.tabMain.SuspendLayout();
            this.tabPregunta1.SuspendLayout();
            this.tabPregunta2.SuspendLayout();
            this.tabPregunta3.SuspendLayout();
            this.tabPregunta4.SuspendLayout();
            this.tabPregunta5.SuspendLayout();
            this.tabPregunta6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPregunta1);
            this.tabMain.Controls.Add(this.tabPregunta2);
            this.tabMain.Controls.Add(this.tabPregunta3);
            this.tabMain.Controls.Add(this.tabPregunta4);
            this.tabMain.Controls.Add(this.tabPregunta5);
            this.tabMain.Controls.Add(this.tabPregunta6);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(804, 286);
            this.tabMain.TabIndex = 0;
            // 
            // tabPregunta1
            // 
            this.tabPregunta1.Controls.Add(this.dgvPregunta1);
            this.tabPregunta1.Location = new System.Drawing.Point(4, 22);
            this.tabPregunta1.Name = "tabPregunta1";
            this.tabPregunta1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPregunta1.Size = new System.Drawing.Size(792, 424);
            this.tabPregunta1.TabIndex = 0;
            this.tabPregunta1.Text = "1. ¿Cuántos cruces he recibido en el archivo?";
            this.tabPregunta1.UseVisualStyleBackColor = true;
            // 
            // tabPregunta2
            // 
            this.tabPregunta2.Controls.Add(this.dgvPregunta2);
            this.tabPregunta2.Location = new System.Drawing.Point(4, 22);
            this.tabPregunta2.Name = "tabPregunta2";
            this.tabPregunta2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPregunta2.Size = new System.Drawing.Size(792, 424);
            this.tabPregunta2.TabIndex = 1;
            this.tabPregunta2.Text = "2. ¿Cuál es el importe total de los cruces recibidos?";
            this.tabPregunta2.UseVisualStyleBackColor = true;
            // 
            // tabPregunta3
            // 
            this.tabPregunta3.Controls.Add(this.dgvPregunta3);
            this.tabPregunta3.Location = new System.Drawing.Point(4, 22);
            this.tabPregunta3.Name = "tabPregunta3";
            this.tabPregunta3.Size = new System.Drawing.Size(792, 424);
            this.tabPregunta3.TabIndex = 2;
            this.tabPregunta3.Text = "3. ¿Cuántos cruces he recibido en cada hora del día?";
            this.tabPregunta3.UseVisualStyleBackColor = true;
            // 
            // tabPregunta4
            // 
            this.tabPregunta4.Controls.Add(this.dgvPregunta4);
            this.tabPregunta4.Location = new System.Drawing.Point(4, 22);
            this.tabPregunta4.Name = "tabPregunta4";
            this.tabPregunta4.Size = new System.Drawing.Size(792, 424);
            this.tabPregunta4.TabIndex = 3;
            this.tabPregunta4.Text = "4. ¿Cuántos cruces he recibido por cada tipo de TAG?";
            this.tabPregunta4.UseVisualStyleBackColor = true;
            // 
            // tabPregunta5
            // 
            this.tabPregunta5.Controls.Add(this.dgvPregunta5);
            this.tabPregunta5.Location = new System.Drawing.Point(4, 22);
            this.tabPregunta5.Name = "tabPregunta5";
            this.tabPregunta5.Size = new System.Drawing.Size(792, 424);
            this.tabPregunta5.TabIndex = 4;
            this.tabPregunta5.Text = "5. Es necesario saber cuantos cruces he recibido por categoría cobrada.";
            this.tabPregunta5.UseVisualStyleBackColor = true;
            // 
            // tabPregunta6
            // 
            this.tabPregunta6.Controls.Add(this.dgvPregunta6);
            this.tabPregunta6.Location = new System.Drawing.Point(4, 22);
            this.tabPregunta6.Name = "tabPregunta6";
            this.tabPregunta6.Size = new System.Drawing.Size(796, 260);
            this.tabPregunta6.TabIndex = 5;
            this.tabPregunta6.Text = "6. ¿Existen discrepancias entre la categoría, categoría cobrada y categoría detec" +
    "tada?";
            this.tabPregunta6.UseVisualStyleBackColor = true;
            // 
            // dgvPregunta2
            // 
            this.dgvPregunta2.AllowUserToAddRows = false;
            this.dgvPregunta2.AllowUserToDeleteRows = false;
            this.dgvPregunta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregunta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregunta2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPregunta2.Location = new System.Drawing.Point(3, 3);
            this.dgvPregunta2.Name = "dgvPregunta2";
            this.dgvPregunta2.Size = new System.Drawing.Size(786, 418);
            this.dgvPregunta2.TabIndex = 0;
            // 
            // dgvPregunta4
            // 
            this.dgvPregunta4.AllowUserToAddRows = false;
            this.dgvPregunta4.AllowUserToDeleteRows = false;
            this.dgvPregunta4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregunta4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregunta4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPregunta4.Location = new System.Drawing.Point(0, 0);
            this.dgvPregunta4.Name = "dgvPregunta4";
            this.dgvPregunta4.Size = new System.Drawing.Size(792, 424);
            this.dgvPregunta4.TabIndex = 1;
            // 
            // dgvPregunta5
            // 
            this.dgvPregunta5.AllowUserToAddRows = false;
            this.dgvPregunta5.AllowUserToDeleteRows = false;
            this.dgvPregunta5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregunta5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregunta5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPregunta5.Location = new System.Drawing.Point(0, 0);
            this.dgvPregunta5.Name = "dgvPregunta5";
            this.dgvPregunta5.Size = new System.Drawing.Size(792, 424);
            this.dgvPregunta5.TabIndex = 2;
            // 
            // dgvPregunta3
            // 
            this.dgvPregunta3.AllowUserToAddRows = false;
            this.dgvPregunta3.AllowUserToDeleteRows = false;
            this.dgvPregunta3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregunta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregunta3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPregunta3.Location = new System.Drawing.Point(0, 0);
            this.dgvPregunta3.Name = "dgvPregunta3";
            this.dgvPregunta3.Size = new System.Drawing.Size(792, 424);
            this.dgvPregunta3.TabIndex = 2;
            // 
            // dgvPregunta1
            // 
            this.dgvPregunta1.AllowUserToAddRows = false;
            this.dgvPregunta1.AllowUserToDeleteRows = false;
            this.dgvPregunta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregunta1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPregunta1.Location = new System.Drawing.Point(3, 3);
            this.dgvPregunta1.Name = "dgvPregunta1";
            this.dgvPregunta1.Size = new System.Drawing.Size(786, 418);
            this.dgvPregunta1.TabIndex = 3;
            // 
            // dgvPregunta6
            // 
            this.dgvPregunta6.AllowUserToAddRows = false;
            this.dgvPregunta6.AllowUserToDeleteRows = false;
            this.dgvPregunta6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregunta6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregunta6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPregunta6.Location = new System.Drawing.Point(0, 0);
            this.dgvPregunta6.Name = "dgvPregunta6";
            this.dgvPregunta6.Size = new System.Drawing.Size(796, 260);
            this.dgvPregunta6.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 286);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tabMain.ResumeLayout(false);
            this.tabPregunta1.ResumeLayout(false);
            this.tabPregunta2.ResumeLayout(false);
            this.tabPregunta3.ResumeLayout(false);
            this.tabPregunta4.ResumeLayout(false);
            this.tabPregunta5.ResumeLayout(false);
            this.tabPregunta6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregunta6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPregunta1;
        private System.Windows.Forms.TabPage tabPregunta2;
        private System.Windows.Forms.TabPage tabPregunta3;
        private System.Windows.Forms.TabPage tabPregunta4;
        private System.Windows.Forms.TabPage tabPregunta5;
        private System.Windows.Forms.TabPage tabPregunta6;
        private System.Windows.Forms.DataGridView dgvPregunta2;
        private System.Windows.Forms.DataGridView dgvPregunta4;
        private System.Windows.Forms.DataGridView dgvPregunta5;
        private System.Windows.Forms.DataGridView dgvPregunta3;
        private System.Windows.Forms.DataGridView dgvPregunta1;
        private System.Windows.Forms.DataGridView dgvPregunta6;
    }
}

