namespace mysqlbaglanti
{
    partial class kayitfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.aditxt = new System.Windows.Forms.TextBox();
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.durumlbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listelebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // aditxt
            // 
            this.aditxt.Location = new System.Drawing.Point(69, 18);
            this.aditxt.Name = "aditxt";
            this.aditxt.Size = new System.Drawing.Size(149, 20);
            this.aditxt.TabIndex = 1;
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(69, 44);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(149, 20);
            this.epostatxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eposta";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(242, 16);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 4;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // durumlbl
            // 
            this.durumlbl.AutoSize = true;
            this.durumlbl.Location = new System.Drawing.Point(239, 47);
            this.durumlbl.Name = "durumlbl";
            this.durumlbl.Size = new System.Drawing.Size(0, 13);
            this.durumlbl.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(318, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(12, 87);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(75, 23);
            this.listelebtn.TabIndex = 7;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(93, 87);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(75, 23);
            this.silbtn.TabIndex = 8;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(174, 87);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(75, 23);
            this.guncellebtn.TabIndex = 9;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(255, 87);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(75, 23);
            this.temizlebtn.TabIndex = 10;
            this.temizlebtn.Text = "Temizle";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.temizlebtn_Click);
            // 
            // kayitfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 278);
            this.Controls.Add(this.temizlebtn);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.durumlbl);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.epostatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aditxt);
            this.Controls.Add(this.label1);
            this.Name = "kayitfrm";
            this.Text = "Kayıt Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aditxt;
        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Label durumlbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button temizlebtn;
    }
}

