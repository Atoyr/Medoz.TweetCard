namespace Medoz.TweetCard;
using System;
using Microsoft.AspNetCore.Components;

public partial class TweetCardThemeProvider : ComponentBase
{
#nullable enable
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    private TweetCardTheme? _theme;
    public TweetCardTheme? Theme 
    {
        get => _theme;
        set 
        {
            if (_theme == value)
            {
                return;
            }
            if (_theme is not null)
            {
                _theme.Changed -= OnThemeChanged;

            }

            _theme = value;
            if (_theme is not null)
            {
                _theme.Changed += OnThemeChanged;
            }
        }
    }
#nullable disable
    private void OnThemeChanged(object sender, System.EventArgs e)
    {
        this.StateHasChanged();
    }

    public void Dispose()
    {
        if (_theme != null)
        {
            _theme.Changed -= OnThemeChanged;
        }
    }
}
