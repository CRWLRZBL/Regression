using System.Drawing;

namespace Regression
{
    public class BoxValidator
    {
        public bool ValidateRed(Box box)
        {
            return box.Color == Color.Red;
        }
        public bool ValidateVolume(Box box)
        {
            return box.Depth * box.Height * box.Width < 3;
        }
        public bool ValidateBlueQuick(Box box)
        {
            return box.Color == Color.Blue && box.Mark == "Срочное";
        }
        public bool ValidateRedMoreVolume(Box box)
        {
            return box.Color == Color.Red && box.Depth * box.Height * box.Width >= 3;
        }
        public bool ValidateFragileNoBlue(Box box)
        {
            return box.Color == Color.Blue ? false : box.Mark == "Хрупкое";
        }
        public bool ValidateGreen(Box box)
        {
            return box.Color == Color.Green;
        }
        public bool ValidateMarkFragileAndQuick(Box box)
        {
            return box.Mark.Contains("Срочное")&&box.Mark.Contains("Хрупкое");
        }
        public bool ValidateVolumeFromTwoToFiveQuick(Box box)
        {
            var volume = box.Depth * box.Height * box.Width;
            return volume<5 && volume>2 && box.Mark == "Срочное";
        }
        public bool ValidateHeavyNotGreen(Box box)
        {
            return box.Color != Color.Green && box.Mark == "Тяжёлое";
        }
        public bool ValidateYellowVolume(Box box)
        {
            return box.Color == Color.Yellow && box.Depth * box.Height * box.Width < 4;
        }
    }
}

