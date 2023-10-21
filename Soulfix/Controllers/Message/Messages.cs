namespace Soulfix.Controllers.Message
{
    public class Message : IMessage
    {

        private int _count = 0;
        public string CreateMessage(string entity, int statusMessage)
        {

            foreach (var text in msg)
            {
                if (_count == statusMessage)
                {
                    return text + " do registro de " + entity;
                }
            }
            _count++;
            return msg[2];
        }

        private readonly string[] msg =
        {
          "Sucesso na criação" ,
          "Falha na criiação",
          "Valide os dados e tente novamente"
        };

    }
}
