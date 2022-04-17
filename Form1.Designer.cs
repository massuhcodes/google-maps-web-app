namespace GoogleMapsWebApp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_lon = new System.Windows.Forms.TextBox();
            this.txt_lat = new System.Windows.Forms.TextBox();
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.lbl_lon = new System.Windows.Forms.Label();
            this.lbl_lat = new System.Windows.Forms.Label();
            this.lbl_zip = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_find);
            this.splitContainer1.Panel1.Controls.Add(this.txt_lon);
            this.splitContainer1.Panel1.Controls.Add(this.txt_lat);
            this.splitContainer1.Panel1.Controls.Add(this.txt_zip);
            this.splitContainer1.Panel1.Controls.Add(this.txt_state);
            this.splitContainer1.Panel1.Controls.Add(this.txt_city);
            this.splitContainer1.Panel1.Controls.Add(this.txt_street);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_lon);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_lat);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_zip);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_state);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_city);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_street);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_title);
           
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 625);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btn_find.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.Location = new System.Drawing.Point(64, 517);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(234, 71);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "FIND PLACE";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_lon
            // 
            this.txt_lon.Location = new System.Drawing.Point(64, 442);
            this.txt_lon.Name = "txt_lon";
            this.txt_lon.Size = new System.Drawing.Size(234, 26);
            this.txt_lon.TabIndex = 7;
            // 
            // txt_lat
            // 
            this.txt_lat.Location = new System.Drawing.Point(64, 376);
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.Size = new System.Drawing.Size(234, 26);
            this.txt_lat.TabIndex = 6;
            // 
            // txt_zip
            // 
            this.txt_zip.Location = new System.Drawing.Point(64, 310);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.Size = new System.Drawing.Size(234, 26);
            this.txt_zip.TabIndex = 5;
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(64, 244);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(234, 26);
            this.txt_state.TabIndex = 4;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(64, 178);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(234, 26);
            this.txt_city.TabIndex = 3;
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(64, 112);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(234, 26);
            this.txt_street.TabIndex = 1;
            // 
            // lbl_lon
            // 
            this.lbl_lon.AutoSize = true;
            this.lbl_lon.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.lbl_lon.Location = new System.Drawing.Point(60, 412);
            this.lbl_lon.Name = "lbl_lon";
            this.lbl_lon.Size = new System.Drawing.Size(124, 20);
            this.lbl_lon.TabIndex = 2;
            this.lbl_lon.Text = "LONGITUDE";
         
            // 
            // lbl_lat
            // 
            this.lbl_lat.AutoSize = true;
            this.lbl_lat.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.lbl_lat.Location = new System.Drawing.Point(60, 346);
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(107, 20);
            this.lbl_lat.TabIndex = 2;
            this.lbl_lat.Text = "LATITUDE";
            
            // 
            // lbl_zip
            // 
            this.lbl_zip.AutoSize = true;
            this.lbl_zip.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.lbl_zip.Location = new System.Drawing.Point(60, 280);
            this.lbl_zip.Name = "lbl_zip";
            this.lbl_zip.Size = new System.Drawing.Size(40, 20);
            this.lbl_zip.TabIndex = 2;
            this.lbl_zip.Text = "ZIP";
           
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.lbl_state.Location = new System.Drawing.Point(60, 214);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(74, 20);
            this.lbl_state.TabIndex = 2;
            this.lbl_state.Text = "STATE";
           
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.lbl_city.Location = new System.Drawing.Point(60, 148);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(55, 20);
            this.lbl_city.TabIndex = 2;
            this.lbl_city.Text = "CITY";
        
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.lbl_street.Location = new System.Drawing.Point(60, 82);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(86, 20);
            this.lbl_street.TabIndex = 2;
            this.lbl_street.Text = "STREET";
        
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.lbl_title.Location = new System.Drawing.Point(53, 37);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(239, 33);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "PLACE FINDER";
            
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(705, 625);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1067, 625);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLACE FINDER";
          
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lbl_lon;
        private System.Windows.Forms.Label lbl_lat;
        private System.Windows.Forms.Label lbl_zip;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txt_lon;
        private System.Windows.Forms.TextBox txt_lat;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.Button btn_find;
    }
}

