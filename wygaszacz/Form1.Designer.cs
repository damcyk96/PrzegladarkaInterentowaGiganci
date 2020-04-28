namespace wygaszacz
{
    partial class Przegladarka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.WsteczBtn = new System.Windows.Forms.Button();
            this.WprzodBtn = new System.Windows.Forms.Button();
            this.ZatrzymajBtn = new System.Windows.Forms.Button();
            this.OdswiezBtn = new System.Windows.Forms.Button();
            this.ulubioneBtn = new System.Windows.Forms.Button();
            this.ulubioneCmb = new System.Windows.Forms.ComboBox();
            this.IdzBtn = new System.Windows.Forms.Button();
            this.AdresTxt = new System.Windows.Forms.TextBox();
            this.okienkoBrw = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WsteczBtn
            // 
            this.WsteczBtn.Location = new System.Drawing.Point(12, 12);
            this.WsteczBtn.Name = "WsteczBtn";
            this.WsteczBtn.Size = new System.Drawing.Size(75, 23);
            this.WsteczBtn.TabIndex = 0;
            this.WsteczBtn.Text = "<";
            this.WsteczBtn.UseVisualStyleBackColor = true;
            this.WsteczBtn.Click += new System.EventHandler(this.WsteczBtn_Click);
            // 
            // WprzodBtn
            // 
            this.WprzodBtn.Location = new System.Drawing.Point(134, 12);
            this.WprzodBtn.Name = "WprzodBtn";
            this.WprzodBtn.Size = new System.Drawing.Size(75, 23);
            this.WprzodBtn.TabIndex = 1;
            this.WprzodBtn.Text = ">";
            this.WprzodBtn.UseVisualStyleBackColor = true;
            this.WprzodBtn.Click += new System.EventHandler(this.WprzodBtn_Click);
            // 
            // ZatrzymajBtn
            // 
            this.ZatrzymajBtn.Location = new System.Drawing.Point(287, 11);
            this.ZatrzymajBtn.Name = "ZatrzymajBtn";
            this.ZatrzymajBtn.Size = new System.Drawing.Size(75, 23);
            this.ZatrzymajBtn.TabIndex = 2;
            this.ZatrzymajBtn.Text = "Zatrzymaj";
            this.ZatrzymajBtn.UseVisualStyleBackColor = true;
            this.ZatrzymajBtn.Click += new System.EventHandler(this.ZatrzymajBtn_Click);
            // 
            // OdswiezBtn
            // 
            this.OdswiezBtn.Location = new System.Drawing.Point(423, 12);
            this.OdswiezBtn.Name = "OdswiezBtn";
            this.OdswiezBtn.Size = new System.Drawing.Size(75, 23);
            this.OdswiezBtn.TabIndex = 3;
            this.OdswiezBtn.Text = "Odswiez";
            this.OdswiezBtn.UseVisualStyleBackColor = true;
            this.OdswiezBtn.Click += new System.EventHandler(this.OdswiezBtn_Click);
            // 
            // ulubioneBtn
            // 
            this.ulubioneBtn.Location = new System.Drawing.Point(556, 12);
            this.ulubioneBtn.Name = "ulubioneBtn";
            this.ulubioneBtn.Size = new System.Drawing.Size(157, 23);
            this.ulubioneBtn.TabIndex = 4;
            this.ulubioneBtn.Text = "Dodaj do ulubionych";
            this.ulubioneBtn.UseVisualStyleBackColor = true;
            this.ulubioneBtn.Click += new System.EventHandler(this.ulubioneBtn_Click);
            // 
            // ulubioneCmb
            // 
            this.ulubioneCmb.FormattingEnabled = true;
            this.ulubioneCmb.Location = new System.Drawing.Point(742, 12);
            this.ulubioneCmb.Name = "ulubioneCmb";
            this.ulubioneCmb.Size = new System.Drawing.Size(194, 21);
            this.ulubioneCmb.TabIndex = 5;
            this.ulubioneCmb.SelectedIndexChanged += new System.EventHandler(this.ulubioneCmd_SelectedIndexChanged);
            // 
            // IdzBtn
            // 
            this.IdzBtn.Location = new System.Drawing.Point(1013, 12);
            this.IdzBtn.Name = "IdzBtn";
            this.IdzBtn.Size = new System.Drawing.Size(75, 23);
            this.IdzBtn.TabIndex = 6;
            this.IdzBtn.Text = "Idz";
            this.IdzBtn.UseVisualStyleBackColor = true;
            this.IdzBtn.Click += new System.EventHandler(this.IdzBtn_Click);
            // 
            // AdresTxt
            // 
            this.AdresTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdresTxt.Location = new System.Drawing.Point(3, 61);
            this.AdresTxt.Name = "AdresTxt";
            this.AdresTxt.Size = new System.Drawing.Size(1256, 20);
            this.AdresTxt.TabIndex = 7;
            // 
            // okienkoBrw
            // 
            this.okienkoBrw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okienkoBrw.Location = new System.Drawing.Point(3, 101);
            this.okienkoBrw.MinimumSize = new System.Drawing.Size(20, 20);
            this.okienkoBrw.Name = "okienkoBrw";
            this.okienkoBrw.Size = new System.Drawing.Size(1256, 465);
            this.okienkoBrw.TabIndex = 8;
            this.okienkoBrw.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.okienkoBrw_Navigated);
            // 
            // Przegladarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 578);
            this.Controls.Add(this.okienkoBrw);
            this.Controls.Add(this.AdresTxt);
            this.Controls.Add(this.IdzBtn);
            this.Controls.Add(this.ulubioneCmb);
            this.Controls.Add(this.ulubioneBtn);
            this.Controls.Add(this.OdswiezBtn);
            this.Controls.Add(this.ZatrzymajBtn);
            this.Controls.Add(this.WprzodBtn);
            this.Controls.Add(this.WsteczBtn);
            this.Name = "Przegladarka";
            this.Text = "Przegladarka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WsteczBtn;
        private System.Windows.Forms.Button WprzodBtn;
        private System.Windows.Forms.Button ZatrzymajBtn;
        private System.Windows.Forms.Button OdswiezBtn;
        private System.Windows.Forms.Button ulubioneBtn;
        private System.Windows.Forms.ComboBox ulubioneCmb;
        private System.Windows.Forms.Button IdzBtn;
        private System.Windows.Forms.TextBox AdresTxt;
        private System.Windows.Forms.WebBrowser okienkoBrw;
    }
}

