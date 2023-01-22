namespace Snap.UI
{
    partial class Snap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCommonPile = new System.Windows.Forms.GroupBox();
            this.lblCommonCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPlayer1Count = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPlayer2Count = new System.Windows.Forms.Label();
            this.pbCurrentCard = new System.Windows.Forms.PictureBox();
            this.pbPrevCard = new System.Windows.Forms.PictureBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblCurrentCard = new System.Windows.Forms.Label();
            this.lblPreviousCard = new System.Windows.Forms.Label();
            this.grpCrrentRun = new System.Windows.Forms.GroupBox();
            this.lblCurrentRun = new System.Windows.Forms.Label();
            this.btnAutoDeal = new System.Windows.Forms.Button();
            this.btnSuffle = new System.Windows.Forms.Button();
            this.grpCommonPile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevCard)).BeginInit();
            this.grpCrrentRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCommonPile
            // 
            this.grpCommonPile.Controls.Add(this.lblCommonCount);
            this.grpCommonPile.Location = new System.Drawing.Point(64, 26);
            this.grpCommonPile.Name = "grpCommonPile";
            this.grpCommonPile.Size = new System.Drawing.Size(100, 90);
            this.grpCommonPile.TabIndex = 0;
            this.grpCommonPile.TabStop = false;
            this.grpCommonPile.Text = "Common Pile";
            // 
            // lblCommonCount
            // 
            this.lblCommonCount.AutoSize = true;
            this.lblCommonCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCommonCount.Location = new System.Drawing.Point(18, 36);
            this.lblCommonCount.Name = "lblCommonCount";
            this.lblCommonCount.Size = new System.Drawing.Size(65, 37);
            this.lblCommonCount.TabIndex = 2;
            this.lblCommonCount.Text = "000";
            this.lblCommonCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPlayer1Count);
            this.groupBox2.Location = new System.Drawing.Point(186, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 1";
            // 
            // lblPlayer1Count
            // 
            this.lblPlayer1Count.AutoSize = true;
            this.lblPlayer1Count.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Count.Location = new System.Drawing.Point(18, 36);
            this.lblPlayer1Count.Name = "lblPlayer1Count";
            this.lblPlayer1Count.Size = new System.Drawing.Size(65, 37);
            this.lblPlayer1Count.TabIndex = 3;
            this.lblPlayer1Count.Text = "000";
            this.lblPlayer1Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPlayer2Count);
            this.groupBox3.Location = new System.Drawing.Point(301, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 90);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player 2";
            // 
            // lblPlayer2Count
            // 
            this.lblPlayer2Count.AutoSize = true;
            this.lblPlayer2Count.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Count.Location = new System.Drawing.Point(18, 36);
            this.lblPlayer2Count.Name = "lblPlayer2Count";
            this.lblPlayer2Count.Size = new System.Drawing.Size(65, 37);
            this.lblPlayer2Count.TabIndex = 3;
            this.lblPlayer2Count.Text = "000";
            // 
            // pbCurrentCard
            // 
            this.pbCurrentCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCurrentCard.Location = new System.Drawing.Point(64, 186);
            this.pbCurrentCard.Name = "pbCurrentCard";
            this.pbCurrentCard.Size = new System.Drawing.Size(79, 96);
            this.pbCurrentCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentCard.TabIndex = 2;
            this.pbCurrentCard.TabStop = false;
            // 
            // pbPrevCard
            // 
            this.pbPrevCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPrevCard.Location = new System.Drawing.Point(186, 186);
            this.pbPrevCard.Name = "pbPrevCard";
            this.pbPrevCard.Size = new System.Drawing.Size(80, 96);
            this.pbPrevCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevCard.TabIndex = 3;
            this.pbPrevCard.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(186, 304);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(100, 23);
            this.btnDeal.TabIndex = 4;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblCurrentCard
            // 
            this.lblCurrentCard.AutoSize = true;
            this.lblCurrentCard.Location = new System.Drawing.Point(64, 160);
            this.lblCurrentCard.Name = "lblCurrentCard";
            this.lblCurrentCard.Size = new System.Drawing.Size(75, 15);
            this.lblCurrentCard.TabIndex = 5;
            this.lblCurrentCard.Text = "Current Card";
            // 
            // lblPreviousCard
            // 
            this.lblPreviousCard.AutoSize = true;
            this.lblPreviousCard.Location = new System.Drawing.Point(186, 160);
            this.lblPreviousCard.Name = "lblPreviousCard";
            this.lblPreviousCard.Size = new System.Drawing.Size(80, 15);
            this.lblPreviousCard.TabIndex = 6;
            this.lblPreviousCard.Text = "Previous Card";
            // 
            // grpCrrentRun
            // 
            this.grpCrrentRun.Controls.Add(this.lblCurrentRun);
            this.grpCrrentRun.Location = new System.Drawing.Point(301, 186);
            this.grpCrrentRun.Name = "grpCrrentRun";
            this.grpCrrentRun.Size = new System.Drawing.Size(100, 90);
            this.grpCrrentRun.TabIndex = 3;
            this.grpCrrentRun.TabStop = false;
            this.grpCrrentRun.Text = "Current Run";
            // 
            // lblCurrentRun
            // 
            this.lblCurrentRun.AutoSize = true;
            this.lblCurrentRun.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentRun.Location = new System.Drawing.Point(18, 36);
            this.lblCurrentRun.Name = "lblCurrentRun";
            this.lblCurrentRun.Size = new System.Drawing.Size(65, 37);
            this.lblCurrentRun.TabIndex = 2;
            this.lblCurrentRun.Text = "000";
            this.lblCurrentRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutoDeal
            // 
            this.btnAutoDeal.Location = new System.Drawing.Point(301, 304);
            this.btnAutoDeal.Name = "btnAutoDeal";
            this.btnAutoDeal.Size = new System.Drawing.Size(100, 23);
            this.btnAutoDeal.TabIndex = 7;
            this.btnAutoDeal.Text = "Auto Deal";
            this.btnAutoDeal.UseVisualStyleBackColor = true;
            this.btnAutoDeal.Click += new System.EventHandler(this.btnAutoDeal_Click);
            // 
            // btnSuffle
            // 
            this.btnSuffle.Location = new System.Drawing.Point(64, 304);
            this.btnSuffle.Name = "btnSuffle";
            this.btnSuffle.Size = new System.Drawing.Size(100, 23);
            this.btnSuffle.TabIndex = 8;
            this.btnSuffle.Text = "Suffle";
            this.btnSuffle.UseVisualStyleBackColor = true;
            this.btnSuffle.Click += new System.EventHandler(this.btnSuffle_Click);
            // 
            // Snap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 364);
            this.Controls.Add(this.btnSuffle);
            this.Controls.Add(this.btnAutoDeal);
            this.Controls.Add(this.grpCrrentRun);
            this.Controls.Add(this.lblPreviousCard);
            this.Controls.Add(this.lblCurrentCard);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.pbPrevCard);
            this.Controls.Add(this.pbCurrentCard);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpCommonPile);
            this.Name = "Snap";
            this.Text = "Snap Game";
            this.grpCommonPile.ResumeLayout(false);
            this.grpCommonPile.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevCard)).EndInit();
            this.grpCrrentRun.ResumeLayout(false);
            this.grpCrrentRun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpCommonPile;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pbCurrentCard;
        private Label lblCommonCount;        
        private Label lblPlayer1Count;
        private Label lblPlayer2Count;
        private PictureBox pbPrevCard;
        private Button btnDeal;
        private Label lblCurrentCard;
        private Label lblPreviousCard;
        private GroupBox grpCrrentRun;
        private Label lblCurrentRun;        
        private Button btnAutoDeal;
        private Button btnSuffle;
    }
}