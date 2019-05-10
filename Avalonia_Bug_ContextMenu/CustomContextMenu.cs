using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;

namespace Avalonia_Bug_ContextMenu
{
    public class CustomContextMenu : ContextMenu
    {
        public Type StyleKey => typeof(ContextMenu);
    }
}
