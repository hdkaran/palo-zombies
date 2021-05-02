using Microsoft.AspNetCore.Components;
using PaloZombies.Client.Shared.UiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Shared
{
    public partial class Pagination
    {
        [Parameter] //starting as 0
        public int CurrentPage { get; set; } = 0;
        [Parameter]
        public int TotalPages { get; set; }
        [Parameter] //radius to create a window of numbers
        public int Radius { get; set; } = 3;
        [Parameter]
        public EventCallback<int> SelectedPages { get; set; }

        private List<LinkModel> links = new List<LinkModel>();

        // this will be invoked if any of the links in the paginator are clicked.
        // Check if User has clicked Current Selected Page then => return and don't do any thing
        // otherwise, check if the link is enabled and if not => return and don't do any thing
        // otherwise, request the selected link
        private async Task SelectedPageInternal(LinkModel link)
        {
            if (link.Page == CurrentPage)
            {
                return;
            }
            if (!link.Enabled)
            {
                return;
            }
            await SelectedPages.InvokeAsync(link.Page);
        }
        // Lifecycle method. Runs when parameters are set
        protected override Task OnParametersSetAsync()
        {
            LoadPages();
            return base.OnParametersSetAsync();
        }
        // After the params have been received this function will initialize the paginator
        private void LoadPages()
        {
            // empty older links and create new ones
            links = new List<LinkModel>();
            //pages start from 0 but total pages give number of pages.
            //previous link settings and check for if current selected page is the first page.
            bool isPreviosPageLinkEnabled = CurrentPage != 0;
            int previousPage = CurrentPage - 1;
            links.Add(new LinkModel(previousPage, isPreviosPageLinkEnabled, "Previous"));

            for (int i = 0; i < TotalPages; i++)
            {
                if (i >= CurrentPage - Radius && i <= CurrentPage + Radius)
                {
                    links.Add(new LinkModel(i) { Active = CurrentPage == i });
                }
            }

            //next link settings and check for if the last page is the current selected page
            bool isNextPageLinkEnabled = CurrentPage != (TotalPages - 1);
            int nextPage = CurrentPage + 1;
            links.Add(new LinkModel(nextPage, isNextPageLinkEnabled, "Next"));

        }
    }
}
