namespace Zoo
{
    partial class Themen_und_Gehege
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnKontilist = new System.Windows.Forms.Button();
            this.cBThemenGehege = new System.Windows.Forms.ComboBox();
            this.lBThemenGehege = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lBGehegeTier = new System.Windows.Forms.ListBox();
            this.cBTierGehege = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnZurück1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGehegeList = new System.Windows.Forms.Button();
            this.cBGehegeKontinent = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdateGehege = new System.Windows.Forms.Button();
            this.lBGehege = new System.Windows.Forms.ListBox();
            this.btnLöschenGehege = new System.Windows.Forms.Button();
            this.btnSaveGehege = new System.Windows.Forms.Button();
            this.tBGehegeGroesse = new System.Windows.Forms.TextBox();
            this.tBGehegeName = new System.Windows.Forms.TextBox();
            this.tBGehegeID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnKontilist);
            this.groupBox5.Controls.Add(this.cBThemenGehege);
            this.groupBox5.Controls.Add(this.lBThemenGehege);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(570, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(238, 217);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Themen";
            // 
            // btnKontilist
            // 
            this.btnKontilist.Location = new System.Drawing.Point(71, 188);
            this.btnKontilist.Name = "btnKontilist";
            this.btnKontilist.Size = new System.Drawing.Size(95, 23);
            this.btnKontilist.TabIndex = 12;
            this.btnKontilist.Text = "Kontinent Liste";
            this.btnKontilist.UseVisualStyleBackColor = true;
            this.btnKontilist.Click += new System.EventHandler(this.btnKontilist_Click);
            // 
            // cBThemenGehege
            // 
            this.cBThemenGehege.FormattingEnabled = true;
            this.cBThemenGehege.Location = new System.Drawing.Point(71, 34);
            this.cBThemenGehege.Name = "cBThemenGehege";
            this.cBThemenGehege.Size = new System.Drawing.Size(121, 22);
            this.cBThemenGehege.TabIndex = 8;
            this.cBThemenGehege.SelectedIndexChanged += new System.EventHandler(this.cBThemenGehege_SelectedIndexChanged_1);
            // 
            // lBThemenGehege
            // 
            this.lBThemenGehege.FormattingEnabled = true;
            this.lBThemenGehege.ItemHeight = 14;
            this.lBThemenGehege.Location = new System.Drawing.Point(29, 79);
            this.lBThemenGehege.Name = "lBThemenGehege";
            this.lBThemenGehege.Size = new System.Drawing.Size(180, 88);
            this.lBThemenGehege.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 14);
            this.label16.TabIndex = 11;
            this.label16.Text = "Kontinent";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lBGehegeTier);
            this.groupBox6.Controls.Add(this.cBTierGehege);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(570, 244);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 252);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Welche Tiere in welchem Gehege";
            // 
            // lBGehegeTier
            // 
            this.lBGehegeTier.FormattingEnabled = true;
            this.lBGehegeTier.ItemHeight = 14;
            this.lBGehegeTier.Location = new System.Drawing.Point(29, 87);
            this.lBGehegeTier.Name = "lBGehegeTier";
            this.lBGehegeTier.Size = new System.Drawing.Size(180, 144);
            this.lBGehegeTier.TabIndex = 0;
            // 
            // cBTierGehege
            // 
            this.cBTierGehege.FormattingEnabled = true;
            this.cBTierGehege.Location = new System.Drawing.Point(59, 39);
            this.cBTierGehege.Name = "cBTierGehege";
            this.cBTierGehege.Size = new System.Drawing.Size(121, 22);
            this.cBTierGehege.TabIndex = 9;
            this.cBTierGehege.SelectedIndexChanged += new System.EventHandler(this.cBTierGehege_SelectedIndexChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 14);
            this.label17.TabIndex = 2;
            this.label17.Text = "Gehege";
            // 
            // btnZurück1
            // 
            this.btnZurück1.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZurück1.Location = new System.Drawing.Point(67, 420);
            this.btnZurück1.Name = "btnZurück1";
            this.btnZurück1.Size = new System.Drawing.Size(75, 23);
            this.btnZurück1.TabIndex = 7;
            this.btnZurück1.Text = "Zurück";
            this.btnZurück1.UseVisualStyleBackColor = true;
            this.btnZurück1.Click += new System.EventHandler(this.btnZurück1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGehegeList);
            this.groupBox2.Controls.Add(this.cBGehegeKontinent);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnUpdateGehege);
            this.groupBox2.Controls.Add(this.lBGehege);
            this.groupBox2.Controls.Add(this.btnLöschenGehege);
            this.groupBox2.Controls.Add(this.btnSaveGehege);
            this.groupBox2.Controls.Add(this.tBGehegeGroesse);
            this.groupBox2.Controls.Add(this.tBGehegeName);
            this.groupBox2.Controls.Add(this.tBGehegeID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 338);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gehege anlegen";
            // 
            // btnGehegeList
            // 
            this.btnGehegeList.Location = new System.Drawing.Point(55, 266);
            this.btnGehegeList.Name = "btnGehegeList";
            this.btnGehegeList.Size = new System.Drawing.Size(106, 23);
            this.btnGehegeList.TabIndex = 10;
            this.btnGehegeList.Text = "Gehege Liste";
            this.btnGehegeList.UseVisualStyleBackColor = true;
            this.btnGehegeList.Click += new System.EventHandler(this.btnGehegeList_Click);
            // 
            // cBGehegeKontinent
            // 
            this.cBGehegeKontinent.FormattingEnabled = true;
            this.cBGehegeKontinent.Location = new System.Drawing.Point(109, 127);
            this.cBGehegeKontinent.Name = "cBGehegeKontinent";
            this.cBGehegeKontinent.Size = new System.Drawing.Size(121, 22);
            this.cBGehegeKontinent.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 14);
            this.label14.TabIndex = 9;
            this.label14.Text = "Kontinent";
            // 
            // btnUpdateGehege
            // 
            this.btnUpdateGehege.Location = new System.Drawing.Point(74, 203);
            this.btnUpdateGehege.Name = "btnUpdateGehege";
            this.btnUpdateGehege.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGehege.TabIndex = 7;
            this.btnUpdateGehege.Text = "Update";
            this.btnUpdateGehege.UseVisualStyleBackColor = true;
            this.btnUpdateGehege.Click += new System.EventHandler(this.btnUpdateGehege_Click);
            // 
            // lBGehege
            // 
            this.lBGehege.FormattingEnabled = true;
            this.lBGehege.ItemHeight = 14;
            this.lBGehege.Location = new System.Drawing.Point(259, 12);
            this.lBGehege.Name = "lBGehege";
            this.lBGehege.Size = new System.Drawing.Size(146, 298);
            this.lBGehege.TabIndex = 0;
            this.lBGehege.SelectedIndexChanged += new System.EventHandler(this.lBGehege_SelectedIndexChanged);
            // 
            // btnLöschenGehege
            // 
            this.btnLöschenGehege.Location = new System.Drawing.Point(133, 170);
            this.btnLöschenGehege.Name = "btnLöschenGehege";
            this.btnLöschenGehege.Size = new System.Drawing.Size(75, 23);
            this.btnLöschenGehege.TabIndex = 6;
            this.btnLöschenGehege.Text = "Delete";
            this.btnLöschenGehege.UseVisualStyleBackColor = true;
            this.btnLöschenGehege.Click += new System.EventHandler(this.btnLöschenGehege_Click);
            // 
            // btnSaveGehege
            // 
            this.btnSaveGehege.Location = new System.Drawing.Point(14, 170);
            this.btnSaveGehege.Name = "btnSaveGehege";
            this.btnSaveGehege.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGehege.TabIndex = 5;
            this.btnSaveGehege.Text = "Save";
            this.btnSaveGehege.UseVisualStyleBackColor = true;
            this.btnSaveGehege.Click += new System.EventHandler(this.btnSaveGehege_Click);
            // 
            // tBGehegeGroesse
            // 
            this.tBGehegeGroesse.Location = new System.Drawing.Point(109, 93);
            this.tBGehegeGroesse.Name = "tBGehegeGroesse";
            this.tBGehegeGroesse.Size = new System.Drawing.Size(121, 23);
            this.tBGehegeGroesse.TabIndex = 3;
            // 
            // tBGehegeName
            // 
            this.tBGehegeName.Location = new System.Drawing.Point(109, 59);
            this.tBGehegeName.Name = "tBGehegeName";
            this.tBGehegeName.Size = new System.Drawing.Size(121, 23);
            this.tBGehegeName.TabIndex = 2;
            // 
            // tBGehegeID
            // 
            this.tBGehegeID.Location = new System.Drawing.Point(109, 27);
            this.tBGehegeID.Name = "tBGehegeID";
            this.tBGehegeID.Size = new System.Drawing.Size(121, 23);
            this.tBGehegeID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "Größe in qm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // Themen_und_Gehege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnZurück1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "Themen_und_Gehege";
            this.Text = "Themen_und_Gehege";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox5;
        private ComboBox cBThemenGehege;
        private ListBox lBThemenGehege;
        private Label label16;
        private GroupBox groupBox6;
        private ListBox lBGehegeTier;
        private ComboBox cBTierGehege;
        private Label label17;
        private Button btnZurück1;
        private GroupBox groupBox2;
        private ComboBox cBGehegeKontinent;
        private Label label14;
        private Button btnUpdateGehege;
        private ListBox lBGehege;
        private Button btnLöschenGehege;
        private Button btnSaveGehege;
        private TextBox tBGehegeGroesse;
        private TextBox tBGehegeName;
        private TextBox tBGehegeID;
        private Label label10;
        private Label label9;
        private Label label5;
        private Button btnGehegeList;
        private Button btnKontilist;
    }
}