namespace frmBusTerminalMenu
{
    partial class frmWelcome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnFare = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblFare = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(67, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(332, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME TO MANILABAS JAM STATION";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(132, 84);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(204, 19);
            this.lblChoose.TabIndex = 1;
            this.lblChoose.Text = "Please select your transaction";
            // 
            // btnDestination
            // 
            this.btnDestination.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestination.Location = new System.Drawing.Point(54, 118);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(62, 28);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "[1]";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(54, 152);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(62, 28);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "[2]";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnFare
            // 
            this.btnFare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFare.Location = new System.Drawing.Point(54, 183);
            this.btnFare.Name = "btnFare";
            this.btnFare.Size = new System.Drawing.Size(62, 28);
            this.btnFare.TabIndex = 4;
            this.btnFare.Text = "[3]";
            this.btnFare.UseVisualStyleBackColor = true;
            this.btnFare.Click += new System.EventHandler(this.btnFare_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(54, 217);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(62, 28);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "[4]";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(132, 123);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(84, 19);
            this.lblDestination.TabIndex = 6;
            this.lblDestination.Text = "Destination";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(132, 154);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(74, 19);
            this.lblBook.TabIndex = 7;
            this.lblBook.Text = "Book Now";
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFare.Location = new System.Drawing.Point(132, 188);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(119, 19);
            this.lblFare.TabIndex = 8;
            this.lblFare.Text = "Passenger\'s Fare";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(132, 222);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(41, 19);
            this.lblView.TabIndex = 9;
            this.lblView.Text = "View";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(401, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 275);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.lblFare);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnFare);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnFare;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnExit;
    }
}

