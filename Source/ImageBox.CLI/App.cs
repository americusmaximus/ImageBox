﻿#region License
/*
MIT License

Copyright (c) 2020 Americus Maximus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using ImageBox.Coloring;
using ImageBox.Splitting;
using ImageBox.Statistics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ImageBox.CLI
{
    public class App
    {
        static readonly Dictionary<string, string> Help = new Dictionary<string, string>()
        {
            { "format",           "An output image(s) format for \"Split\" mode.\n                    Possible values are BMP, EMF, EXIF, GIF, ICON, JPEG, PNG,\n                    TIFF, and WMF.\n                    Default value is BMP."},
            { "horizontal",       "An integer positive number of horizontal units for image\n                    splitting in the \"Split\" mode.\n                    The value is required for the \"Split\" mode."},
            { "image",            "A path to the input image file.\n                    Image is a required parameter.\n                    Supported image formats are BMP, EMF, EXIF, GIF, ICON,\n                    JPEG, PNG, TIFF, and WMF." },
            { "matrix",           "A matrix type for the \"Color\" mode.\n                    Matrix is a required parameter for the \"Color\" mode.\n                    Possible values are:\n                    \"Achromatomaly\",\n                    \"Achromatopsia\",\n                    \"AverageGrayScale\",\n                    \"BlackAndWhite\",\n                    \"Brightness\",    value range is \"-1\" to \"1\", default: \"0\",\n                    \"Cold\",\n                    \"Contrast\",       value range is \"0\" to \"2\", default: \"1\",\n                    \"Deuteranomaly\",\n                    \"Deuteranopia\",\n                    \"Exposure\",       value range is \"0\" to \"4\", default: \"1\",\n                    \"GrayScale\",\n                    \"Inverted\",\n                    \"LuminanceToAlpha\",\n                    \"Negavtive\",\n                    \"NightVision\",\n                    \"Normal\",\n                    \"Polaroid\",\n                    \"Protanomaly\",\n                    \"Protanopia\",\n                    \"RGBBGR\",\n                    \"Saturation\",     value range is \"0\" to \"4\", default: \"1\",\n                    \"Sepia\",\n                    \"Temperature\",    value range is \"0\" to \"4\", default: \"0\",\n                    \"Threshold\",      value range is \"0\" to \"4\", default: \"0\",\n                    \"Tint\",           value range is \"0\" to \"4\", default: \"0\",\n                    \"Tritanomaly\",\n                    \"Tritanopia\",\n                    \"Warm\",\n                    \"WhiteToAlpha\"."},
            { "matrixvalue",      "A matrix value floating point number parameter for some\n                    types of matrices in the \"Color\" mode.\n                    The parameter is optional, default value is going to be\n                    used if the value is not provided." },
            { "mode",             "A mode of ImageBox execution. Mode is a required parameter.\n                    Possible values are \"Color\", \"Split\", and \"Stats\".\n                    \"Color\" mode allows the user to manipulate the input image\n                    colors.\n                    \"Split\" mode allows the user to split the input image into\n                    a number of smaller images.\n                    \"Stats\" mode analyzes the input image and produces color\n                    statistics."},
            { "output",           "A path to the output file, or an output directory for\n                    the \"Split\" mode."},
            { "unit",             "An image split unit type for the \"Split\" mode.\n                    Possible values are \"Pixel\" and \"Piece\".\n                    Default value is \"Pixel\"."},
            { "vertical",         "An integer positive number of vertical units for image\n                    splitting in the \"Split\" mode.\n                    The value is required for the \"Split\" mode."}
        };

        public static int Color(Image image, string output, Nullable<ColorerMatrixType> colorMatrixType, Nullable<float> colorMatrixValue)
        {
            if (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(string.Format("Output parameter is required in <{0}> mode. Please see help for details.", AppMode.Color));

                return -1;
            }

            var descriptor = ColorerMatrix.Get(colorMatrixType.Value, colorMatrixValue);

            if (descriptor.IsValueRequired && colorMatrixValue.HasValue && colorMatrixValue.Value < descriptor.MinimumValue)
            {
                Console.WriteLine(string.Format("Matrix value of <{0}> is smaller than the minimum supported value of <{1}>.", colorMatrixValue, descriptor.MinimumValue));

                return -1;
            }

            if (descriptor.IsValueRequired && colorMatrixValue.HasValue && colorMatrixValue.Value > descriptor.MaximumValue)
            {
                Console.WriteLine(string.Format("Matrix value of <{0}> is greater than the maximum supported value of <{1}>.", colorMatrixValue, descriptor.MaximumValue));

                return -1;
            }

            var directory = Path.GetDirectoryName(output);
            if (!Directory.Exists(directory))
            {
                Console.WriteLine(string.Format("Directory <{0}> does not exists.", directory));

                return -1;
            }

            try
            {
                var extension = Path.GetExtension(output).ToLowerInvariant().Replace(".", string.Empty);

                if (!TryParseImageFormat(extension, out var imageFormatValue))
                {
                    Console.WriteLine(string.Format("Image extension <{0}> is not supported. Saving image as a BMP.", extension));
                }

                var outputFileName = imageFormatValue != default ? output : (output + ".bmp");
                new Colorer(image).Color(descriptor.Matrix).Save(outputFileName, imageFormatValue ?? ImageFormat.Bmp);

                Console.WriteLine(string.Format("Image saved as <{0}>.", outputFileName));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Unable to save image as <{0}>. Please see the error below.", output));
                Console.WriteLine(ex.ToString());

                return -1;
            }

            return 0;
        }

        public static string GetHelpString(string parameter)
        {
            if (string.IsNullOrWhiteSpace(parameter)) { return "No help available for <blank> parameter."; }

            if (parameter == "m") { parameter = "mode"; }

            if (Help.TryGetValue(parameter, out var result))
            {
                return result;
            }

            return string.Format("No help available for <{0}> parameter.", parameter);
        }

        public static string ImageFormatToFileExtension(ImageFormat format)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(x => x.FormatID == format.Guid).FilenameExtension
                                        .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[0].Replace("*", string.Empty);
        }

        public static int Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(string.Format("ImageBox [Version {0}]", Assembly.GetExecutingAssembly().GetName().Version.ToString()));
            Console.WriteLine("Copyright © 2020 Americus Maximus.");
            Console.WriteLine();

            if (args == default || args.Length == 0)
            {
                Console.WriteLine("Usage: ImageBox.CLI [options|parameters].");
                Console.WriteLine();
                Console.WriteLine("Options:");
                Console.WriteLine(" h|help                              Display help.");
                Console.WriteLine(" h=[parameter]|help=[parameter]      Display help for a specified parameter.");
                Console.WriteLine(" m=[mode]|mode=[mode] [parameters]   Run ImageBox in a specific mode with\n                                  specified parameters.");
                Console.WriteLine(" v|version                           Display version.");

                return 0;
            }

            var parameters = args.ToArray();

            // Version takes priority over anything else
            if (parameters.Any(a => a.ToLowerInvariant() == "v") || parameters.Any(a => a.ToLowerInvariant() == "version"))
            {
                Console.WriteLine(string.Format("Version {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString()));

                return 0;
            }

            // Help is a second highest priority.
            if (parameters.Any(a => a.ToLowerInvariant() == "h") || parameters.Any(a => a.ToLowerInvariant() == "help"))
            {
                Console.WriteLine("Help:");

                foreach (var x in Help.OrderBy(h => h.Key))
                {
                    Console.Write(x.Key.PadRight(20));
                    Console.WriteLine(x.Value);
                    Console.WriteLine();
                }

                return 0;
            }

            if (parameters.Any(a => a.ToLowerInvariant().StartsWith("h=")) || parameters.Any(a => a.ToLowerInvariant().StartsWith("help=")))
            {
                var ars = parameters.Where(a => a.ToLowerInvariant().StartsWith("h=") || a.ToLowerInvariant().StartsWith("help=")).OrderBy(a => a).ToArray();

                Console.WriteLine("Help:");

                for (var x = 0; x < ars.Length; x++)
                {
                    if (ars[x].StartsWith("h=")) { ars[x] = ars[x].Substring(2, ars[x].Length - 2); }
                    if (ars[x].StartsWith("help=")) { ars[x] = ars[x].Substring(5, ars[x].Length - 5); }

                    Console.Write(ars[x].PadRight(20));
                    Console.WriteLine(GetHelpString(ars[x]));
                    Console.WriteLine();
                }

                return 0;
            }

            // Execution mode
            var appMode = AppMode.Color;

            if (!parameters.Any(a => a.ToLowerInvariant().StartsWith("m=")) && !parameters.Any(a => a.ToLowerInvariant().StartsWith("mode=")))
            {
                Console.WriteLine("Mode parameter is required. Please see help for details.");

                return -1;
            }
            else
            {
                var ars = parameters.Where(a => a.ToLowerInvariant().StartsWith("m=") || a.ToLowerInvariant().StartsWith("mode=")).OrderBy(a => a).ToArray();

                if (ars.Length != 1)
                {
                    Console.WriteLine("There can be only one mode parameter.");

                    return -1;
                }

                for (var x = 0; x < ars.Length; x++)
                {
                    if (ars[x].StartsWith("m=")) { ars[x] = ars[x].Substring(2, ars[x].Length - 2); }
                    if (ars[x].StartsWith("mode=")) { ars[x] = ars[x].Substring(5, ars[x].Length - 5); }
                }

                if (!Enum.TryParse<AppMode>(ars[0], true, out appMode))
                {
                    Console.WriteLine(string.Format("Unable to parse value <{0}> as a mode.", ars[0]));

                    return -1;
                }
            }

            // Image
            var image = default(Image);
            string imageFileName = string.Empty;

            if (!parameters.Any(a => a.ToLowerInvariant().StartsWith("image=")))
            {
                Console.WriteLine("Image parameter is required. Please see help for details.");

                return -1;
            }
            else
            {
                var ars = parameters.Where(a => a.ToLowerInvariant().StartsWith("image=")).OrderBy(a => a).ToArray();

                if (ars.Length != 1)
                {
                    Console.WriteLine("There can be only one image parameter.");

                    return -1;
                }

                for (var x = 0; x < ars.Length; x++)
                {
                    if (ars[x].StartsWith("image=")) { ars[x] = ars[x].Substring(6, ars[x].Length - 6); }
                }

                if (string.IsNullOrWhiteSpace(ars[0]))
                {
                    Console.WriteLine("Image file path cannot be empty.");

                    return -1;
                }

                var normalizedPath = NormalizeFileName(ars[0]);

                if (!File.Exists(normalizedPath))
                {
                    Console.WriteLine(string.Format("Image file <0> not found.", normalizedPath));

                    return -1;
                }

                try
                {
                    image = Image.FromFile(normalizedPath);
                    imageFileName = normalizedPath;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Unable to load image <0>.", normalizedPath));
                    Console.WriteLine(ex.ToString());

                    return -1;
                }
            }

            // Output
            var output = string.Empty;
            if (parameters.Any(a => a.ToLowerInvariant().StartsWith("output=")))
            {
                var ars = parameters.Where(a => a.ToLowerInvariant().StartsWith("output=")).OrderBy(a => a).ToArray();

                if (ars.Length != 1)
                {
                    Console.WriteLine("There can be only one output parameter.");

                    return -1;
                }

                for (var x = 0; x < ars.Length; x++)
                {
                    if (ars[x].StartsWith("output=")) { ars[x] = ars[x].Substring(7, ars[x].Length - 7); }
                }

                if (string.IsNullOrWhiteSpace(ars[0]))
                {
                    Console.WriteLine("Output path cannot be empty.");

                    return -1;
                }

                output = NormalizeFileName(ars[0]);
            }

            // Process parameters
            var colorMatrixType = new Nullable<ColorerMatrixType>();
            var colorMatrixValue = new Nullable<float>();

            var splitHorizontal = new Nullable<int>();
            var splitImageFormat = ImageFormat.Bmp;
            var splitUnitType = new Nullable<SplitUnitType>();
            var splitVertical = new Nullable<int>();

            foreach (var p in parameters)
            {
                if (!p.Contains("="))
                {
                    Console.WriteLine(string.Format("Unable to parse <{0}> parameter. Skipping it.", p));
                    continue;
                }

                var key = p.Substring(0, p.IndexOf("=")).ToLowerInvariant();

                if (key == "m" || key == "mode" || key == "image" || key == "output") { continue; }

                var pms = parameters.Where(ar => ar.ToLowerInvariant().StartsWith(key + "=")).ToArray();

                if (pms.Length != 1)
                {
                    Console.WriteLine(string.Format("There can be only one parameter <{0}>", key));

                    return -1;
                }

                var value = p.Substring(key.Length + 1, p.Length - key.Length - 1);

                switch (appMode)
                {
                    case AppMode.Color:
                        {
                            if (key == "matrix")
                            {
                                if (Enum.TryParse<ColorerMatrixType>(value, true, out var matrixType))
                                {
                                    colorMatrixType = matrixType;
                                }
                                else
                                {
                                    Console.WriteLine(string.Format("Unable to parse <0> as a matrix value.", value));

                                    return -1;
                                }
                            }
                            else if (key == "matrixvalue")
                            {
                                if (float.TryParse(value, out var floatValue))
                                {
                                    colorMatrixValue = floatValue;
                                }
                                else
                                {
                                    Console.WriteLine(string.Format("Unable to parse <0> as a floating point number. Using default value.", value));
                                }
                            }
                            else
                            {
                                Console.WriteLine(string.Format("Parameter <{0}> is not suported in <1> mode.", key, appMode));
                            }

                            break;
                        }
                    case AppMode.Split:
                        {
                            if (key == "unit")
                            {
                                if (Enum.TryParse<SplitUnitType>(value, true, out var splitUnitTypeValue))
                                {
                                    splitUnitType = splitUnitTypeValue;
                                }
                                else
                                {
                                    Console.WriteLine(string.Format("Unable to parse <0> as a split type. Using default value <{1}>.", value, SplitUnitType.Pixel));
                                }
                            }
                            else if (key == "horizontal")
                            {
                                if (int.TryParse(value, out var intValue))
                                {
                                    splitHorizontal = intValue;
                                }
                                else
                                {
                                    Console.WriteLine(string.Format("Unable to parse <0> as an integer value.", value));

                                    return -1;
                                }
                            }
                            else if (key == "vertical")
                            {
                                if (int.TryParse(value, out var intValue))
                                {
                                    splitVertical = intValue;
                                }
                                else
                                {
                                    Console.WriteLine(string.Format("Unable to parse <0> as an integer value.", value));

                                    return -1;
                                }
                            }
                            else if (key == "format")
                            {
                                if (TryParseImageFormat(value, out var imageFormatValue))
                                {
                                    splitImageFormat = imageFormatValue;
                                }
                                else
                                {
                                    Console.WriteLine(string.Format("Unable to parse <0> as an image format. Using default value.", value));
                                }
                            }
                            else
                            {
                                Console.WriteLine(string.Format("Parameter <{0}> is not suported in <1> mode.", key, appMode));
                            }

                            break;
                        }
                    case AppMode.Stats:
                        {
                            Console.WriteLine(string.Format("Parameter <{0}> is not suported in <1> mode.", key, appMode));

                            break;
                        }
                }
            }

            // Execution
            switch (appMode)
            {
                case AppMode.Color:
                    {
                        return Color(image, output, colorMatrixType, colorMatrixValue);
                    }
                case AppMode.Split:
                    {
                        return Split(image, imageFileName, output, splitImageFormat, splitUnitType, splitHorizontal, splitVertical);
                    }
                case AppMode.Stats:
                    {
                        return Stats(image, output);
                    }
            }

            return 0;
        }

        public static string NormalizeFileName(string fileName)
        {
            return string.IsNullOrWhiteSpace(Path.GetDirectoryName(fileName)) ? Path.Combine(Environment.CurrentDirectory, fileName) : fileName;
        }

        public static int Split(Image image, string imageFileName, string output, ImageFormat format, Nullable<SplitUnitType> splitType, int? splitHorizontal, int? splitVertical)
        {
            if (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(string.Format("Output parameter is required in <{0}> mode. Please see help for details.", AppMode.Split));

                return -1;
            }

            if (!splitHorizontal.HasValue)
            {
                Console.WriteLine(string.Format("Horizontal parameter is required in <{0}> mode. Please see help for details.", AppMode.Split));

                return -1;
            }

            if (!splitVertical.HasValue)
            {
                Console.WriteLine(string.Format("Vertical parameter is required in <{0}> mode. Please see help for details.", AppMode.Split));

                return -1;
            }

            if (!Directory.Exists(output))
            {
                Console.WriteLine(string.Format("Directory <{0}> does not exists.", output));

                return -1;
            }

            var result = default(SplitterResult[][]);

            try
            {
                result = new Splitter(image).Split(new SplitterRequest()
                {
                    Type = splitType.HasValue ? splitType.Value : SplitUnitType.Pixel,
                    Horizontal = splitHorizontal.Value,
                    Vertical = splitVertical.Value
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to split image. Please see the error below.");
                Console.WriteLine(ex.ToString());

                return -1;
            }

            var originalFileName = Path.GetFileNameWithoutExtension(imageFileName);
            var extension = ImageFormatToFileExtension(format);

            var outputImageCount = 0;

            try
            {
                for (var x = 0; x < result.Length; x++)
                {
                    var line = result[x];

                    for (var y = 0; y < line.Length; y++)
                    {
                        var fileName = Path.Combine(output, string.Format("{0}.{1:D4}.{2:D4}{3}", originalFileName, x, y, extension));

                        line[y].Image.Save(fileName, format);

                        outputImageCount++;
                    }
                }

                Console.WriteLine(string.Format("Successfully saved <{0}> images to <{1}>.", outputImageCount, output));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Unable to save file(s) to <{0}>. Please see the error below.", output));
                Console.WriteLine(ex.ToString());

                return -1;
            }


            return 0;
        }

        public static int Stats(Image image, string output)
        {
            var result = default(StatsResult);

            try
            {
                result = new Stats(image).Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to calculate statistics. Please see the error below.");
                Console.WriteLine(ex.ToString());

                return -1;
            }

            try
            {
                using (var writer = string.IsNullOrWhiteSpace(output) ? Console.OpenStandardOutput() : new FileStream(output, FileMode.Create, FileAccess.Write))
                {
                    var colorsText = Encoding.UTF8.GetBytes("Colors:");
                    var colorsCountText = Encoding.UTF8.GetBytes(string.Format("Colors:    {0}", result.Counts.Length));
                    var newLineText = Encoding.UTF8.GetBytes(Environment.NewLine);

                    var brightestText = Encoding.UTF8.GetBytes(string.Format("Brightest: R: {0,3}. G: {1,3}, B: {2,3}, A: {3,3}", result.Brightest.R, result.Brightest.G, result.Brightest.B, result.Brightest.A));
                    var darkestText = Encoding.UTF8.GetBytes(string.Format("Darkest:   R: {0,3}. G: {1,3}, B: {2,3}, A: {3,3}", result.Darkest.R, result.Darkest.G, result.Darkest.B, result.Darkest.A));

                    writer.Write(colorsCountText, 0, colorsCountText.Length);
                    writer.Write(newLineText, 0, newLineText.Length);
                    writer.Write(newLineText, 0, newLineText.Length);

                    writer.Write(brightestText, 0, brightestText.Length);
                    writer.Write(newLineText, 0, newLineText.Length);

                    writer.Write(darkestText, 0, darkestText.Length);
                    writer.Write(newLineText, 0, newLineText.Length);
                    writer.Write(newLineText, 0, newLineText.Length);

                    writer.Write(colorsText, 0, colorsText.Length);
                    writer.Write(newLineText, 0, newLineText.Length);

                    for (var x = 0; x < result.Counts.Length; x++)
                    {
                        var count = result.Counts[x].Count;
                        var color = result.Counts[x].Color;

                        var colortText = Encoding.UTF8.GetBytes(string.Format("Count: {0, 12}: Color:  R: {1,3}. G: {2,3}, B: {3,3}, A: {4,3}", count, color.R, color.G, color.B, color.A));
                        writer.Write(colortText, 0, colortText.Length);
                        writer.Write(newLineText, 0, newLineText.Length);
                    }
                }

                if (!string.IsNullOrWhiteSpace(output))
                {
                    Console.WriteLine(string.Format("Result saved as <{0}>.", output));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.IsNullOrWhiteSpace(output)
                                    ? "Unable to print results on the screen."
                                    : string.Format("Unable to save results to <{0}>. Please see the error below.", output));
                Console.WriteLine(ex.ToString());

                return -1;
            }

            return 0;
        }

        public static bool TryParseImageFormat(string format, out ImageFormat imageFormat)
        {
            var extension = format.ToLowerInvariant().Replace("ico", "icon").Replace("jpg", "jpeg").Replace("tif", "tiff");

            var imageFormatProperty = typeof(ImageFormat).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty)
                                                            .FirstOrDefault(p => p.Name.ToLowerInvariant() == extension);

            imageFormat = imageFormatProperty == default ? default : (ImageFormat)imageFormatProperty.GetValue(default, default);

            return imageFormat != default;
        }
    }
}