using System.Drawing;

namespace Regression.Test
{
    public class BoxValidatorTests
    {
        BoxValidator _validator = new BoxValidator();
        public BoxValidatorTests()
        {
            _validator = new BoxValidator();
        }

        [Fact]
        public void Validate_ShouldBeRed()
        {
            Box box = new Box
            {
                Color = Color.Red
            };

            Assert.True(_validator.ValidateRed(box));
        }
        [Fact]
        public void Validate_ShouldBeGreen()
        {
            Box box = new Box
            {
                Color = Color.Green
            };

            Assert.True(_validator.ValidateGreen(box));
        }
        [Fact]
        public void Validate_VolumeLessThree()
        {
            Box box = new Box
            {
                Height = 1,
                Width = 1,
                Depth = 2
            };

            Assert.True(_validator.ValidateVolume(box));
        }
        [Fact]
        public void Validate_ShouldBeRedVolumeMoreThree()
        {
            Box box = new Box
            {
                Height = 1,
                Width = 1,
                Depth = 4,
                Color = Color.Red
            };

            Assert.True(_validator.ValidateRedMoreVolume(box));
        }
        [Fact]
        public void Validate_ShouldBeRedFragile()
        {
            Box box = new Box
            {
                Mark = "’рупкое",
                Color = Color.Red
            };

            Assert.True(_validator.ValidateFragileNoBlue(box));
        }
        [Fact]
        public void Validate_ShouldBeBlueQuick()
        {
            Box box = new Box
            {
                Mark = "—рочное",
                Color = Color.Blue
            };

            Assert.True(_validator.ValidateBlueQuick(box));
        }
        [Fact]
        public void Validate_MarkFragileAndQuick()
        {
            Box box = new Box
            {
                Mark = "—рочное’рупкое",
            };

            Assert.True(_validator.ValidateMarkFragileAndQuick(box));
        }
        [Fact]
        public void Validate_VolumeFromTwoToFiveQuick()
        {
            Box box = new Box
            {
                Width = 1,
                Depth = 2,
                Height = 2,
                Mark = "—рочное",
            };

            Assert.True(_validator.ValidateVolumeFromTwoToFiveQuick(box));
        }
        [Fact]
        public void Validate_HeavyNotGreen()
        {
            Box box = new Box
            {
                Mark = "“€жЄлое",
                Color = Color.Blue
            };

            Assert.True(_validator.ValidateHeavyNotGreen(box));
        }
        [Fact]
        public void Validate_HeavyNotGreen()
        {
            Box box = new Box
            {
                Mark = "“€жЄлое",
                Color = Color.Blue
            };

            Assert.True(_validator.ValidateHeavyNotGreen(box));
        }
    }
}
