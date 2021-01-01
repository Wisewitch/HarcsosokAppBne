namespace HarcsosokAppBne
{
    partial class Form_Harcosok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Harcosok));
            this.groupBox_ujharcos = new System.Windows.Forms.GroupBox();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.groupBox_kepesseg = new System.Windows.Forms.GroupBox();
            this.button_addkepesseg = new System.Windows.Forms.Button();
            this.textBox_kepesseg_leiras_add = new System.Windows.Forms.TextBox();
            this.textBox_kepesseg_nev_add = new System.Windows.Forms.TextBox();
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.label_leiras = new System.Windows.Forms.Label();
            this.label_hnev = new System.Windows.Forms.Label();
            this.label_haszn = new System.Windows.Forms.Label();
            this.groupBox_listak = new System.Windows.Forms.GroupBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_kepeseg_leiras_kiir = new System.Windows.Forms.TextBox();
            this.listBox_kepesseg = new System.Windows.Forms.ListBox();
            this.listBox_harcos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Harcosok = new System.Windows.Forms.Label();
            this.label_harcos_id = new System.Windows.Forms.Label();
            this.numericUpDown_harcosid = new System.Windows.Forms.NumericUpDown();
            this.groupBox_ujharcos.SuspendLayout();
            this.groupBox_kepesseg.SuspendLayout();
            this.groupBox_listak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_harcosid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_ujharcos
            // 
            this.groupBox_ujharcos.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_ujharcos.Controls.Add(this.button_create);
            this.groupBox_ujharcos.Controls.Add(this.textBox_nev);
            this.groupBox_ujharcos.Controls.Add(this.label_nev);
            this.groupBox_ujharcos.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ujharcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_ujharcos.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_ujharcos.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ujharcos.Name = "groupBox_ujharcos";
            this.groupBox_ujharcos.Size = new System.Drawing.Size(850, 77);
            this.groupBox_ujharcos.TabIndex = 0;
            this.groupBox_ujharcos.TabStop = false;
            this.groupBox_ujharcos.Text = "Harcos létrehozása";
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.Black;
            this.button_create.ForeColor = System.Drawing.SystemColors.Control;
            this.button_create.Location = new System.Drawing.Point(397, 32);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(138, 32);
            this.button_create.TabIndex = 2;
            this.button_create.Text = "Létrehozás";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(55, 34);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(320, 26);
            this.textBox_nev.TabIndex = 1;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nev.Location = new System.Drawing.Point(12, 37);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(33, 17);
            this.label_nev.TabIndex = 0;
            this.label_nev.Text = "Név";
            this.label_nev.Click += new System.EventHandler(this.label_nev_Click);
            // 
            // groupBox_kepesseg
            // 
            this.groupBox_kepesseg.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_kepesseg.Controls.Add(this.numericUpDown_harcosid);
            this.groupBox_kepesseg.Controls.Add(this.label_harcos_id);
            this.groupBox_kepesseg.Controls.Add(this.button_addkepesseg);
            this.groupBox_kepesseg.Controls.Add(this.textBox_kepesseg_leiras_add);
            this.groupBox_kepesseg.Controls.Add(this.textBox_kepesseg_nev_add);
            this.groupBox_kepesseg.Controls.Add(this.comboBox_user);
            this.groupBox_kepesseg.Controls.Add(this.label_leiras);
            this.groupBox_kepesseg.Controls.Add(this.label_hnev);
            this.groupBox_kepesseg.Controls.Add(this.label_haszn);
            this.groupBox_kepesseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_kepesseg.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_kepesseg.Location = new System.Drawing.Point(1, 83);
            this.groupBox_kepesseg.Name = "groupBox_kepesseg";
            this.groupBox_kepesseg.Size = new System.Drawing.Size(858, 178);
            this.groupBox_kepesseg.TabIndex = 1;
            this.groupBox_kepesseg.TabStop = false;
            this.groupBox_kepesseg.Text = "Képesség létrehozása";
            // 
            // button_addkepesseg
            // 
            this.button_addkepesseg.BackColor = System.Drawing.Color.Black;
            this.button_addkepesseg.Location = new System.Drawing.Point(24, 137);
            this.button_addkepesseg.Name = "button_addkepesseg";
            this.button_addkepesseg.Size = new System.Drawing.Size(193, 27);
            this.button_addkepesseg.TabIndex = 6;
            this.button_addkepesseg.Text = "Hozzáad";
            this.button_addkepesseg.UseVisualStyleBackColor = false;
            this.button_addkepesseg.Click += new System.EventHandler(this.button_addkepesseg_Click);
            // 
            // textBox_kepesseg_leiras_add
            // 
            this.textBox_kepesseg_leiras_add.Location = new System.Drawing.Point(366, 50);
            this.textBox_kepesseg_leiras_add.Multiline = true;
            this.textBox_kepesseg_leiras_add.Name = "textBox_kepesseg_leiras_add";
            this.textBox_kepesseg_leiras_add.Size = new System.Drawing.Size(446, 75);
            this.textBox_kepesseg_leiras_add.TabIndex = 5;
            // 
            // textBox_kepesseg_nev_add
            // 
            this.textBox_kepesseg_nev_add.Location = new System.Drawing.Point(79, 99);
            this.textBox_kepesseg_nev_add.Name = "textBox_kepesseg_nev_add";
            this.textBox_kepesseg_nev_add.Size = new System.Drawing.Size(212, 26);
            this.textBox_kepesseg_nev_add.TabIndex = 4;
            // 
            // comboBox_user
            // 
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Location = new System.Drawing.Point(79, 50);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(212, 28);
            this.comboBox_user.TabIndex = 3;
            this.comboBox_user.SelectedIndexChanged += new System.EventHandler(this.comboBox_user_SelectedIndexChanged);
            // 
            // label_leiras
            // 
            this.label_leiras.AutoSize = true;
            this.label_leiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_leiras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_leiras.Location = new System.Drawing.Point(366, 25);
            this.label_leiras.Name = "label_leiras";
            this.label_leiras.Size = new System.Drawing.Size(53, 17);
            this.label_leiras.TabIndex = 2;
            this.label_leiras.Text = "Leírás";
            // 
            // label_hnev
            // 
            this.label_hnev.AutoSize = true;
            this.label_hnev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_hnev.ForeColor = System.Drawing.SystemColors.Control;
            this.label_hnev.Location = new System.Drawing.Point(21, 99);
            this.label_hnev.Name = "label_hnev";
            this.label_hnev.Size = new System.Drawing.Size(33, 17);
            this.label_hnev.TabIndex = 1;
            this.label_hnev.Text = "Név";
            // 
            // label_haszn
            // 
            this.label_haszn.AutoSize = true;
            this.label_haszn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_haszn.ForeColor = System.Drawing.SystemColors.Control;
            this.label_haszn.Location = new System.Drawing.Point(14, 56);
            this.label_haszn.Name = "label_haszn";
            this.label_haszn.Size = new System.Drawing.Size(67, 17);
            this.label_haszn.TabIndex = 0;
            this.label_haszn.Text = "Használó";
            // 
            // groupBox_listak
            // 
            this.groupBox_listak.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_listak.Controls.Add(this.button_update);
            this.groupBox_listak.Controls.Add(this.button_delete);
            this.groupBox_listak.Controls.Add(this.textBox_kepeseg_leiras_kiir);
            this.groupBox_listak.Controls.Add(this.listBox_kepesseg);
            this.groupBox_listak.Controls.Add(this.listBox_harcos);
            this.groupBox_listak.Controls.Add(this.label3);
            this.groupBox_listak.Controls.Add(this.label2);
            this.groupBox_listak.Controls.Add(this.label_Harcosok);
            this.groupBox_listak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_listak.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_listak.Location = new System.Drawing.Point(0, 267);
            this.groupBox_listak.Name = "groupBox_listak";
            this.groupBox_listak.Size = new System.Drawing.Size(850, 299);
            this.groupBox_listak.TabIndex = 2;
            this.groupBox_listak.TabStop = false;
            this.groupBox_listak.Text = "A kiválasztott harcosok";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Black;
            this.button_update.Location = new System.Drawing.Point(676, 260);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(137, 27);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Módosítás";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(419, 260);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(137, 27);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_kepeseg_leiras_kiir
            // 
            this.textBox_kepeseg_leiras_kiir.Location = new System.Drawing.Point(419, 63);
            this.textBox_kepeseg_leiras_kiir.Multiline = true;
            this.textBox_kepeseg_leiras_kiir.Name = "textBox_kepeseg_leiras_kiir";
            this.textBox_kepeseg_leiras_kiir.Size = new System.Drawing.Size(416, 175);
            this.textBox_kepeseg_leiras_kiir.TabIndex = 7;
            // 
            // listBox_kepesseg
            // 
            this.listBox_kepesseg.FormattingEnabled = true;
            this.listBox_kepesseg.ItemHeight = 20;
            this.listBox_kepesseg.Location = new System.Drawing.Point(250, 63);
            this.listBox_kepesseg.Name = "listBox_kepesseg";
            this.listBox_kepesseg.Size = new System.Drawing.Size(151, 224);
            this.listBox_kepesseg.TabIndex = 4;
            this.listBox_kepesseg.SelectedIndexChanged += new System.EventHandler(this.listBox_kepesseg_SelectedIndexChanged);
            // 
            // listBox_harcos
            // 
            this.listBox_harcos.FormattingEnabled = true;
            this.listBox_harcos.ItemHeight = 20;
            this.listBox_harcos.Location = new System.Drawing.Point(10, 65);
            this.listBox_harcos.Name = "listBox_harcos";
            this.listBox_harcos.Size = new System.Drawing.Size(217, 224);
            this.listBox_harcos.TabIndex = 3;
            this.listBox_harcos.SelectedIndexChanged += new System.EventHandler(this.listBox_harcos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(669, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Képességek leírása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(247, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Képességei";
            // 
            // label_Harcosok
            // 
            this.label_Harcosok.AutoSize = true;
            this.label_Harcosok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Harcosok.ForeColor = System.Drawing.Color.Snow;
            this.label_Harcosok.Location = new System.Drawing.Point(14, 31);
            this.label_Harcosok.Name = "label_Harcosok";
            this.label_Harcosok.Size = new System.Drawing.Size(85, 20);
            this.label_Harcosok.TabIndex = 0;
            this.label_Harcosok.Text = "Harcosok";
            // 
            // label_harcos_id
            // 
            this.label_harcos_id.AutoSize = true;
            this.label_harcos_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_harcos_id.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_harcos_id.Location = new System.Drawing.Point(362, 141);
            this.label_harcos_id.Name = "label_harcos_id";
            this.label_harcos_id.Size = new System.Drawing.Size(85, 20);
            this.label_harcos_id.TabIndex = 7;
            this.label_harcos_id.Text = "Harcos id";
            // 
            // numericUpDown_harcosid
            // 
            this.numericUpDown_harcosid.Location = new System.Drawing.Point(453, 135);
            this.numericUpDown_harcosid.Name = "numericUpDown_harcosid";
            this.numericUpDown_harcosid.Size = new System.Drawing.Size(181, 26);
            this.numericUpDown_harcosid.TabIndex = 8;
            // 
            // Form_Harcosok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 568);
            this.Controls.Add(this.groupBox_listak);
            this.Controls.Add(this.groupBox_kepesseg);
            this.Controls.Add(this.groupBox_ujharcos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Harcosok";
            this.Text = "HarcosokApp BGA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_ujharcos.ResumeLayout(false);
            this.groupBox_ujharcos.PerformLayout();
            this.groupBox_kepesseg.ResumeLayout(false);
            this.groupBox_kepesseg.PerformLayout();
            this.groupBox_listak.ResumeLayout(false);
            this.groupBox_listak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_harcosid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ujharcos;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.GroupBox groupBox_kepesseg;
        private System.Windows.Forms.Button button_addkepesseg;
        private System.Windows.Forms.TextBox textBox_kepesseg_leiras_add;
        private System.Windows.Forms.TextBox textBox_kepesseg_nev_add;
        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.Label label_leiras;
        private System.Windows.Forms.Label label_hnev;
        private System.Windows.Forms.Label label_haszn;
        private System.Windows.Forms.GroupBox groupBox_listak;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_kepeseg_leiras_kiir;
        private System.Windows.Forms.ListBox listBox_kepesseg;
        private System.Windows.Forms.ListBox listBox_harcos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Harcosok;
        private System.Windows.Forms.NumericUpDown numericUpDown_harcosid;
        private System.Windows.Forms.Label label_harcos_id;
    }
}

