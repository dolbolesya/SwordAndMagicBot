using Deployf.Botf;

namespace SwordAndMagic.Controller;

public class MainController : BotController
{
    [Action("/start","registration")]
    public void Start()
    {
        PushL($"welcome to bot");
    }
}