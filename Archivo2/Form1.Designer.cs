namespace Archivo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpAge = new System.Windows.Forms.DateTimePicker();
            this.lblGrade = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 72);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(45, 151);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(64, 25);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Edad:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 72);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(225, 30);
            this.tbName.TabIndex = 2;
            // 
            // dtpAge
            // 
            this.dtpAge.Location = new System.Drawing.Point(116, 151);
            this.dtpAge.Name = "dtpAge";
            this.dtpAge.Size = new System.Drawing.Size(366, 30);
            this.dtpAge.TabIndex = 3;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(45, 230);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(59, 25);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Nota:";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(111, 230);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(225, 30);
            this.tbGrade.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(45, 309);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Genero:";
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(135, 309);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(225, 30);
            this.tbGender.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(530, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 68);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 25;
            this.lbResults.Location = new System.Drawing.Point(705, 68);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(399, 329);
            this.lbResults.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.dtpAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpAge;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbResults;
    }
}

