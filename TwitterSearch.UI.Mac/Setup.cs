using System;
using System.Collections.Generic;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Plugins;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Binding.Touch;
using Cirrious.MvvmCross.Platform;
using Cirrious.MvvmCross.Binding.Binders;
using TwitterSearch.Core;
using TwitterSearch.Core.Converters;
using Cirrious.MvvmCross.Binding.Parse;
using Cirrious.MvvmCross.Binding.Parse.Binding.Swiss;
using Cirrious.MvvmCross.Binding.Binders;
using Cirrious.MvvmCross.Mac.Platform;
using Cirrious.MvvmCross.Mac.Views.Presenters;

namespace TwitterSearch.UI.Mac
{
   public class Setup
        : MvxMacSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxMacViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }
						
        protected override IMvxApplication CreateApp()
        {
            var app = new TwitterSearchApp();
            return app;
        }
    }
}

