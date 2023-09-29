namespace frmBusTerminalMenu
{
    partial class frmDetails
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
            this.lbl = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lvDest2 = new System.Windows.Forms.ListView();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(161, 42);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 19);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "TICKET DETAILS";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(94, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(244, 23);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "SOUTH MANILA BUS STATION";
            // 
            // lvDest2
            // 
            this.lvDest2.HideSelection = false;
            this.lvDest2.Location = new System.Drawing.Point(12, 75);
            this.lvDest2.Name = "lvDest2";
            this.lvDest2.Size = new System.Drawing.Size(410, 251);
            this.lvDest2.TabIndex = 8;
            this.lvDest2.UseCompatibleStateImageBehavior = false;
            this.lvDest2.View = System.Windows.Forms.View.List;
            this.lvDest2.SelectedIndexChanged += new System.EventHandler(this.lvDest2_SelectedIndexChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(175, 332);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(86, 28);
            this.btnContinue.TabIndex = 23;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 372);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lvDest2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmDetails";
            this.Text = "frmDetails";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListView lvDest2;
        private System.Windows.Forms.Button btnContinue;
    }
}