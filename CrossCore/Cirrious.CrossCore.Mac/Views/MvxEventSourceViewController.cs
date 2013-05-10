// MvxEventSourceViewController.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using Cirrious.CrossCore.Core;
using MonoMac.AppKit;
using MonoMac.Foundation;

namespace Cirrious.CrossCore.Mac.Views
{
    public class MvxEventSourceViewController
        : NSViewController
          , IMvxEventSourceViewController
    {
        protected MvxEventSourceViewController()
        {
        }

        protected MvxEventSourceViewController(IntPtr handle)
			: base(handle)
        {
        }

		protected MvxEventSourceViewController(NSCoder coder)
			: base(coder)
		{
		}		

        protected MvxEventSourceViewController(string nibName, NSBundle bundle)
            : base(nibName, bundle)
        {
        }

		public override void LoadView ()
		{
			base.LoadView ();
			LoadCalled.Raise(this);
		}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisposeCalled.Raise(this);
            }
            base.Dispose(disposing);
        }

        public event EventHandler LoadCalled;
        public event EventHandler DisposeCalled;
    }
}