using System.IO;
using Xunit;
using _10_Fichiers;

namespace _12_TestsUnitaires
{
    public class FileManagerTests
    {
        private readonly string testFile = "test_unitaire.txt";

        [Fact]
        public void WriteAndReadText_WorksCorrectly()
        {
            // Arrange
            var fm = new FileManager(testFile);
            string texteAttendu = "Bonjour test unitaire";

            // Act
            fm.WriteText(texteAttendu);
            string texteLu = fm.ReadText();

            // Assert
            Assert.Equal(texteAttendu, texteLu);

            // Nettoyage
            if (File.Exists(testFile))
                File.Delete(testFile);
        }
    }
}
