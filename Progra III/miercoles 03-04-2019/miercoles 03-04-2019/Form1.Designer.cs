namespace miercoles_03_04_2019
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
            this.label1 = new System.Windows.Forms.Label();
            this.cargar = new System.Windows.Forms.Button();
            this.lsxlist = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linq";
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(369, 97);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(104, 37);
            this.cargar.TabIndex = 1;
            this.cargar.Text = "Cargar Datos";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // lsxlist
            // 
            this.lsxlist.FormattingEnabled = true;
            this.lsxlist.Location = new System.Drawing.Point(28, 71);
            this.lsxlist.Name = "lsxlist";
            this.lsxlist.Size = new System.Drawing.Size(204, 225);
            this.lsxlist.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Postre";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clean";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(547, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsxlist);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.ListBox lsxlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

