using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private readonly IServiceMedia _serviceMedia;

        public Tests(IServiceMedia serviceMedia)
        {
            _serviceMedia = serviceMedia;
        }

        [Test]
        public void Dado_Nota_Menor_Que_sete_Reprovado()
        {
            _serviceMedia.ValidateMedia();
            Assert.IsTrue(true);
        }

        [Test]
        public void Dado_Nota_Maior_Que_sete_Aprovado()
        {
            _serviceMedia.ValidateMedia();
            Assert.IsTrue(false);
        }
    }
}