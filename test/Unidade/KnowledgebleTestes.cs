using FluentAssertions;
using NUnit.Framework;
using Unidade.Configuration;

namespace Unidade
{
    public class Tests
    {
        [Test]
        public void KnowledgeableDeveRealizarLog()
        {
            var mensagemEsperada = "Timer trigger executada as";
            var logger = new ListLogger();

            knowledgeable.knowledgeable.RunAsync(null, logger);
            var mensagemLog = logger.Logs[0];

            mensagemLog.Should().Contain(mensagemEsperada);
        }
    }
}
