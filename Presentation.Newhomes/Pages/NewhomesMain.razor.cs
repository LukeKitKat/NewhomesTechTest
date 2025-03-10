﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Server.Newhomes;
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
        [Inject]
        public NewhomesService Service { get; set; } = default!;

        public NumericalModel Model { get; set; } = new();
        public List<NumericalModel> ExistingEntries = new List<NumericalModel>();

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            ExistingEntries = await Service.GetAllEntriesAsync();
        }

        private async Task CalculateNumberAsync()
        {
            Model.Result = Model.Number1 + Model.Number2;
            await Service.AddEntryAsync(Model);

            RefreshModel();
            await RefreshTableAsync();
        }

        private async Task RefreshTableAsync()
        {
            ExistingEntries = await Service.GetAllEntriesAsync();
            StateHasChanged();
        }

        private void RefreshModel()
        {
            Model.Id = 0;
        }
    }
}
