using Microsoft.AspNetCore.Components;
using PaloZombies.Client.Shared.UiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Components
{
    public partial class LevelOfPainSelector
    {
        [Parameter]
        public EventCallback GoBack { get; set; }
        [Parameter]
        public EventCallback<int> SetSelectedLevelOfPain { get; set; }

        private List<SmileyModel> smileyModels;
        protected override Task OnInitializedAsync()
        {
            smileyModels = new List<SmileyModel>();
            InitSmileys();
            return base.OnInitializedAsync();
        }


        private void InitSmileys()
        {
            smileyModels.Add(new SmileyModel() { PainLevel = 0, Emoji ="😀" , BackgroundColour="green"});
            smileyModels.Add(new SmileyModel() { PainLevel = 1, Emoji = "🙂", BackgroundColour="lightgreen" });
            smileyModels.Add(new SmileyModel() { PainLevel = 2, Emoji = "😐", BackgroundColour="yellow" });
            smileyModels.Add(new SmileyModel() { PainLevel = 3, Emoji = "🙁", BackgroundColour="orange" });
            smileyModels.Add(new SmileyModel() { PainLevel = 4, Emoji = "😫", BackgroundColour="red" });
        }
    }
}
