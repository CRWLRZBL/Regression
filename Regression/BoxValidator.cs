using System.Drawing;

namespace Regression
{
    public class BoxValidator
    {
        public bool Validate(Box box)
        {
            return box.Color == Color.Red;
        }
    }
}
