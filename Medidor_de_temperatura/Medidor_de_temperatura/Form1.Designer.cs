namespace Medidor_de_temperatura
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
            cb_conexiones = new ComboBox();
            but_conectar = new Button();
            but_actualizar = new Button();
            but_desconectar = new Button();
            lab_temperatura = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cb_conexiones
            // 
            cb_conexiones.FormattingEnabled = true;
            cb_conexiones.Location = new Point(44, 140);
            cb_conexiones.Name = "cb_conexiones";
            cb_conexiones.Size = new Size(121, 23);
            cb_conexiones.TabIndex = 0;
            // 
            // but_conectar
            // 
            but_conectar.Location = new Point(193, 140);
            but_conectar.Name = "but_conectar";
            but_conectar.Size = new Size(86, 23);
            but_conectar.TabIndex = 1;
            but_conectar.Text = "Conectar";
            but_conectar.UseVisualStyleBackColor = true;
            but_conectar.Click += but_conectar_Click;
            // 
            // but_actualizar
            // 
            but_actualizar.Location = new Point(304, 140);
            but_actualizar.Name = "but_actualizar";
            but_actualizar.Size = new Size(86, 23);
            but_actualizar.TabIndex = 2;
            but_actualizar.Text = "Actualizar";
            but_actualizar.UseVisualStyleBackColor = true;
            but_actualizar.Click += but_actualizar_Click;
            // 
            // but_desconectar
            // 
            but_desconectar.Location = new Point(193, 180);
            but_desconectar.Name = "but_desconectar";
            but_desconectar.Size = new Size(86, 23);
            but_desconectar.TabIndex = 3;
            but_desconectar.Text = "Desconectar";
            but_desconectar.UseVisualStyleBackColor = true;
            but_desconectar.Click += but_desconectar_Click;
            // 
            // lab_temperatura
            // 
            lab_temperatura.Font = new Font("Gadugi", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab_temperatura.Location = new Point(44, 204);
            lab_temperatura.Name = "lab_temperatura";
            lab_temperatura.Size = new Size(346, 193);
            lab_temperatura.TabIndex = 4;
            lab_temperatura.Text = "Temperatura";
            lab_temperatura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Gill Sans Ultra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 5);
            label1.Name = "label1";
            label1.Size = new Size(346, 94);
            label1.TabIndex = 5;
            label1.Text = "Medidor de temperatura";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 406);
            Controls.Add(label1);
            Controls.Add(lab_temperatura);
            Controls.Add(but_desconectar);
            Controls.Add(but_actualizar);
            Controls.Add(but_conectar);
            Controls.Add(cb_conexiones);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cb_conexiones;
        private Button but_conectar;
        private Button but_actualizar;
        private Button but_desconectar;
        private Label lab_temperatura;
        private Label label1;
    }
}
