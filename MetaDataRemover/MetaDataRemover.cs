using System;
using System.IO;
using SixLabors.ImageSharp;

namespace MetaData.Remover.Classes;

public class MetaDataRemover
{
    public static Stream RemoveMetadataFromStream(Stream inStream, Stream outStream)
    {
        if (inStream == null)
        {
            throw new ArgumentNullException("inStream");
        }

        if (outStream == null)
        {
            throw new NullReferenceException("outStream");
        }

        try
        {
            using (Image image = Image.Load(inStream))
            {
                image.Metadata.ExifProfile = null;
                image.Metadata.IptcProfile = null;
                image.Metadata.XmpProfile = null;
                image.Save(outStream, image.Metadata.DecodedImageFormat);
            }

            return outStream;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static void RemoveMetadataUsingPath(string inputPath, string outputPath)
    {
        if (string.IsNullOrWhiteSpace(inputPath))
        {
            throw new ArgumentNullException("inputPath");
        }

        if (string.IsNullOrWhiteSpace(outputPath))
        {
            throw new ArgumentNullException("outputPath");
        }

        try
        {
            using Image image = Image.Load(inputPath);
            image.Metadata.ExifProfile = null;
            image.Metadata.IptcProfile = null;
            image.Metadata.XmpProfile = null;
            image.Save(outputPath);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}