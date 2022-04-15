namespace Grundrechnungsarten
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
            this.Btn_Berechnen = new System.Windows.Forms.Button();
            this.Btn_Ende = new System.Windows.Forms.Button();
            this.Lbl_Plus = new System.Windows.Forms.Label();
            this.Lbl_Minus = new System.Windows.Forms.Label();
            this.Lbl_Mal = new System.Windows.Forms.Label();
            this.Lbl_Div = new System.Windows.Forms.Label();
            this.Txt_Zahl1 = new System.Windows.Forms.TextBox();
            this.Txt_Zahl2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Berechnen
            // 
            this.Btn_Berechnen.Location = new System.Drawing.Point(318, 53);
            this.Btn_Berechnen.Name = "Btn_Berechnen";
            this.Btn_Berechnen.Size = new System.Drawing.Size(75, 23);
            this.Btn_Berechnen.TabIndex = 0;
            this.Btn_Berechnen.Text = "Berechne";
            this.Btn_Berechnen.UseVisualStyleBackColor = true;
            this.Btn_Berechnen.Click += new System.EventHandler(this.Btn_Berechnen_Click);
            // 
            // Btn_Ende
            // 
            this.Btn_Ende.Location = new System.Drawing.Point(236, 235);
            this.Btn_Ende.Name = "Btn_Ende";
            this.Btn_Ende.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ende.TabIndex = 0;
            this.Btn_Ende.Text = "Ende";
            this.Btn_Ende.UseVisualStyleBackColor = true;
            this.Btn_Ende.Click += new System.EventHandler(this.Btn_Ende_Click);
            // 
            // Lbl_Plus
            // 
            this.Lbl_Plus.AutoSize = true;
            this.Lbl_Plus.Location = new System.Drawing.Point(31, 131);
            this.Lbl_Plus.Name = "Lbl_Plus";
            this.Lbl_Plus.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Plus.TabIndex = 1;
            this.Lbl_Plus.Text = "Summe";
            // 
            // Lbl_Minus
            // 
            this.Lbl_Minus.AutoSize = true;
            this.Lbl_Minus.Location = new System.Drawing.Point(31, 166);
            this.Lbl_Minus.Name = "Lbl_Minus";
            this.Lbl_Minus.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Minus.TabIndex = 1;
            this.Lbl_Minus.Text = "Differenz";
            // 
            // Lbl_Mal
            // 
            this.Lbl_Mal.AutoSize = true;
            this.Lbl_Mal.Location = new System.Drawing.Point(31, 201);
            this.Lbl_Mal.Name = "Lbl_Mal";
            this.Lbl_Mal.Size = new System.Drawing.Size(64, 13);
            this.Lbl_Mal.TabIndex = 1;
            this.Lbl_Mal.Text = "Produktwert";
            // 
            // Lbl_Div
            // 
            this.Lbl_Div.AutoSize = true;
            this.Lbl_Div.Location = new System.Drawing.Point(31, 235);
            this.Lbl_Div.Name = "Lbl_Div";
            this.Lbl_Div.Size = new System.Drawing.Size(79, 13);
            this.Lbl_Div.TabIndex = 1;
            this.Lbl_Div.Text = "Quotientenwert";
            // 
            // Txt_Zahl1
            // 
            this.Txt_Zahl1.Location = new System.Drawing.Point(34, 53);
            this.Txt_Zahl1.Name = "Txt_Zahl1";
            this.Txt_Zahl1.Size = new System.Drawing.Size(100, 20);
            this.Txt_Zahl1.TabIndex = 2;
            // 
            // Txt_Zahl2
            // 
            this.Txt_Zahl2.Location = new System.Drawing.Point(159, 53);
            this.Txt_Zahl2.Name = "Txt_Zahl2";
            this.Txt_Zahl2.Size = new System.Drawing.Size(100, 20);
            this.Txt_Zahl2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Zahl2);
            this.Controls.Add(this.Txt_Zahl1);
            this.Controls.Add(this.Lbl_Div);
            this.Controls.Add(this.Lbl_Mal);
            this.Controls.Add(this.Lbl_Minus);
            this.Controls.Add(this.Lbl_Plus);
            this.Controls.Add(this.Btn_Ende);
            this.Controls.Add(this.Btn_Berechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Berechnen;
        private System.Windows.Forms.Button Btn_Ende;
        private System.Windows.Forms.Label Lbl_Plus;
        private System.Windows.Forms.Label Lbl_Minus;
        private System.Windows.Forms.Label Lbl_Mal;
        private System.Windows.Forms.Label Lbl_Div;
        private System.Windows.Forms.TextBox Txt_Zahl1;
        private System.Windows.Forms.TextBox Txt_Zahl2;
    }
}

