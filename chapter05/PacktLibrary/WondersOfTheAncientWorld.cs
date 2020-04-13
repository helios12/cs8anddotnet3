namespace Packt.Shared
{
    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {
        None = 0b_0000_0000,
        GreatPyramidOfGiza = 0b_0000_0001,
        HangingGardensOfBabylon = 0b_0000_0010,
        StatusOfZeusAtOlympia = 0b_0000_0100,
        TempleOfArtemisAtEphesus = 0b_0000_1000
    }
}