namespace Examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.evaluar = new System.Windows.Forms.Button();
            this.portu = new System.Windows.Forms.CheckBox();
            this.CapMexico = new System.Windows.Forms.Label();
            this.gdl = new System.Windows.Forms.RadioButton();
            this.codBox = new System.Windows.Forms.TextBox();
            this.municipios = new System.Windows.Forms.NumericUpDown();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.df = new System.Windows.Forms.RadioButton();
            this.mty = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.reino = new System.Windows.Forms.CheckBox();
            this.mace = new System.Windows.Forms.CheckBox();
            this.chile = new System.Windows.Forms.CheckBox();
            this.aus = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.municipios)).BeginInit();
            this.SuspendLayout();
            // 
            // evaluar
            // 
            this.evaluar.Location = new System.Drawing.Point(758, 335);
            this.evaluar.Name = "evaluar";
            this.evaluar.Size = new System.Drawing.Size(121, 49);
            this.evaluar.TabIndex = 0;
            this.evaluar.Text = "Evaluar";
            this.evaluar.UseVisualStyleBackColor = true;
            this.evaluar.Click += new System.EventHandler(this.evaluar_Click);
            // 
            // portu
            // 
            this.portu.AutoSize = true;
            this.portu.Location = new System.Drawing.Point(49, 229);
            this.portu.Name = "portu";
            this.portu.Size = new System.Drawing.Size(64, 17);
            this.portu.TabIndex = 1;
            this.portu.Text = "portugal";
            this.portu.UseVisualStyleBackColor = true;
            // 
            // CapMexico
            // 
            this.CapMexico.AutoSize = true;
            this.CapMexico.Location = new System.Drawing.Point(46, 105);
            this.CapMexico.Name = "CapMexico";
            this.CapMexico.Size = new System.Drawing.Size(164, 13);
            this.CapMexico.TabIndex = 2;
            this.CapMexico.Text = "1- Cual es la Capital  de México ?";
            // 
            // gdl
            // 
            this.gdl.AutoSize = true;
            this.gdl.Location = new System.Drawing.Point(49, 141);
            this.gdl.Name = "gdl";
            this.gdl.Size = new System.Drawing.Size(47, 17);
            this.gdl.TabIndex = 3;
            this.gdl.TabStop = true;
            this.gdl.Text = "GDL";
            this.gdl.UseVisualStyleBackColor = true;
            // 
            // codBox
            // 
            this.codBox.Location = new System.Drawing.Point(75, 20);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(100, 20);
            this.codBox.TabIndex = 4;
            // 
            // municipios
            // 
            this.municipios.Location = new System.Drawing.Point(55, 394);
            this.municipios.Name = "municipios";
            this.municipios.Size = new System.Drawing.Size(41, 20);
            this.municipios.TabIndex = 5;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(512, 49);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 6;
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(75, 48);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(100, 20);
            this.nomBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "codigo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "nombre";
            // 
            // df
            // 
            this.df.AutoSize = true;
            this.df.Location = new System.Drawing.Point(156, 141);
            this.df.Name = "df";
            this.df.Size = new System.Drawing.Size(39, 17);
            this.df.TabIndex = 3;
            this.df.TabStop = true;
            this.df.Text = "DF";
            this.df.UseVisualStyleBackColor = true;
            // 
            // mty
            // 
            this.mty.AutoSize = true;
            this.mty.Location = new System.Drawing.Point(257, 141);
            this.mty.Name = "mty";
            this.mty.Size = new System.Drawing.Size(48, 17);
            this.mty.TabIndex = 3;
            this.mty.TabStop = true;
            this.mty.Text = "MTY";
            this.mty.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "2- Paises de Europa";
            // 
            // reino
            // 
            this.reino.AutoSize = true;
            this.reino.Location = new System.Drawing.Point(49, 252);
            this.reino.Name = "reino";
            this.reino.Size = new System.Drawing.Size(85, 17);
            this.reino.TabIndex = 1;
            this.reino.Text = "Reino Unido";
            this.reino.UseVisualStyleBackColor = true;
            // 
            // mace
            // 
            this.mace.AutoSize = true;
            this.mace.Location = new System.Drawing.Point(49, 275);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(79, 17);
            this.mace.TabIndex = 1;
            this.mace.Text = "Macedonia";
            this.mace.UseVisualStyleBackColor = true;
            // 
            // chile
            // 
            this.chile.AutoSize = true;
            this.chile.Location = new System.Drawing.Point(49, 298);
            this.chile.Name = "chile";
            this.chile.Size = new System.Drawing.Size(49, 17);
            this.chile.TabIndex = 1;
            this.chile.Text = "Chile";
            this.chile.UseVisualStyleBackColor = true;
            // 
            // aus
            // 
            this.aus.AutoSize = true;
            this.aus.Location = new System.Drawing.Point(49, 321);
            this.aus.Name = "aus";
            this.aus.Size = new System.Drawing.Size(66, 17);
            this.aus.TabIndex = 1;
            this.aus.Text = "Australia";
            this.aus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "3-  De Cuantos Municipios se compone Mexico?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "4- Fecha en que término la Segunda Guerra Mundial ?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 470);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.municipios);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.codBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mty);
            this.Controls.Add(this.df);
            this.Controls.Add(this.gdl);
            this.Controls.Add(this.CapMexico);
            this.Controls.Add(this.aus);
            this.Controls.Add(this.chile);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.reino);
            this.Controls.Add(this.portu);
            this.Controls.Add(this.evaluar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.municipios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button evaluar;
        private System.Windows.Forms.CheckBox portu;
        private System.Windows.Forms.Label CapMexico;
        private System.Windows.Forms.RadioButton gdl;
        private System.Windows.Forms.TextBox codBox;
        private System.Windows.Forms.NumericUpDown municipios;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton df;
        private System.Windows.Forms.RadioButton mty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox reino;
        private System.Windows.Forms.CheckBox mace;
        private System.Windows.Forms.CheckBox chile;
        private System.Windows.Forms.CheckBox aus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

