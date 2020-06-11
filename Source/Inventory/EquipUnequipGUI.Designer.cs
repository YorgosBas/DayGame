namespace DayGame
{
    partial class EquipUnequipGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.equipButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statnumber = new System.Windows.Forms.Label();
            this.itemnamelabel = new System.Windows.Forms.Label();
            this.statlabel = new System.Windows.Forms.Label();
            this.itemdescriptionlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.equipButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.statnumber);
            this.panel1.Controls.Add(this.itemnamelabel);
            this.panel1.Controls.Add(this.statlabel);
            this.panel1.Controls.Add(this.itemdescriptionlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 274);
            this.panel1.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(88, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 30);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // equipButton
            // 
            this.equipButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.equipButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.equipButton.Location = new System.Drawing.Point(75, 197);
            this.equipButton.Name = "equipButton";
            this.equipButton.Size = new System.Drawing.Size(108, 35);
            this.equipButton.TabIndex = 24;
            this.equipButton.Text = "s";
            this.equipButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(100, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 61);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // statnumber
            // 
            this.statnumber.AutoSize = true;
            this.statnumber.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.statnumber.Location = new System.Drawing.Point(172, 168);
            this.statnumber.Name = "statnumber";
            this.statnumber.Size = new System.Drawing.Size(65, 26);
            this.statnumber.TabIndex = 23;
            this.statnumber.Text = "+Stat";
            // 
            // itemnamelabel
            // 
            this.itemnamelabel.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.itemnamelabel.Location = new System.Drawing.Point(0, 135);
            this.itemnamelabel.Name = "itemnamelabel";
            this.itemnamelabel.Size = new System.Drawing.Size(263, 15);
            this.itemnamelabel.TabIndex = 20;
            this.itemnamelabel.Text = "ItemName";
            this.itemnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statlabel
            // 
            this.statlabel.AutoSize = true;
            this.statlabel.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.statlabel.Location = new System.Drawing.Point(30, 168);
            this.statlabel.Name = "statlabel";
            this.statlabel.Size = new System.Drawing.Size(67, 26);
            this.statlabel.TabIndex = 22;
            this.statlabel.Text = "(Stat)";
            // 
            // itemdescriptionlabel
            // 
            this.itemdescriptionlabel.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold);
            this.itemdescriptionlabel.Location = new System.Drawing.Point(0, 150);
            this.itemdescriptionlabel.Name = "itemdescriptionlabel";
            this.itemdescriptionlabel.Size = new System.Drawing.Size(263, 14);
            this.itemdescriptionlabel.TabIndex = 21;
            this.itemdescriptionlabel.Text = "(Description)";
            this.itemdescriptionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipUnequipGUI
            // 
            this.AcceptButton = this.equipButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(261, 274);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipUnequipGUI";
            this.Text = "EquipUnequipGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button equipButton;
        private System.Windows.Forms.Label itemdescriptionlabel;
        private System.Windows.Forms.Label itemnamelabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label statlabel;
        private System.Windows.Forms.Label statnumber;

        #endregion
    }
}
