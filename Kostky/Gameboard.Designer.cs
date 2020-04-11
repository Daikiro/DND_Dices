namespace Kostky
{
    partial class Gameboard
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttkperc = new System.Windows.Forms.Button();
            this.buttk20 = new System.Windows.Forms.Button();
            this.buttk12 = new System.Windows.Forms.Button();
            this.buttk10 = new System.Windows.Forms.Button();
            this.buttk8 = new System.Windows.Forms.Button();
            this.buttk6 = new System.Windows.Forms.Button();
            this.buttk4 = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttkperc
            // 
            this.buttkperc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttkperc.Image = global::Kostky.Properties.Resources.kperc;
            this.buttkperc.Location = new System.Drawing.Point(375, 375);
            this.buttkperc.MaximumSize = new System.Drawing.Size(150, 150);
            this.buttkperc.MinimumSize = new System.Drawing.Size(150, 150);
            this.buttkperc.Name = "buttkperc";
            this.buttkperc.Size = new System.Drawing.Size(150, 150);
            this.buttkperc.TabIndex = 6;
            this.buttkperc.UseVisualStyleBackColor = true;
            this.buttkperc.Click += new System.EventHandler(this.buttkperc_Click);
            // 
            // buttk20
            // 
            this.buttk20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttk20.Image = global::Kostky.Properties.Resources.k20;
            this.buttk20.Location = new System.Drawing.Point(375, 200);
            this.buttk20.MaximumSize = new System.Drawing.Size(150, 150);
            this.buttk20.MinimumSize = new System.Drawing.Size(150, 150);
            this.buttk20.Name = "buttk20";
            this.buttk20.Size = new System.Drawing.Size(150, 150);
            this.buttk20.TabIndex = 5;
            this.buttk20.UseVisualStyleBackColor = true;
            this.buttk20.Click += new System.EventHandler(this.buttk20_Click);
            // 
            // buttk12
            // 
            this.buttk12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttk12.Image = global::Kostky.Properties.Resources.k12;
            this.buttk12.Location = new System.Drawing.Point(25, 375);
            this.buttk12.MaximumSize = new System.Drawing.Size(150, 150);
            this.buttk12.MinimumSize = new System.Drawing.Size(150, 150);
            this.buttk12.Name = "buttk12";
            this.buttk12.Size = new System.Drawing.Size(150, 150);
            this.buttk12.TabIndex = 4;
            this.buttk12.UseVisualStyleBackColor = true;
            this.buttk12.Click += new System.EventHandler(this.buttk12_Click);
            // 
            // buttk10
            // 
            this.buttk10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttk10.Image = global::Kostky.Properties.Resources.k10;
            this.buttk10.Location = new System.Drawing.Point(25, 200);
            this.buttk10.MaximumSize = new System.Drawing.Size(150, 150);
            this.buttk10.MinimumSize = new System.Drawing.Size(150, 150);
            this.buttk10.Name = "buttk10";
            this.buttk10.Size = new System.Drawing.Size(150, 150);
            this.buttk10.TabIndex = 3;
            this.buttk10.UseVisualStyleBackColor = true;
            this.buttk10.Click += new System.EventHandler(this.buttk10_Click);
            // 
            // buttk8
            // 
            this.buttk8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttk8.Image = global::Kostky.Properties.Resources.k8;
            this.buttk8.Location = new System.Drawing.Point(375, 25);
            this.buttk8.MaximumSize = new System.Drawing.Size(150, 150);
            this.buttk8.MinimumSize = new System.Drawing.Size(150, 150);
            this.buttk8.Name = "buttk8";
            this.buttk8.Size = new System.Drawing.Size(150, 150);
            this.buttk8.TabIndex = 2;
            this.buttk8.UseVisualStyleBackColor = true;
            this.buttk8.Click += new System.EventHandler(this.buttk8_Click);
            // 
            // buttk6
            // 
            this.buttk6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttk6.Image = global::Kostky.Properties.Resources.k6;
            this.buttk6.Location = new System.Drawing.Point(200, 25);
            this.buttk6.MaximumSize = new System.Drawing.Size(150, 150);
            this.buttk6.MinimumSize = new System.Drawing.Size(150, 150);
            this.buttk6.Name = "buttk6";
            this.buttk6.Size = new System.Drawing.Size(150, 150);
            this.buttk6.TabIndex = 1;
            this.buttk6.UseVisualStyleBackColor = true;
            this.buttk6.Click += new System.EventHandler(this.buttk6_Click);
            // 
            // buttk4
            // 
            this.buttk4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttk4.Image = global::Kostky.Properties.Resources.k41;
            this.buttk4.Location = new System.Drawing.Point(25, 25);
            this.buttk4.MaximumSize = new System.Drawing.Size(150, 150);
            this.buttk4.Name = "buttk4";
            this.buttk4.Size = new System.Drawing.Size(150, 150);
            this.buttk4.TabIndex = 0;
            this.buttk4.UseVisualStyleBackColor = true;
            this.buttk4.Click += new System.EventHandler(this.buttk4_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumber.Location = new System.Drawing.Point(246, 224);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 91);
            this.lblNumber.TabIndex = 7;
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDice.Location = new System.Drawing.Point(181, 406);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(122, 31);
            this.lblDice.TabIndex = 8;
            this.lblDice.Text = "THROW";
            this.lblDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gameboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 549);
            this.Controls.Add(this.lblDice);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.buttkperc);
            this.Controls.Add(this.buttk20);
            this.Controls.Add(this.buttk12);
            this.Controls.Add(this.buttk10);
            this.Controls.Add(this.buttk8);
            this.Controls.Add(this.buttk6);
            this.Controls.Add(this.buttk4);
            this.Name = "Gameboard";
            this.Text = "Gameboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttk4;
        private System.Windows.Forms.Button buttk6;
        private System.Windows.Forms.Button buttk8;
        private System.Windows.Forms.Button buttk10;
        private System.Windows.Forms.Button buttk12;
        private System.Windows.Forms.Button buttk20;
        private System.Windows.Forms.Button buttkperc;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDice;
    }
}

