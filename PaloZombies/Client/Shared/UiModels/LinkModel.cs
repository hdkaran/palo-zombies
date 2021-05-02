using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Shared.UiModels
{
    public class LinkModel
    {
        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;

        public LinkModel(int page) : this(page, true)
        { }

        public LinkModel(int page, bool enabled) : this(page, enabled, (page + 1).ToString())
        { }
        public LinkModel(int page, bool enabled, string text)
        {
            Page = page;
            Enabled = enabled;
            Text = text;
        }
    }
}
