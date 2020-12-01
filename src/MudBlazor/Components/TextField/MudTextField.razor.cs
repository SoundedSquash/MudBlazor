﻿using System;
using System.Windows.Input;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazor.Utilities;
using MudBlazor.Extensions;
using Microsoft.AspNetCore.Components.Web;

namespace MudBlazor
{
    public partial class MudTextField<T> : MudBaseInput<T>
    {
        protected string Classname =>
           new CssBuilder("mud-input-input-control").AddClass(Class)
           .Build();

        private MudInput<string> elementReference;

        public override ValueTask FocusAsync()
        {
            return elementReference.FocusAsync();
        }
    }

    public class MudTextFieldString : MudTextField<string> {
        
    }
}
