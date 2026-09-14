namespace selector
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
            combodistro = new ComboBox();
            lbldescripcion = new Label();
            piclogo = new PictureBox();
            linkdescarga = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // combodistro
            // 
            combodistro.FormattingEnabled = true;
            combodistro.Location = new Point(142, 27);
            combodistro.Name = "combodistro";
            combodistro.Size = new Size(464, 23);
            combodistro.TabIndex = 0;
            combodistro.SelectedIndexChanged += combodistro_SelectedIndexChanged;
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Location = new Point(624, 91);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(41, 15);
            lbldescripcion.TabIndex = 1;
            lbldescripcion.Text = "label 1";
            // 
            // piclogo
            // 
            piclogo.Location = new Point(34, 137);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(236, 220);
            piclogo.TabIndex = 2;
            piclogo.TabStop = false;
            // 
            // linkdescarga
            // 
            linkdescarga.AutoSize = true;
            linkdescarga.Location = new Point(469, 247);
            linkdescarga.Name = "linkdescarga";
            linkdescarga.Size = new Size(60, 15);
            linkdescarga.TabIndex = 3;
            linkdescarga.TabStop = true;
            linkdescarga.Text = "linkLabel1";
            linkdescarga.LinkClicked += linkdescarga_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 470);
            Controls.Add(linkdescarga);
            Controls.Add(piclogo);
            Controls.Add(lbldescripcion);
            Controls.Add(combodistro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combodistro;
        private Label lbldescripcion;
        private PictureBox piclogo;
        private LinkLabel linkdescarga;
    }
}
