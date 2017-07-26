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
            this.scaleBar1 = new SlimGis.MapKit.WinForms.ScaleBar();
            this.zoomBar1 = new SlimGis.MapKit.WinForms.ZoomBar();
            this.SuspendLayout();
            // 
            // Map1
            // 
            this.Map1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map1.Location = new System.Drawing.Point(8, 8);
            this.Map1.MapUnit = SlimGis.MapKit.Geometries.GeoUnit.Degree;
            this.Map1.Margin = new System.Windows.Forms.Padding(2);
            this.Map1.Name = "Map1";
            this.Map1.Size = new System.Drawing.Size(1118, 726);
            this.Map1.SpatialReference = null;
            this.Map1.TabIndex = 0;
            this.Map1.Text = "mapControl1";
            this.Map1.MapClick += new System.EventHandler<SlimGis.MapKit.WinForms.MapMouseEventArgs>(this.Map1_MapClick);
            // 
            // scaleBar1
            // 
            this.scaleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleBar1.Location = new System.Drawing.Point(12, 711);
            this.scaleBar1.Map = this.Map1;
            this.scaleBar1.Name = "scaleBar1";
            this.scaleBar1.Size = new System.Drawing.Size(150, 18);
            this.scaleBar1.TabIndex = 1;
            // 
            // zoomBar1
            // 
            this.zoomBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomBar1.Location = new System.Drawing.Point(1076, 12);
            this.zoomBar1.Map = this.Map1;
            this.zoomBar1.Name = "zoomBar1";
            this.zoomBar1.Size = new System.Drawing.Size(46, 89);
            this.zoomBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 741);
            this.Controls.Add(this.zoomBar1);
            this.Controls.Add(this.scaleBar1);
            this.Controls.Add(this.Map1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SlimGis.MapKit.WinForms.MapControl Map1;
        private SlimGis.MapKit.WinForms.ScaleBar scaleBar1;
        private SlimGis.MapKit.WinForms.ZoomBar zoomBar1;
    }
}

