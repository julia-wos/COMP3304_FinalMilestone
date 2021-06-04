
namespace View
{
    partial class CollectionDisplay
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
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddImg = new System.Windows.Forms.Button();
            this.ImgDisplayTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoScroll = true;
            this.layoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.layoutPanel.Location = new System.Drawing.Point(13, 53);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(759, 696);
            this.layoutPanel.TabIndex = 0;
            // 
            // AddImg
            // 
            this.AddImg.BackColor = System.Drawing.Color.DeepPink;
            this.AddImg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddImg.FlatAppearance.BorderSize = 2;
            this.AddImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.AddImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.AddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImg.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddImg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddImg.Location = new System.Drawing.Point(13, 9);
            this.AddImg.Margin = new System.Windows.Forms.Padding(0);
            this.AddImg.Name = "AddImg";
            this.AddImg.Size = new System.Drawing.Size(158, 38);
            this.AddImg.TabIndex = 1;
            this.AddImg.Text = "Add Images";
            this.AddImg.UseVisualStyleBackColor = false;
            this.AddImg.Click += new System.EventHandler(this.LoadNewImages);
            // 
            // ImgDisplayTest
            // 
            this.ImgDisplayTest.Location = new System.Drawing.Point(543, 9);
            this.ImgDisplayTest.Name = "ImgDisplayTest";
            this.ImgDisplayTest.Size = new System.Drawing.Size(229, 38);
            this.ImgDisplayTest.TabIndex = 2;
            this.ImgDisplayTest.Text = "ImgDisplay Test";
            this.ImgDisplayTest.UseVisualStyleBackColor = true;
            // 
            // CollectionDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.ImgDisplayTest);
            this.Controls.Add(this.AddImg);
            this.Controls.Add(this.layoutPanel);
            this.Name = "CollectionDisplay";
            this.Text = "CollectionDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Button AddImg;
        private System.Windows.Forms.Button ImgDisplayTest;
    }
}