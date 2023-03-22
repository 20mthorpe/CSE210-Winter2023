class Toad : Pet
{
    private bool _isSpotted;
    public Toad(bool isSpotted, string name): base(name)
    {
        _isSpotted = isSpotted;
    }
}