﻿namespace Elistia.DotNetRtfWriter
{
#if NETSTD_XAMARIN
    using System;
    using System.IO;
    using Xamarin.Forms;

    /// <summary>
    /// 
    /// </summary>
    public static class RtfExtensions
    {
        public static RtfColor ToRtfColor(this Color color)
        {
            return new RtfColor((byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255));
        }

        public static ColorDescriptor CreateColor(this RtfDocument document, Color color)
        {
            var rtfColor = color.ToRtfColor();
            return document.CreateColor(rtfColor);
        }

        // RtfImageType { Jpg = 1, Gif, Png }
        //private static readonly ImageFormat[] EtoImageFormats = new ImageFormat[] { ImageFormat.Bitmap, ImageFormat.Jpeg, ImageFormat.Gif, ImageFormat.Png };

        /// <summary>
        /// Add an image to this container from a file with filetype provided.
        /// </summary>
        /// <param name="imgFname">Filename of the image.</param>
        /// <param name="imgType">File type of the image.</param>
        /// <returns>Image being added.</returns>
        /*public static RtfImage AddImage(this RtfBlockList blockList, string imgFname, RtfImageType imgType, ReadingDirection direction = ReadingDirection.LeftToRight)
        {
            if (!blockList._allowImage) {
                throw new Exception("Image is not allowed.");
            }

            var image = new Bitmap(imgFname);
            float width = image.Width; //(image.Width / image.HorizontalResolution) * 72;
            float height = image.Height; //(image.Height / image.VerticalResolution) * 72;

            byte[] imgBytes;
            using (MemoryStream mStream = new MemoryStream()) {
                image.Save(mStream, EtoImageFormats[(int)imgType]);
                imgBytes = mStream.ToArray();
            }

            RtfImage block = new RtfImage(imgType, width, height, imgBytes, imgFname, direction);
            blockList.AddBlock(block);
            return block;
        }*/

        /// <summary>
        /// Add an image to this container from a file. Will autodetect format from extension.
        /// </summary>
        /// <param name="imgFname">Filename of the image.</param>
        /// <returns>Image being added.</returns>
        /*public static RtfImage AddImage(this RtfBlockList blockList, string imgFname, ReadingDirection direction = ReadingDirection.LeftToRight)
        {
            int dot = imgFname.LastIndexOf(".");
            if (dot < 0) {
                throw new Exception("Cannot determine image type from the filename extension: " + imgFname);
            }

            string ext = imgFname.Substring(dot + 1).ToLower();
            switch (ext) {
                case "jpg":
                case "jpeg":
                    return AddImage(blockList, imgFname, RtfImageType.Jpg, direction);
                case "gif":
                    return AddImage(blockList, imgFname, RtfImageType.Gif, direction);
                case "png":
                    return AddImage(blockList, imgFname, RtfImageType.Png, direction);
                default:
                    throw new Exception("Cannot determine image type from the filename extension: " + imgFname);
            }
        }*/

        /// <summary>
        /// Add an image to this container from a stream.
        /// </summary>
        /// <param name="imageStream">MemoryStream containing image.</param>
        /// <returns>Image being added.</returns>
        /*public static RtfImage AddImage(this RtfBlockList blockList, MemoryStream imageStream, ReadingDirection direction = ReadingDirection.LeftToRight)
        {
            if (!blockList._allowImage) {
                throw new Exception("Image is not allowed.");
            }

            byte[] imgBytes = imageStream.ToArray();

            var image = new Bitmap(imageStream);
            float width = image.Width; //(image.Width / image.HorizontalResolution) * 72;
            float height = image.Height; //(image.Height / image.VerticalResolution) * 72;

            RtfImageType imgType;
            if (image.RawFormat.Equals(ImageFormat.Png))
                imgType = RtfImageType.Png;
            else if (image.RawFormat.Equals(ImageFormat.Jpeg))
                imgType = RtfImageType.Jpg;
            else if (image.RawFormat.Equals(ImageFormat.Gif))
                imgType = RtfImageType.Gif;
            else
                throw new Exception("Image format is not supported: " + image.RawFormat.ToString());

            RtfImage block = new RtfImage(imgType, width, height, imgBytes, String.Empty, direction);
            blockList.AddBlock(block);
            return block;
        }*/
    }
#endif
}
