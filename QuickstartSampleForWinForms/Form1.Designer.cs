namespace QuickstartSampleForWinForms
{
    partial class Form1
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
            this.Map1 = new SlimGis.MapKit.WinForms.MapControl();
            this.SuspendLayout();
            // 
            // Map1
            // 
            this.Map1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map1.Location = new System.Drawing.Point(8, 8);
            this.Map1.MapUnit = SlimGis.MapKit.Geometries.GeoUnit.Degree;
            this.Map1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Map1.Name = "Map1";
            this.Map1.Size = new System.Drawing.Size(815, 409);
            this.Map1.SpatialReference = null;
            this.Map1.TabIndex = 0;
            this.Map1.Text = "mapControl1";
            this.Map1.MapClick += new System.EventHandler<SlimGis.MapKit.WinForms.MapMouseEventArgs>(this.Map1_MapClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 424);
            this.Controls.Add(this.Map1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SlimGis.MapKit.WinForms.MapControl Map1;
    }
}

