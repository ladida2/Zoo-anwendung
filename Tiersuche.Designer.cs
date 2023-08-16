namespace Zoo
{
    partial class Tiersuche
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.tBSuche = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lBGefunden = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnZurück = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSuche);
            this.groupBox4.Controls.Add(this.tBSuche);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lBGefunden);
            this.groupBox4.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(29, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 323);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiersuche";
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(74, 285);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(75, 23);
            this.btnSuche.TabIndex = 3;
            this.btnSuche.Text = "Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click_1);
            // 
            // tBSuche
            // 
            this.tBSuche.Location = new System.Drawing.Point(15, 55);
            this.tBSuche.Name = "tBSuche";
            this.tBSuche.Size = new System.Drawing.Size(134, 23);
            this.tBSuche.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "Welches Tier suchen sie ";
            // 
            // lBGefunden
            // 
            this.lBGefunden.FormattingEnabled = true;
            this.lBGefunden.ItemHeight = 14;
            this.lBGefunden.Location = new System.Drawing.Point(6, 111);
            this.lBGefunden.Name = "lBGefunden";
            this.lBGefunden.Size = new System.Drawing.Size(217, 144);
            this.lBGefunden.TabIndex = 2;
            this.lBGefunden.SelectedIndexChanged += new System.EventHandler(this.lBGefunden_SelectedIndexChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(283, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnZurück
            // 
            this.btnZurück.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZurück.Location = new System.Drawing.Point(325, 283);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(139, 72);
            this.btnZurück.TabIndex = 4;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // Tiersuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 381);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "Tiersuche";
            this.Text = "Tiersuche";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox4;
        private Button btnSuche;
        private TextBox tBSuche;
        private Label label15;
        private ListBox lBGefunden;
        private PictureBox pictureBox2;
        private Button btnZurück;
    }
}