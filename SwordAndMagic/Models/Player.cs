namespace SwordAndMagic.Models;

public class Player
{
    public uint Id { get; init; }
    public string Nickname { get; set; }
    public short HP { get; set; } = 100;
    public short Mana { get; set; } = 100;
    public short ATK { get; set; } = 10;
    public short DEF { get; set; } = 10;
    public PlayerType Type {get; set;}
    public List<Item> Equipment { get; set; }
    public List<Item> Inventory { get; set; }
}