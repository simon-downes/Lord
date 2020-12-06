
namespace UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.cpbHitPoints = new ColorProgressBar.ColorProgressBar();
            this.lblXP = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblMaxHitPoints = new System.Windows.Forms.Label();
            this.cmbWeapon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerDescription = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.lblLocationDesc = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.imgLocation = new System.Windows.Forms.PictureBox();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.pnlPlayer, 0, 0);
            this.tlpMain.Controls.Add(this.txtMessages, 2, 0);
            this.tlpMain.Controls.Add(this.pnlLocation, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1252, 675);
            this.tlpMain.TabIndex = 1;
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer.Controls.Add(this.cpbHitPoints);
            this.pnlPlayer.Controls.Add(this.lblXP);
            this.pnlPlayer.Controls.Add(this.lblGold);
            this.pnlPlayer.Controls.Add(this.lblMaxHitPoints);
            this.pnlPlayer.Controls.Add(this.cmbWeapon);
            this.pnlPlayer.Controls.Add(this.label4);
            this.pnlPlayer.Controls.Add(this.label3);
            this.pnlPlayer.Controls.Add(this.label2);
            this.pnlPlayer.Controls.Add(this.label1);
            this.pnlPlayer.Controls.Add(this.lblPlayerDescription);
            this.pnlPlayer.Controls.Add(this.lblPlayerName);
            this.pnlPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayer.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(274, 669);
            this.pnlPlayer.TabIndex = 4;
            // 
            // cpbHitPoints
            // 
            this.cpbHitPoints.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cpbHitPoints.BorderColor = System.Drawing.Color.Black;
            this.cpbHitPoints.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.cpbHitPoints.Location = new System.Drawing.Point(92, 68);
            this.cpbHitPoints.Maximum = 10;
            this.cpbHitPoints.Minimum = 0;
            this.cpbHitPoints.Name = "cpbHitPoints";
            this.cpbHitPoints.Size = new System.Drawing.Size(159, 23);
            this.cpbHitPoints.Step = 1;
            this.cpbHitPoints.TabIndex = 21;
            this.cpbHitPoints.Value = 6;
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(89, 146);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(55, 13);
            this.lblXP.TabIndex = 19;
            this.lblXP.Text = "1,000,000";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(89, 116);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(34, 13);
            this.lblGold.TabIndex = 18;
            this.lblGold.Text = "1,000";
            // 
            // lblMaxHitPoints
            // 
            this.lblMaxHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxHitPoints.AutoSize = true;
            this.lblMaxHitPoints.Location = new System.Drawing.Point(217, 94);
            this.lblMaxHitPoints.Name = "lblMaxHitPoints";
            this.lblMaxHitPoints.Size = new System.Drawing.Size(34, 13);
            this.lblMaxHitPoints.TabIndex = 17;
            this.lblMaxHitPoints.Text = "1,000";
            this.lblMaxHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbWeapon
            // 
            this.cmbWeapon.FormattingEnabled = true;
            this.cmbWeapon.Location = new System.Drawing.Point(92, 174);
            this.cmbWeapon.Name = "cmbWeapon";
            this.cmbWeapon.Size = new System.Drawing.Size(159, 21);
            this.cmbWeapon.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Weapon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "XP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gold:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hit Points:";
            // 
            // lblPlayerDescription
            // 
            this.lblPlayerDescription.AutoSize = true;
            this.lblPlayerDescription.Location = new System.Drawing.Point(20, 45);
            this.lblPlayerDescription.Name = "lblPlayerDescription";
            this.lblPlayerDescription.Size = new System.Drawing.Size(164, 13);
            this.lblPlayerDescription.TabIndex = 11;
            this.lblPlayerDescription.Text = "Level 1 Warrior (Mostly Harmless)";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(20, 19);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(59, 13);
            this.lblPlayerName.TabIndex = 10;
            this.lblPlayerName.Text = "Adventurer";
            // 
            // txtMessages
            // 
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(733, 3);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(516, 669);
            this.txtMessages.TabIndex = 5;
            this.txtMessages.Text = "";
            // 
            // pnlLocation
            // 
            this.pnlLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLocation.Controls.Add(this.btnExplore);
            this.pnlLocation.Controls.Add(this.btnSouth);
            this.pnlLocation.Controls.Add(this.btnEast);
            this.pnlLocation.Controls.Add(this.btnWest);
            this.pnlLocation.Controls.Add(this.btnNorth);
            this.pnlLocation.Controls.Add(this.lblLocationDesc);
            this.pnlLocation.Controls.Add(this.lblLocationName);
            this.pnlLocation.Controls.Add(this.imgLocation);
            this.pnlLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLocation.Location = new System.Drawing.Point(280, 3);
            this.pnlLocation.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(450, 669);
            this.pnlLocation.TabIndex = 6;
            // 
            // lblLocationDesc
            // 
            this.lblLocationDesc.AutoSize = true;
            this.lblLocationDesc.Location = new System.Drawing.Point(5, 399);
            this.lblLocationDesc.Name = "lblLocationDesc";
            this.lblLocationDesc.Size = new System.Drawing.Size(73, 13);
            this.lblLocationDesc.TabIndex = 3;
            this.lblLocationDesc.Text = "LocationDesc";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(4, 370);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(112, 20);
            this.lblLocationName.TabIndex = 2;
            this.lblLocationName.Text = "LocationName";
            // 
            // imgLocation
            // 
            this.imgLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLocation.Image = ((System.Drawing.Image)(resources.GetObject("imgLocation.Image")));
            this.imgLocation.Location = new System.Drawing.Point(0, 0);
            this.imgLocation.Name = "imgLocation";
            this.imgLocation.Size = new System.Drawing.Size(446, 363);
            this.imgLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLocation.TabIndex = 0;
            this.imgLocation.TabStop = false;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(173, 432);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 4;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(92, 461);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 5;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(254, 461);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 6;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(173, 490);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 7;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(173, 461);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 23);
            this.btnExplore.TabIndex = 8;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 675);
            this.Controls.Add(this.tlpMain);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Legend of the Ruby Dragon";
            this.tlpMain.ResumeLayout(false);
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblMaxHitPoints;
        private System.Windows.Forms.ComboBox cmbWeapon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerDescription;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.PictureBox imgLocation;
        private ColorProgressBar.ColorProgressBar cpbHitPoints;
        private System.Windows.Forms.Label lblLocationDesc;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnNorth;
    }
}

