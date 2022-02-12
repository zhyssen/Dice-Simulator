namespace Dice_Simulator
{
    partial class DiceSimulatorForm
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
            this.dieTotalDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.die2PictureBox = new System.Windows.Forms.PictureBox();
            this.die1PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.die2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dieTotalDescriptionLabel
            // 
            this.dieTotalDescriptionLabel.AutoSize = true;
            this.dieTotalDescriptionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieTotalDescriptionLabel.Location = new System.Drawing.Point(115, 202);
            this.dieTotalDescriptionLabel.Name = "dieTotalDescriptionLabel";
            this.dieTotalDescriptionLabel.Size = new System.Drawing.Size(55, 18);
            this.dieTotalDescriptionLabel.TabIndex = 2;
            this.dieTotalDescriptionLabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(176, 192);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 37);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(87, 258);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(193, 34);
            this.rollButton.TabIndex = 4;
            this.rollButton.Text = "&Roll the Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(148, 314);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 28);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // die2PictureBox
            // 
            this.die2PictureBox.Image = global::Dice_Simulator.Properties.Resources.dice1;
            this.die2PictureBox.Location = new System.Drawing.Point(197, 45);
            this.die2PictureBox.Name = "die2PictureBox";
            this.die2PictureBox.Size = new System.Drawing.Size(110, 110);
            this.die2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die2PictureBox.TabIndex = 1;
            this.die2PictureBox.TabStop = false;
            // 
            // die1PictureBox
            // 
            this.die1PictureBox.Image = global::Dice_Simulator.Properties.Resources.dice1;
            this.die1PictureBox.Location = new System.Drawing.Point(50, 45);
            this.die1PictureBox.Name = "die1PictureBox";
            this.die1PictureBox.Size = new System.Drawing.Size(110, 110);
            this.die1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die1PictureBox.TabIndex = 0;
            this.die1PictureBox.TabStop = false;
            // 
            // DiceSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 358);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.dieTotalDescriptionLabel);
            this.Controls.Add(this.die2PictureBox);
            this.Controls.Add(this.die1PictureBox);
            this.Name = "DiceSimulatorForm";
            this.Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.die2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox die1PictureBox;
        private System.Windows.Forms.PictureBox die2PictureBox;
        private System.Windows.Forms.Label dieTotalDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button exitButton;
    }
}

