namespace SqlUpiti
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
            this.upitLabel = new System.Windows.Forms.Label();
            this.textBoxUpit = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rezultatLabel = new System.Windows.Forms.Label();
            this.buttonIzvrsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // upitLabel
            // 
            this.upitLabel.AutoSize = true;
            this.upitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upitLabel.Location = new System.Drawing.Point(12, 20);
            this.upitLabel.Name = "upitLabel";
            this.upitLabel.Size = new System.Drawing.Size(144, 16);
            this.upitLabel.TabIndex = 0;
            this.upitLabel.Text = "SELECT SQL upit:";
            // 
            // textBoxUpit
            // 
            this.textBoxUpit.Location = new System.Drawing.Point(82, 45);
            this.textBoxUpit.Multiline = true;
            this.textBoxUpit.Name = "textBoxUpit";
            this.textBoxUpit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUpit.Size = new System.Drawing.Size(320, 38);
            this.textBoxUpit.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 188);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // rezultatLabel
            // 
            this.rezultatLabel.AutoSize = true;
            this.rezultatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultatLabel.Location = new System.Drawing.Point(12, 105);
            this.rezultatLabel.Name = "rezultatLabel";
            this.rezultatLabel.Size = new System.Drawing.Size(109, 16);
            this.rezultatLabel.TabIndex = 3;
            this.rezultatLabel.Text = "Rezultat upita:";
            this.rezultatLabel.Visible = false;
            // 
            // buttonIzvrsi
            // 
            this.buttonIzvrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzvrsi.Location = new System.Drawing.Point(425, 60);
            this.buttonIzvrsi.Name = "buttonIzvrsi";
            this.buttonIzvrsi.Size = new System.Drawing.Size(75, 23);
            this.buttonIzvrsi.TabIndex = 4;
            this.buttonIzvrsi.Text = "Izvrsi";
            this.buttonIzvrsi.UseVisualStyleBackColor = true;
            this.buttonIzvrsi.Click += new System.EventHandler(this.buttonIzvrsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 347);
            this.Controls.Add(this.buttonIzvrsi);
            this.Controls.Add(this.rezultatLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxUpit);
            this.Controls.Add(this.upitLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL upit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upitLabel;
        private System.Windows.Forms.TextBox textBoxUpit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label rezultatLabel;
        private System.Windows.Forms.Button buttonIzvrsi;
    }
}

