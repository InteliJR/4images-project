using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace _4images.Services
{
    public class ImageProcessingService
    {

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
                // adicionar outros casos de filtros, se necessário
                default:
                    throw new ArgumentException("Filtro não suportado");
            }

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }

        public async Task<Stream> AdjustBrightnessAsync(Stream imageStream, float brightness)
        {
            using var image = await Image.LoadAsync<Rgba32>(imageStream);
            image.Mutate(x => x.Brightness(brightness));

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }

        public async Task<Stream> AdjustContrastAsync(Stream imageStream, float contrast)
        {
            using var image = await Image.LoadAsync<Rgba32>(imageStream);
            image.Mutate(x => x.Contrast(contrast));

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }

        public async Task<Stream> AdjustSaturationAsync(Stream imageStream, float saturation)
        {
            using var image = await Image.LoadAsync<Rgba32>(imageStream);
            image.Mutate(x => x.Saturate(saturation));

            var memoryStream = new MemoryStream();
            await image.SaveAsJpegAsync(memoryStream);
            memoryStream.Position = 0;

            return memoryStream;
        }

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

        public async Task<Stream> ResizeImageAsync(Stream imageStream, double scale)
        {
            if (scale != 0.5 && scale != 0.25)
            {
                throw new ArgumentException("Proporção de redimensionamento inválida. Use 0.5 (metade) ou 0.25 (um quarto).");
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
