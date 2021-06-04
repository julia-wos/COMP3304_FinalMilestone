
namespace View
{
    partial class ImgDisplay
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
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.rotateLBtn = new System.Windows.Forms.Button();
            this.rotateRBtn = new System.Windows.Forms.Button();
            this.flipHBtn = new System.Windows.Forms.Button();
            this.flipVBtn = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.changeHBtn = new System.Windows.Forms.Button();
            this.wiedthLabel = new System.Windows.Forms.Label();
            this.changeWBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newWiedthInput = new System.Windows.Forms.NumericUpDown();
            this.newHeightInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWiedthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newHeightInput)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.imgBox.Location = new System.Drawing.Point(13, 126);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(610, 473);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // rotateLBtn
            // 
            this.rotateLBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rotateLBtn.BackColor = System.Drawing.Color.DeepPink;
            this.rotateLBtn.FlatAppearance.BorderSize = 2;
            this.rotateLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rotateLBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateLBtn.ForeColor = System.Drawing.Color.White;
            this.rotateLBtn.Location = new System.Drawing.Point(13, 72);
            this.rotateLBtn.Name = "rotateLBtn";
            this.rotateLBtn.Size = new System.Drawing.Size(145, 48);
            this.rotateLBtn.TabIndex = 1;
            this.rotateLBtn.Text = "Rotate 90° Left";
            this.rotateLBtn.UseVisualStyleBackColor = false;
            this.rotateLBtn.Click += new System.EventHandler(this.RotateLeft);
            // 
            // rotateRBtn
            // 
            this.rotateRBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rotateRBtn.BackColor = System.Drawing.Color.DeepPink;
            this.rotateRBtn.FlatAppearance.BorderSize = 2;
            this.rotateRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rotateRBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateRBtn.ForeColor = System.Drawing.Color.White;
            this.rotateRBtn.Location = new System.Drawing.Point(164, 72);
            this.rotateRBtn.Name = "rotateRBtn";
            this.rotateRBtn.Size = new System.Drawing.Size(143, 48);
            this.rotateRBtn.TabIndex = 2;
            this.rotateRBtn.Text = "Rotate 90° Right";
            this.rotateRBtn.UseVisualStyleBackColor = false;
            this.rotateRBtn.Click += new System.EventHandler(this.RotateRight);
            // 
            // flipHBtn
            // 
            this.flipHBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flipHBtn.BackColor = System.Drawing.Color.DeepPink;
            this.flipHBtn.FlatAppearance.BorderSize = 2;
            this.flipHBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flipHBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipHBtn.ForeColor = System.Drawing.Color.White;
            this.flipHBtn.Location = new System.Drawing.Point(462, 71);
            this.flipHBtn.Name = "flipHBtn";
            this.flipHBtn.Size = new System.Drawing.Size(145, 48);
            this.flipHBtn.TabIndex = 3;
            this.flipHBtn.Text = "Flip Horizontally";
            this.flipHBtn.UseVisualStyleBackColor = false;
            this.flipHBtn.Click += new System.EventHandler(this.FlipH);
            // 
            // flipVBtn
            // 
            this.flipVBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flipVBtn.BackColor = System.Drawing.Color.DeepPink;
            this.flipVBtn.FlatAppearance.BorderSize = 2;
            this.flipVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flipVBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipVBtn.ForeColor = System.Drawing.Color.White;
            this.flipVBtn.Location = new System.Drawing.Point(313, 71);
            this.flipVBtn.Name = "flipVBtn";
            this.flipVBtn.Size = new System.Drawing.Size(143, 48);
            this.flipVBtn.TabIndex = 4;
            this.flipVBtn.Text = "Flip Vertically";
            this.flipVBtn.UseVisualStyleBackColor = false;
            this.flipVBtn.Click += new System.EventHandler(this.FlipV);
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.ForeColor = System.Drawing.Color.White;
            this.heightLabel.Location = new System.Drawing.Point(12, 12);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(139, 18);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Choose new height:";
            // 
            // changeHBtn
            // 
            this.changeHBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeHBtn.BackColor = System.Drawing.Color.DeepPink;
            this.changeHBtn.FlatAppearance.BorderSize = 2;
            this.changeHBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeHBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeHBtn.ForeColor = System.Drawing.Color.White;
            this.changeHBtn.Location = new System.Drawing.Point(163, 12);
            this.changeHBtn.Name = "changeHBtn";
            this.changeHBtn.Size = new System.Drawing.Size(144, 48);
            this.changeHBtn.TabIndex = 9;
            this.changeHBtn.Text = "Apply new height";
            this.changeHBtn.UseVisualStyleBackColor = false;
            this.changeHBtn.Click += new System.EventHandler(this.ChangeHeight);
            // 
            // wiedthLabel
            // 
            this.wiedthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wiedthLabel.AutoSize = true;
            this.wiedthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiedthLabel.ForeColor = System.Drawing.Color.White;
            this.wiedthLabel.Location = new System.Drawing.Point(313, 12);
            this.wiedthLabel.Name = "wiedthLabel";
            this.wiedthLabel.Size = new System.Drawing.Size(142, 18);
            this.wiedthLabel.TabIndex = 11;
            this.wiedthLabel.Text = "Choose new wiedth:";
            // 
            // changeWBtn
            // 
            this.changeWBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeWBtn.BackColor = System.Drawing.Color.DeepPink;
            this.changeWBtn.FlatAppearance.BorderSize = 2;
            this.changeWBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeWBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeWBtn.ForeColor = System.Drawing.Color.White;
            this.changeWBtn.Location = new System.Drawing.Point(463, 12);
            this.changeWBtn.Name = "changeWBtn";
            this.changeWBtn.Size = new System.Drawing.Size(144, 48);
            this.changeWBtn.TabIndex = 12;
            this.changeWBtn.Text = "Apply new wiedth";
            this.changeWBtn.UseVisualStyleBackColor = false;
            this.changeWBtn.Click += new System.EventHandler(this.ChangeWiedth);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBtn.BackColor = System.Drawing.Color.DeepPink;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(173, 608);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(250, 48);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save As New Image";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveImage);
            // 
            // newWiedthInput
            // 
            this.newWiedthInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newWiedthInput.Location = new System.Drawing.Point(313, 40);
            this.newWiedthInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newWiedthInput.Name = "newWiedthInput";
            this.newWiedthInput.Size = new System.Drawing.Size(143, 20);
            this.newWiedthInput.TabIndex = 17;
            // 
            // newHeightInput
            // 
            this.newHeightInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newHeightInput.Location = new System.Drawing.Point(13, 40);
            this.newHeightInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newHeightInput.Name = "newHeightInput";
            this.newHeightInput.Size = new System.Drawing.Size(144, 20);
            this.newHeightInput.TabIndex = 16;
            // 
            // ImgDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(634, 668);
            this.Controls.Add(this.newWiedthInput);
            this.Controls.Add(this.newHeightInput);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.changeWBtn);
            this.Controls.Add(this.wiedthLabel);
            this.Controls.Add(this.changeHBtn);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.flipVBtn);
            this.Controls.Add(this.flipHBtn);
            this.Controls.Add(this.rotateRBtn);
            this.Controls.Add(this.rotateLBtn);
            this.Controls.Add(this.imgBox);
            this.Name = "ImgDisplay";
            this.Text = "ImgDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWiedthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newHeightInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button rotateLBtn;
        private System.Windows.Forms.Button rotateRBtn;
        private System.Windows.Forms.Button flipHBtn;
        private System.Windows.Forms.Button flipVBtn;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button changeHBtn;
        private System.Windows.Forms.Label wiedthLabel;
        private System.Windows.Forms.Button changeWBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.NumericUpDown newWiedthInput;
        private System.Windows.Forms.NumericUpDown newHeightInput;
    }
}