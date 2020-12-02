﻿namespace ProyectoFinalGruposAleatorios
{
    partial class frmPrincipal
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
            this.txtGruposCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarGrupos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarParticipante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtGruposCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGruposCantidad
            // 
            this.txtGruposCantidad.Location = new System.Drawing.Point(36, 414);
            this.txtGruposCantidad.Name = "txtGruposCantidad";
            this.txtGruposCantidad.Size = new System.Drawing.Size(120, 20);
            this.txtGruposCantidad.TabIndex = 24;
            this.txtGruposCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGruposCantidad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnGenerarGrupos
            // 
            this.btnGenerarGrupos.Location = new System.Drawing.Point(205, 451);
            this.btnGenerarGrupos.Name = "btnGenerarGrupos";
            this.btnGenerarGrupos.Size = new System.Drawing.Size(108, 33);
            this.btnGenerarGrupos.TabIndex = 23;
            this.btnGenerarGrupos.Text = "Generar grupos";
            this.btnGenerarGrupos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Participante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "¿Cuántos grupos quieres formar?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Grupos Aleatorios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingrese la lista de participantes y la cantidad de grupos a generar.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 20);
            this.textBox1.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 121);
            this.listBox1.TabIndex = 18;
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(155, 336);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTodo.TabIndex = 17;
            this.btnEliminarTodo.Text = "Eliminar todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Pegar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(155, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarParticipante
            // 
            this.btnAgregarParticipante.Location = new System.Drawing.Point(36, 161);
            this.btnAgregarParticipante.Name = "btnAgregarParticipante";
            this.btnAgregarParticipante.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarParticipante.TabIndex = 14;
            this.btnAgregarParticipante.Text = "Agregar";
            this.btnAgregarParticipante.UseVisualStyleBackColor = true;
            this.btnAgregarParticipante.Click += new System.EventHandler(this.btnAgregarParticipante_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 517);
            this.Controls.Add(this.txtGruposCantidad);
            this.Controls.Add(this.btnGenerarGrupos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarParticipante);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.txtGruposCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtGruposCantidad;
        private System.Windows.Forms.Button btnGenerarGrupos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarParticipante;
    }
}