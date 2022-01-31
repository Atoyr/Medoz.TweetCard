namespace Medoz.TweetCard;

public partial class TweetCardTheme 
{
    public string Primary { get; set; }

    public string Secondary { get; set; }

    public string Background { get; set; }

    public string OnBackground { get; set; }

    public string Annotation{ get; set; }

    public string Line { get; set; }

    public event EventHandler<EventArgs>? Changed;

    private TweetCardTheme() { }
    public void ThemeHasChanged()
    {
        OnChanged();
    }

    protected virtual void OnChanged()
    {
        Changed?.Invoke(this, EventArgs.Empty);
    }
}
