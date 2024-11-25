namespace WinForm3
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
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txtedad = new TextBox();
            btnguardar = new Button();
            btnlimpiar = new Button();
            grilla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 92);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Edad :";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(121, 21);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(399, 27);
            txtnombre.TabIndex = 2;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(121, 92);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(188, 27);
            txtedad.TabIndex = 3;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(565, 21);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(141, 77);
            btnguardar.TabIndex = 4;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(742, 24);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(141, 74);
            btnlimpiar.TabIndex = 5;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click; 
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(30, 172);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(853, 399);
            grilla.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 663);
            Controls.Add(grilla);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(txtedad);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txtedad;
        private Button btnguardar;
        private Button btnlimpiar;
        private DataGridView grilla;
    }
}
