using Microsoft.FluentUI.AspNetCore.Components;
using System.Diagnostics;

namespace Raichu.Pages
{
    public partial class Home
    {
        public DesignThemeModes Mode { get; set; }

        public OfficeColor OfficeColor { get; set; }
        public void OfficeColorChanged(OfficeColor? e)
        {
            OfficeColor = e ?? OfficeColor.Default;
            StateHasChanged();
        }
        protected override void OnInitialized()
        {          
            base.OnInitialized();
        }
    }
}
