using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Utilities;
using System.Linq;
using System.Windows.Forms;

namespace QuickstartSampleForWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Map1.MapUnit = GeoUnit.Meter;
            Map1.UseOpenStreetMapAsBaseMap();

            ShapefileLayer shapefileLayer = new ShapefileLayer("../../AppData/countries-900913.shp");
            shapefileLayer.UseRandomStyle(120);
            Map1.AddLayers("Dynamic Layers", shapefileLayer);

            Map1.ZoomToFullBound();
        }

        private void Map1_MapSingleClick(object sender, SlimGis.MapKit.WinForms.MapMouseEventArgs e)
        {
            // We added a ShapefileLayer in the Loaded event, 
            // it's default name is the name of the shapefile.
            // so here, we could find the layer back by the shapefile name without extension. 
            FeatureLayer featureLayer = Map1.FindLayer<FeatureLayer>("countries-900913");
            Feature identifiedFeature = IdentifyHelper.Identify(featureLayer, e.WorldCoordinate, Map1.CurrentScale, Map1.MapUnit).FirstOrDefault();

            MemoryLayer dynamicLayer = Map1.FindLayer<MemoryLayer>("Highlight Layer");
            if (dynamicLayer == null)
            {
                dynamicLayer = new MemoryLayer { Name = "Highlight Layer" };
                dynamicLayer.UseRandomStyle();
                Map1.AddLayers("HighlightOverlay", dynamicLayer);
            }

            dynamicLayer.Features.Clear();
            if (identifiedFeature != null)
            {
                dynamicLayer.Features.Add(identifiedFeature);
            }

            Map1.Overlays["HighlightOverlay"].Refresh();
        }
    }
}
