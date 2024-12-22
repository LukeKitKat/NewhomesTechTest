using Microsoft.AspNetCore.Components.Forms;
using Server.Newhomes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Newhomes.Pages
{
    public partial class NewhomesMain
    {
        public NumericalModel Model { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        public void CalculateNumber()
        {
            Model.Result = Model.Number1 + Model.Number2;
            StateHasChanged();
        }
    }
}
