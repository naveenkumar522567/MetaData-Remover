## About

Metadata in images refers to data that is embedded within an image file that provides information about the image. This information can include a wide range of details about the image's creation, the camera settings used, the location where the photo was taken, and much more.

`MetadataRemover` package is a powerful .NET library for extracting metadata from image files. It remove metadata types, including EXIF, IPTC, and XMP from image files. This package is designed to be simple to use while providing comprehensive metadata extraction capabilities.

### Supported file types

It supports various image types like:
1. Bmp
2. Gif
3. Jpeg
4. Pbm
5. Png
6. Tiff
7. Tga
8. WebP


## Installation

To install the `MetadataRemover` package, use the following command in your .NET project:

```bash
dotnet add package MetadataRemover
```

This library removes metadata from images using two ways:

### Remove metadata from stream

Remove metadata from an image as a stream:

```
var output = MetaDataRemover.RemoveMetadataFromStream(memoryStream);
```

### Remove metadata using file path

Remove metadata from image given path of image and save it on a provided path.

```
MetaDataRemover.RemoveMetadataUsingPath("path\\to\\image", "path\\to\\image\\as\\output"); 
```
