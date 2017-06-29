# Quickstart Guide for WinForms Map Kit
SlimGIS Map Kit for WinForms is a .net WinForms component to help you to easily build up a Map based WinForms application. It contains full function of SlimGIS MapKit Core which comes with Geometry, GeoFunction, Symbology, Renderer, DataSource, Layer etc. In this guide, we are going to focus on the WPF component introduction and create the first application with it.

When you are reading this guide, I assume that you have installed SlimGIS Setup on your machine (if not ready, please visit [installation guide](http://www.slimgis.com/documents/installation) and make it ready for few steps).

In this guide, I will introduce the following items:

1. Scenario description
1. Add assembly references and init the map control
1. Add OpenStreetMap as base map
1. Build-in Mouse operation
1. Add a Shapefile and set styles
2. Add build-in controls: zoom bar, scale bar etc
1. Identify a feature and highlight it

All right, I think we can stop here. Not too much content. It is only parts of this WinForms component. View [this page](https://slimgis.com/documents/features-overview-all) for the full feature list.

## Scenario description
What a basic map contains? I'm sure everyone has a different vision of it. Let's open the web browser and visit [maps.google.com](https://www.google.com/maps). It is the most popular map currently.  
![quickstart-guide-google](http://p1.bqimg.com/567571/baf5b2a702cd22b2.png)
A basic map application usually contains a map of course; a serial buttons to controll the map viewport (In the screenshot above, it adorns on the bottom right corner, see the little "+" and "-" button). A scale bar belows the buttons on the right of the very bottom. We can add more controls to make it convenient to use. Like displaying current mouse coordinate. This is what all for a common maps have. That's not all for this guide. You know everyone loves Google Maps, but compare with a component, we can do more as we like. In the following part, we will load our own Shapefile, set a nice style and put a lable on it; then interact with it. Isn't it cool? Let's get start.

## Add assembly references and init the map control
To start the demo, every developers know how to create a project with Visual Studio. In this guide, I will use Visual Studio 2015 Community version. Here are few steps, I will try to make it simple. Open VS2015 -> Create a WPF Application and name it `QuickstartSampleForWpf`.  
At this step, there are several options to continue:
1. Drag the map component from *ToolBox* in Visual Studio.
2. Reference assembly from installed folder.
3. Reference package from NuGet.org.

We will go with option one, as it is already installed on your machine at *C:\Program Files (x86)\SlimGIS\3.0.0\SDK\WinForms*. Let's drag *SGMapKit.WinForms.dll* into the toolbox; Visual Studio will automatically detect the custom controls inside this assembly and prepare the controls for you. See the screenshot below.  
![quickstart-guide-winforms-toolbox](http://p1.bqimg.com/567571/babbefbe302c04f4.png)  
MapControl is what we are going to add to the *Form1.cs* design-time. Drag this control into the default *Form1* that is created by WinForms application template and set a proper size. I'd like to make it like following size.
![quickstart-guide-winforms-set-a-proper-size](http://p1.bpimg.com/567571/3f3b3dd23d4d099e.png)  
One more thing before coding is to add an extra assembly *SlimGis.MapKit.Core* to the reference. This assembly can be located in the same fold of *SlimGis.MapKit.WinForms.dll*.

Click on the map control to make it focus -> Press `F4` button to open the *Properties Explorer*. First we set the control's name to `Map1` just like we always did in the quickstart samples. 
![quickstart-guide-winforms-name](http://p1.bpimg.com/567571/c29fd5df0aa9e343.png)
Press `F7` to switch to `View Code` mode and navigate to the constructor of `Form1` class. 

## Add OpenStreetMap as base map
First, we set the very first and important setting on map, the `MapUnit`. `MapUnit` defines the primary coordinate unit which is used to caclulate the vectors or raster position or measuring etc. on the map. In SlimGIS products, we supports linear and degree (longitude & latitude) coordiante system.
```csharp
Map1.MapUnit = GeoUnit.Meter;
```
We used linear coordinate unit `Meter` here, because as we described just now, we are going to add `OpenStreetMap` as base map. It is a 3rd part map imagery service that is provided by [OpenStreetMap](http://www.openstreetmap.org). While OpenStreetMap is using linear coordinate unit `Meter`, so we have to follow the base map's primary coordinate unit and use it for the further caculation.  
Now we are going to add OpenStreetMap as base map and zoom the location to the full bound of it.
```csharp
Map1.UseOpenStreetMapAsBaseMap();
Map1.ZoomToFullBound();
```
That's all to add an OpenStreetMap as base map now. Vert straight forward right? Let's press `F5` to see the effect.
![quickstart-guide-winforms-osm](http://p1.bqimg.com/567571/cadf260c2ee45301.png)

## Build-in Mouse operation
Now you could feel free to do the operations below. 
1. Pan the map around with dragging the map and move your mouse.
2. Zoom in/out by mouse wheel up/down.
3. Zoom current map viewport to the next level by double click.  
4. Press `Shift` key on keyboard and hold -> use mouse to draw a rectangle to zoom the drawn area.

## Add a ShapeFile and set styles
We prepared a contrys ShapeFile data in Spherical Mercator in the sample. If you are following this guide to create this sample step by step, please copy the *AppData* folder from the project folder to your's. Let's take a look at the code below:

```csharp
ShapefileLayer shapefileLayer = new ShapefileLayer("../../AppData/cntry02-900913.shp");
shapefileLayer.UseRandomStyle(120);
Map1.AddStaticLayers("Dynamic Layers", shapefileLayer);
```

> Note: `shapefileLayer.UseRandomStyle(120)` means we give it a random style with 120 alpha component for the fill color. So the screenshots below might have different fill color.*  

Now, our map becomes this:
![quickstart-guide-winforms-osm-shp](http://i1.piimg.com/567571/d89773ed53fc5346.png)

## Add build-in controls: zoom bar, scale bar etc.
Working...

## Identify a feature and highlight it
At current step, our map is static map. Although we have build-in mouse interaction etc. But that is not enough for a map control.  
In this section, we are going to do some custom interaction with map. Like the normal map that allows to identify a feature and highlight it on the map. Here are how we make it true. 
1. add a click event on the map. We will add it in XAML like we used to do.  
![quickstart-guide-winforms-event-click](https://raw.githubusercontent.com/SlimGIS/QuickstartSampleForWinForms/master/Screenshots/quickstart-guide-winforms-event-click.png)  
2. Implement the event as following.

```csharp
private void Map1_MapClick(object sender, SlimGis.MapKit.WinForms.MapMouseEventArgs e)
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
        Map1.AddStaticLayers("HighlightOverlay", dynamicLayer);
    }

    dynamicLayer.Features.Clear();
    if (identifiedFeature != null)
    {
        dynamicLayer.Features.Add(identifiedFeature);
    }

    Map1.Overlays["HighlightOverlay"].Refresh();
}
```

Done, press `F5` to run your first fantasy map application. It's pretty simple. 
![quickstart-guide-winforms-final](http://p1.bqimg.com/567571/c6389a2440961fd8.png)

I'm sure you have more ideas for this guide. Please feel free to create a pull request, we are glad to take suggestions from you. Also, let us know how you think by dev@slimgis.com.

### Related Resources

- [Source code](https://github.com/SlimGIS/QuickstartSampleForWinForms)
- [Installation guide](http://www.slimgis.com/documents/installation)
- [Map Kit WinForms introduction](https://slimgis.com/products/winforms)
- [WinForms feature samples](https://www.slimgis.com/documents/feature-samples-winforms)
- [WinForms feature list](https://www.slimgis.com/documents/features-overview-winforms)
- [WinForms API reference](https://www.slimgis.com/documents/api-ref-winforms)
