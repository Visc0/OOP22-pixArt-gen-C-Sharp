using System.Drawing;

namespace MicolucciProject.main.DrawingTools;

public sealed class Pencil : AbstractDrawingTool
{
    private readonly Color _selectedColor;

    public Pencil(Color selectedColor, int size) : base(size) => _selectedColor = selectedColor;

    public override void UpdatePixel(HashSet<PixelImpl> frame, int x, int y, HashSet<PixelImpl> newPixSet)
    {
        PixelImpl tempPix = new PixelImpl(x, y, _selectedColor);
        newPixSet.Add(tempPix);
    }
}