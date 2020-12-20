# ImageBox
ImageBox is a C# image processing library with a wide range of options for user to use. ImageBox is a library, as well as CLI and GUI interfaces for it.

ImageBox is a library that runs on .Net Framework 4.0, 4.5, 4.7, 4.8, .Net Core 3.1, as well as .Net 5. Please see Build and Usage sections below for details.

## Example
Example shows application of a contrast with value of 1.3, as well as Sepia. Please see original and modified images below.


![Example of contrast modification image with ImageBox](https://github.com/americusmaximus/ImageBox/blob/main/Docs/Unsplash.Original.jpg)

> Original image.

![Example of contrast modification image with ImageBox](https://github.com/americusmaximus/ImageBox/blob/main/Docs/Unsplash.Contrast.1.3.png)

> Modified image. Contrast of 1.3.

![Example of image with Sepia with ImageBox](https://github.com/americusmaximus/ImageBox/blob/main/Docs/Unsplash.Sepia.png)

> Modified image. Sepia.

## Build
### Windows
#### Visual Studio
Open one of the solutions and build it. Please see `<TargetFrameworks>` node in the `.csproj` files to add or remove target frameworks for the build.
#### CLI
To build the solution please use following command:

> dotnet build ImageBox.CLI.sln --configuration Release

To build the solution for only one of the target frameworks please use the following command that shows an example of building for .Net 5.

> dotnet build ImageBox.CLI.sln --framework net50 -- configuration Release

To publish the code you always have to specify the target framework since `dotnet` doesn't support publishing multi-target projects.

> dotnet publish ImageBox.CLI.sln --framework net50 --configuration Release

**Note**: `dotnet` is unable to build the UI for any of the target frameworks.

### Linux
#### CLI
Please see the CLI section of building the code under Windows.
#### Dependencies
.Net on Linux depends on `libgdiplus` for font rasterization.

In case you see errors mentioning the following:

> The type initializer for 'Gdip' threw an exception.

or

> Unable to load DLL 'libgdiplus': The specified module could not be found.

you have to install libgdiplus library on your computer, which you can do by executing the following command:

> sudo apt install libgdiplus
 
## Use
### Windows
#### CLI
ImageBox CLI on Windows 7

![ImageBox CLI on Windows 7](https://github.com/americusmaximus/ImageBox/blob/main/Docs/ImageBox.CLI.Win.7.png)


Below is the output of running a help command
>ImageBox.CLI.exe h

##### angle
[Rotate] A floating-point angle for the image rotation. Default value is <0> (zero).

##### axis
[Flip] An axis for the image flip. Possible values are "None, "Horizontal", "Vertical", and "Both". Default values is "None".

##### color
[Rotate] A fill color. Color can be specified as a name,  ARGB integer, or a HEX value. Example: "red", "-65536", "#00ff0000". Default value is "Transparent".

##### format
[Split] An output image(s) format. Possible values are BMP, EMF, EXIF, GIF, ICON, JPEG, PNG, TIFF, and WMF. Default value is BMP.

##### horizontal
[Split] A positive integer number of horizontal units for image splitting. The value is required for the "Split" mode.

##### image
A path to the input image file. Image is a required parameter. Supported image formats are BMP, EMF, EXIF, GIF, ICON, JPEG, PNG, TIFF, and WMF.

##### matrix
[Color] A matrix type the image coloring. Possible values:

- Achromatomaly
- Achromatopsia
- AverageGrayScale
- BlackAndWhite
- Brightness, possible value range is "-1" to "1", default: "0",
- Cold
- Contrast, possible value range is "0" to "2", default: "1",
- Deuteranomaly
- Deuteranopia
- Exposure, possible value range is "0" to "4", default: "1",
- GrayScale
- Inverted
- LuminanceToAlpha
- Negative
- NightVision
- Normal
- Polaroid
- Protanomaly
- Protanopia
- RGBBGR
- Saturation, possible value range is "0" to "10", default: "1",
- Sepia
- Temperature, possible value range is "0" to "4", default: "0",
- Threshold, possible value range is "0" to "4", default: "0",
- Tint, possible value range is "0" to "4", default: "0",
- Tritanomaly
- Tritanopia
- Warm
- WhiteToAlpha

##### matrixvalue
[Color] A matrix value floating point number parameter for some types of matrices. The parameter is optional, default value is going to be used if the value is not provided.

##### mode
A mode of ImageBox execution. Mode is a required parameter. Possible values are "Color", "Flip", "Rotate", "Split", and "Stats".

- "Color" mode allows the user to manipulate the input image colors.
- "Flip" mode allows the user to flip the image along the image axes.
- "Rotate" mode allows user to rotate the input image by a specified angle.
-"Split" mode allows the user to split the input image into a number of smaller images.
- "Stats" mode analyzes the input image and produces color statistics.

##### output
A path to the output file, or an output directory for the "Split" mode.

##### unit
[Split] An image split unit type. Possible values are "Pixel" and "Piece". Default value is "Pixel".

##### vertical
An integer positive number of vertical units for image splitting. The value is required for the "Split" mode.


#### Example
The following command line produces an image shown below.

>ImageBox.CLI.exe mode=color matrix=contrast matrixvalue=1.3 image=C:\Unsplash.Original.jpg output=C:\Unsplash.Contrast.1.3.png

Resulting image:

![Example of contrast modification image with ImageBox](https://github.com/americusmaximus/ImageBox/blob/main/Docs/Unsplash.Contrast.1.3.png)


#### UI
ImageBox UI runs on Windows exclusively. It allows for easy and dynamic preview when applicable, as well as ease of use without a need to remember CLI options.

ImageBox on Windows 7

![ImageBox UI on Windows 7](https://github.com/americusmaximus/ImageBox/blob/main/Docs/ImageBox.UI.Win.7.png)

ImageBox on Windows 10

![ImageBox UI on Windows 10](https://github.com/americusmaximus/ImageBox/blob/main/Docs/ImageBox.UI.Win.10.png)
### Linux
#### CLI
ImageBox CLI on xUbuntu 20.04

![ImageBox CLI on xUbuntu 20.04](https://github.com/americusmaximus/ImageBox/blob/main/Docs/ImageBox.CLI.xUbuntu.20.04.png)

Please see detailed description and example of the calls in Windows CLI section. Please note the differences in calling the CLI.

On Linux you have to call dotnet and provide path to the ImageBox.CLI.dll as a first parameter, the ImageBox parameters must follow afterward, please see example below:

>dotnet ImageBox.CLI.dll [parameters]