using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using static System.Net.Mime.MediaTypeNames;

namespace _4images.Services
{
    /// <summary>
    /// Provides image processing services including applying filters,
    /// adjusting brightness, contrast, saturation, compressing images,
    /// and resizing images.
    /// </summary>
    public class ImageProcessingService
    {
        /// <summary>
        /// Applies a specified filter to the image.
        /// </summary>
        /// <param name="imageStream">The input image stream.</param>
        /// <param name="filterType">The type of filter to apply. Supported values: "grayscale", "sepia".</param>
        /// <returns>A stream containing the processed image.</returns>
        /// <exception cref="ArgumentException">Thrown when an unsupported filter type is provided.</exception>
        public async Task<Stream> ApplyFilterAsync(Stream imageStream, string filterType)
        {
            using var image = await Image.LoadAsync<Rgba32>(imageStream);

            switch (filterType.ToLower())
            {
                case "grayscale":
                    image.Mutate(x => x.Grayscale());
                    break;
                case "sepia":
                    image.Mutate(x => x.Sepia());
                    break;
                // Add other filter cases as needed
                default:
                    throw new ArgumentException("Unsupported filter type");
            }

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }

        /// <summary>
        /// Adjusts the brightness of the image.
        /// </summary>
        /// <param name="imageStream">The input image stream.</param>
        /// <param name="brightness">The brightness level to apply. Should be between 0 and 2. 1 means no change.</param>
        /// <returns>A stream containing the processed image.</returns>
        public async Task<Stream> AdjustBrightnessAsync(Stream imageStream, float brightness)
        {
            using var image = await Image.LoadAsync<Rgba32>(imageStream);
            image.Mutate(x => x.Brightness(brightness));

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }

        /// <summary>
        /// Adjusts the contrast of the image.
        /// </summary>
        /// <param name="imageStream">The input image stream.</param>
        /// <param name="contrast">The contrast level to apply. Should be between 0 and 2. 1 means no change.</param>
        /// <returns>A stream containing the processed image.</returns>
        public async Task<Stream> AdjustContrastAsync(Stream imageStream, float contrast)
        {
            using var image = await Image.LoadAsync<Rgba32>(imageStream);
            image.Mutate(x => x.Contrast(contrast));

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }

        /// <summary>
        /// Adjusts the saturation of the image.
        /// </summary>
        /// <param name="imageStream">The input image stream.</param>
        /// <param name="saturation">The saturation level to apply. Should be between 0 and 2. 1 means no change.</param>
        /// <returns>A stream containing the processed image.</returns>
        public async Task<Stream> AdjustSaturationAsync(Stream imageStream, float saturation)
        {
            using var image = await Image.LoadAsync<Rgba32>(imageStream);
            image.Mutate(x => x.Saturate(saturation));

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }

        /// <summary>
        /// Compresses the image to the specified quality.
        /// </summary>
        /// <param name="imageStream">The input image stream.</param>
        /// <param name="quality">The quality level to apply. Should be between 0 and 100. Higher values mean better quality.</param>
        /// <returns>A stream containing the compressed image.</returns>
        public async Task<Stream> CompressImageAsync(Stream imageStream, int quality)
        {
            using var image = await Image.LoadAsync<Rgba32>(imageStream);

            var memoryStream = new MemoryStream();
            var encoder = new JpegEncoder
            {
                Quality = quality
            };

            await image.SaveAsync(memoryStream, encoder);
            memoryStream.Position = 0;

            return memoryStream;
        }

        /// <summary>
        /// Resizes the image based on the provided scale.
        /// </summary>
        /// <param name="imageStream">The input image stream.</param>
        /// <param name="scale">The scale factor for resizing. Supported values: 0.5 (half size), 0.25 (quarter size).</param>
        /// <returns>A stream containing the resized image.</returns>
        /// <exception cref="ArgumentException">Thrown when an unsupported scale factor is provided.</exception>
        public async Task<Stream> ResizeImageAsync(Stream imageStream, double scale)
        {
            if (scale != 0.5 && scale != 0.25)
            {
                throw new ArgumentException("Invalid resize proportion. Use 0.5 (half) or 0.25 (quarter).");
            }

            using var image = await Image.LoadAsync<Rgba32>(imageStream);
            var newWidth = (int)(image.Width * scale);
            var newHeight = (int)(image.Height * scale);

            image.Mutate(x => x.Resize(newWidth, newHeight));

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }
    }
}
