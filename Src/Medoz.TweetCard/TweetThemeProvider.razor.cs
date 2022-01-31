namespace Medoz.TweetCard;
using System;
using Microsoft.AspNetCore.Components;

public partial class TweetThemeProvider : ComponentBase
{
#nullable enable
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
#nullable disable
}
