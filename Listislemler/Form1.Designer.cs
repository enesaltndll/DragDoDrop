namespace Listislemler
{
    partial class FrmAnaEkran
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
            this.txtgiris = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.lstillerA = new System.Windows.Forms.ListBox();
            this.btngöster = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnaktar = new System.Windows.Forms.Button();
            this.btngerial = new System.Windows.Forms.Button();
            this.listiilerB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtgiris
            // 
            this.txtgiris.Location = new System.Drawing.Point(103, 46);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.Size = new System.Drawing.Size(100, 20);
            this.txtgiris.TabIndex = 0;
            this.txtgiris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgiris_KeyDown);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(209, 41);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 29);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lstillerA
            // 
            this.lstillerA.AllowDrop = true;
            this.lstillerA.FormattingEnabled = true;
            this.lstillerA.Location = new System.Drawing.Point(117, 81);
            this.lstillerA.Name = "lstillerA";
            this.lstillerA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstillerA.Size = new System.Drawing.Size(157, 186);
            this.lstillerA.TabIndex = 2;
            this.lstillerA.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstillerA_DragDrop);
            this.lstillerA.DragOver += new System.Windows.Forms.DragEventHandler(this.lstillerA_DragOver);
            this.lstillerA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstillerA_MouseDown);
            // 
            // btngöster
            // 
            this.btngöster.Location = new System.Drawing.Point(103, 288);
            this.btngöster.Name = "btngöster";
            this.btngöster.Size = new System.Drawing.Size(75, 38);
            this.btngöster.TabIndex = 3;
            this.btngöster.Text = "Seçilileri Göster";
            this.btngöster.UseVisualStyleBackColor = true;
            this.btngöster.Click += new System.EventHandler(this.btngöster_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(209, 288);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 38);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Seçilileri Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnaktar
            // 
            this.btnaktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaktar.Location = new System.Drawing.Point(312, 132);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(75, 23);
            this.btnaktar.TabIndex = 5;
            this.btnaktar.Text = ">>";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // btngerial
            // 
            this.btngerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngerial.Location = new System.Drawing.Point(312, 187);
            this.btngerial.Name = "btngerial";
            this.btngerial.Size = new System.Drawing.Size(75, 23);
            this.btngerial.TabIndex = 6;
            this.btngerial.Text = "<<";
            this.btngerial.UseVisualStyleBackColor = true;
            this.btngerial.Click += new System.EventHandler(this.btngerial_Click);
            // 
            // listiilerB
            // 
            this.listiilerB.AllowDrop = true;
            this.listiilerB.FormattingEnabled = true;
            this.listiilerB.Location = new System.Drawing.Point(420, 81);
            this.listiilerB.Name = "listiilerB";
            this.listiilerB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listiilerB.Size = new System.Drawing.Size(157, 186);
            this.listiilerB.TabIndex = 7;
            this.listiilerB.DragDrop += new System.Windows.Forms.DragEventHandler(this.listiilerB_DragDrop);
            this.listiilerB.DragOver += new System.Windows.Forms.DragEventHandler(this.listiilerB_DragOver);
            this.listiilerB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listiilerB_MouseDown);
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.listiilerB);
            this.Controls.Add(this.btngerial);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngöster);
            this.Controls.Add(this.lstillerA);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtgiris);
            this.Name = "FrmAnaEkran";
            this.Text = "Drag and Drop";
            this.Load += new System.EventHandler(this.FrmAnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgiris;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ListBox lstillerA;
        private System.Windows.Forms.Button btngöster;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnaktar;
        private System.Windows.Forms.Button btngerial;
        private System.Windows.Forms.ListBox listiilerB;
    }
}

