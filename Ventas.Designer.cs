namespace WinFormsApp1
{
    partial class Ventas
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
            cb_clientes = new ComboBox();
            cb_vehiculo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            tx_precio = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // cb_clientes
            // 
            cb_clientes.FormattingEnabled = true;
            cb_clientes.Location = new Point(26, 37);
            cb_clientes.Name = "cb_clientes";
            cb_clientes.Size = new Size(183, 23);
            cb_clientes.TabIndex = 0;
            // 
            // cb_vehiculo
            // 
            cb_vehiculo.FormattingEnabled = true;
            cb_vehiculo.Location = new Point(25, 81);
            cb_vehiculo.Name = "cb_vehiculo";
            cb_vehiculo.Size = new Size(304, 23);
            cb_vehiculo.TabIndex = 1;
            cb_vehiculo.SelectedIndexChanged += cb_vehiculo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 63);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 23);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(254, 110);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 19);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // tx_precio
            // 
            tx_precio.Location = new Point(214, 37);
            tx_precio.Name = "tx_precio";
            tx_precio.Size = new Size(115, 23);
            tx_precio.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.Location = new Point(26, 149);
            listView1.Name = "listView1";
            listView1.Size = new Size(303, 97);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 272);
            Controls.Add(listView1);
            Controls.Add(tx_precio);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_vehiculo);
            Controls.Add(cb_clientes);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_clientes;
        private ComboBox cb_vehiculo;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox tx_precio;
        private ListView listView1;
    }
}