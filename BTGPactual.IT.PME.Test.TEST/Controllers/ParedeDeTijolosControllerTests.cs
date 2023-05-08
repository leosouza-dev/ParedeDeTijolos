using BTGPactual.IT.PME.Test.API.Controllers;
using BTGPactual.IT.PME.Test.API.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BTGPactual.IT.PME.Test.TEST.Controllers
{
    [TestFixture]
    public class ParedeDeTijolosControllerTests
    {
        private ParedeDeTijolosController _paredeDeTijolosController;

        [SetUp]
        public void Setup()
        {
            _paredeDeTijolosController = new ParedeDeTijolosController();
        }

        [Test]
        public void CortarTijolos_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            var paredeDTO = new ParedeDTO
            {
                LinhasDeTijolos = new List<List<int>>
            {
                new List<int> { 1, 2, 2, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 4 },
                new List<int> { 3, 1, 2 },
                new List<int> { 1, 3, 1, 1 }
            }
            };

            // Act
            var result = _paredeDeTijolosController.CortarTijolos(paredeDTO) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.StatusCode, Is.EqualTo(200));
            Assert.That(result.Value, Is.EqualTo(2));
        }

        [Test]
        public void CortarTijolos_NullInput_ReturnsBadRequest()
        {
            // Arrange
            ParedeDTO paredeDTO = null;

            // Act
            var result = _paredeDeTijolosController.CortarTijolos(paredeDTO) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.StatusCode, Is.EqualTo(400));
        }
    }
}
