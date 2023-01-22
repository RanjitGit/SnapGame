namespace Snap.UI
{
    partial class Input
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
            this.rdbBoth = new System.Windows.Forms.RadioButton();
            this.rdbSuit = new System.Windows.Forms.RadioButton();
            this.rdbFaceValue = new System.Windows.Forms.RadioButton();
            this.lblMatchingCondition = new System.Windows.Forms.Label();
            this.txtNoOfDecks = new System.Windows.Forms.TextBox();
            this.lblNoOfDeks = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbBoth
            // 
            this.rdbBoth.AutoSize = true;
            this.rdbBoth.Location = new System.Drawing.Point(66, 127);
            this.rdbBoth.Name = "rdbBoth";
            this.rdbBoth.Size = new System.Drawing.Size(50, 19);
            this.rdbBoth.TabIndex = 11;
            this.rdbBoth.TabStop = true;
            this.rdbBoth.Text = "Both";
            this.rdbBoth.UseVisualStyleBackColor = true;
            this.rdbBoth.CheckedChanged += new System.EventHandler(this.rdbBoth_CheckedChanged);
            // 
            // rdbSuit
            // 
            this.rdbSuit.AutoSize = true;
            this.rdbSuit.Location = new System.Drawing.Point(66, 102);
            this.rdbSuit.Name = "rdbSuit";
            this.rdbSuit.Size = new System.Drawing.Size(127, 19);
            this.rdbSuit.TabIndex = 10;
            this.rdbSuit.TabStop = true;
            this.rdbSuit.Text = "The Suit of the card";
            this.rdbSuit.UseVisualStyleBackColor = true;
            this.rdbSuit.CheckedChanged += new System.EventHandler(this.rdbSuit_CheckedChanged);
            // 
            // rdbFaceValue
            // 
            this.rdbFaceValue.AutoSize = true;
            this.rdbFaceValue.Location = new System.Drawing.Point(66, 77);
            this.rdbFaceValue.Name = "rdbFaceValue";
            this.rdbFaceValue.Size = new System.Drawing.Size(140, 19);
            this.rdbFaceValue.TabIndex = 9;
            this.rdbFaceValue.TabStop = true;
            this.rdbFaceValue.Text = "Face value of the card";
            this.rdbFaceValue.UseVisualStyleBackColor = true;
            this.rdbFaceValue.CheckedChanged += new System.EventHandler(this.rdbFaceValue_CheckedChanged);
            // 
            // lblMatchingCondition
            // 
            this.lblMatchingCondition.AutoSize = true;
            this.lblMatchingCondition.Location = new System.Drawing.Point(25, 55);
            this.lblMatchingCondition.Name = "lblMatchingCondition";
            this.lblMatchingCondition.Size = new System.Drawing.Size(253, 15);
            this.lblMatchingCondition.TabIndex = 8;
            this.lblMatchingCondition.Text = "Which of the three matching conditions to use";
            // 
            // txtNoOfDecks
            // 
            this.txtNoOfDecks.Location = new System.Drawing.Point(238, 13);
            this.txtNoOfDecks.MaxLength = 100;
            this.txtNoOfDecks.Name = "txtNoOfDecks";
            this.txtNoOfDecks.Size = new System.Drawing.Size(43, 23);
            this.txtNoOfDecks.TabIndex = 7;
            this.txtNoOfDecks.TextChanged += new System.EventHandler(this.txtNoOfDecks_TextChanged);
            // 
            // lblNoOfDeks
            // 
            this.lblNoOfDeks.AutoSize = true;
            this.lblNoOfDeks.Location = new System.Drawing.Point(25, 21);
            this.lblNoOfDeks.Name = "lblNoOfDeks";
            this.lblNoOfDeks.Size = new System.Drawing.Size(207, 15);
            this.lblNoOfDeks.TabIndex = 6;
            this.lblNoOfDeks.Text = "How many packs to use (i.e. define N)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(118, 168);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 226);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdbBoth);
            this.Controls.Add(this.rdbSuit);
            this.Controls.Add(this.rdbFaceValue);
            this.Controls.Add(this.lblMatchingCondition);
            this.Controls.Add(this.txtNoOfDecks);
            this.Controls.Add(this.lblNoOfDeks);
            this.MaximizeBox = false;
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdbBoth;
        private RadioButton rdbSuit;
        private RadioButton rdbFaceValue;
        private Label lblMatchingCondition;
        private TextBox txtNoOfDecks;
        private Label lblNoOfDeks;
        private Button btnSubmit;
    }
}