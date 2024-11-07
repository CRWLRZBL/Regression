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

            Assert.True(_validator.Validate(box));
        }
    }
}