namespace ConexionDBMySqlWF
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombreconsola = new System.Windows.Forms.TextBox();
            this.textBoxCompania = new System.Windows.Forms.TextBox();
            this.dateTimePickerAnioLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBuscarById = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonTodos = new System.Windows.Forms.Button();
            this.buttonInsertarModel = new System.Windows.Forms.Button();
            this.textBoxgeneracion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NombreConsola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anio Lanzamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Generacion";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(175, 57);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(76, 20);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxNombreconsola
            // 
            this.textBoxNombreconsola.Location = new System.Drawing.Point(178, 102);
            this.textBoxNombreconsola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreconsola.Name = "textBoxNombreconsola";
            this.textBoxNombreconsola.Size = new System.Drawing.Size(404, 20);
            this.textBoxNombreconsola.TabIndex = 7;
            // 
            // textBoxCompania
            // 
            this.textBoxCompania.Location = new System.Drawing.Point(179, 145);
            this.textBoxCompania.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCompania.Name = "textBoxCompania";
            this.textBoxCompania.Size = new System.Drawing.Size(403, 20);
            this.textBoxCompania.TabIndex = 8;
            // 
            // dateTimePickerAnioLanzamiento
            // 
            this.dateTimePickerAnioLanzamiento.Location = new System.Drawing.Point(185, 222);
            this.dateTimePickerAnioLanzamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerAnioLanzamiento.Name = "dateTimePickerAnioLanzamiento";
            this.dateTimePickerAnioLanzamiento.Size = new System.Drawing.Size(332, 20);
            this.dateTimePickerAnioLanzamiento.TabIndex = 9;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(33, 40);
            this.buttonInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(121, 37);
            this.buttonInsertar.TabIndex = 13;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(41, 104);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 41);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonBuscarById
            // 
            this.buttonBuscarById.Location = new System.Drawing.Point(261, 57);
            this.buttonBuscarById.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarById.Name = "buttonBuscarById";
            this.buttonBuscarById.Size = new System.Drawing.Size(56, 19);
            this.buttonBuscarById.TabIndex = 15;
            this.buttonBuscarById.Text = "Buscar";
            this.buttonBuscarById.UseVisualStyleBackColor = true;
            this.buttonBuscarById.Click += new System.EventHandler(this.buttonBuscarById_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInsertar);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(658, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 189);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD Sin Modelo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNext);
            this.groupBox2.Controls.Add(this.buttonTodos);
            this.groupBox2.Controls.Add(this.buttonInsertarModel);
            this.groupBox2.Location = new System.Drawing.Point(658, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(181, 206);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crud Con Model";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(43, 150);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 29);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonTodos
            // 
            this.buttonTodos.Location = new System.Drawing.Point(34, 87);
            this.buttonTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(84, 34);
            this.buttonTodos.TabIndex = 19;
            this.buttonTodos.Text = "Todos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            this.buttonTodos.Click += new System.EventHandler(this.buttonTodos_Click);
            // 
            // buttonInsertarModel
            // 
            this.buttonInsertarModel.Location = new System.Drawing.Point(31, 33);
            this.buttonInsertarModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsertarModel.Name = "buttonInsertarModel";
            this.buttonInsertarModel.Size = new System.Drawing.Size(88, 39);
            this.buttonInsertarModel.TabIndex = 18;
            this.buttonInsertarModel.Text = "Insertar Model";
            this.buttonInsertarModel.UseVisualStyleBackColor = true;
            this.buttonInsertarModel.Click += new System.EventHandler(this.buttonInsertarModel_Click);
            // 
            // textBoxgeneracion
            // 
            this.textBoxgeneracion.Location = new System.Drawing.Point(185, 287);
            this.textBoxgeneracion.Name = "textBoxgeneracion";
            this.textBoxgeneracion.Size = new System.Drawing.Size(287, 20);
            this.textBoxgeneracion.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 554);
            this.Controls.Add(this.textBoxgeneracion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBuscarById);
            this.Controls.Add(this.dateTimePickerAnioLanzamiento);
            this.Controls.Add(this.textBoxCompania);
            this.Controls.Add(this.textBoxNombreconsola);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombreconsola;
        private System.Windows.Forms.TextBox textBoxCompania;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnioLanzamiento;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonBuscarById;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonInsertarModel;
        private System.Windows.Forms.Button buttonTodos;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxgeneracion;
    }
}

