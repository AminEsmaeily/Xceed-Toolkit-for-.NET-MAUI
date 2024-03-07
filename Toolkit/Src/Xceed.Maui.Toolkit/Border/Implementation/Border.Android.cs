﻿/***************************************************************************************
 
  Xceed Toolkit for MAUI is a multiplatform toolkit offered by Xceed Software Inc., 
  makers of the popular WPF Toolkit.

  COPYRIGHT (C) 2023 Xceed Software Inc. ALL RIGHTS RESERVED.

  This program is provided to you under the terms of a Xceed Community License 
  For more details about the Xceed Community License please visit the products GitHub or NuGet page .

  DISCLAIMER: This code is provided as-is and without warranty of any kind, express or implied. The 
  author(s) and owner(s) of this code shall not be liable for any damages or losses resulting from 
  the use or inability to use the code. 

 
  *************************************************************************************/


using Microsoft.Maui.Platform;

namespace Xceed.Maui.Toolkit
{
  public partial class Border
  {
    #region Partial Methods

    partial void InitializeForPlatform( object sender, EventArgs e )
    {
      var border = sender as Border;
      if( border != null )
      {
        var contentView = border.Handler?.PlatformView as ContentViewGroup;
        if( contentView != null )
        {
          contentView.Touch += this.ContentView_Touch;
        }
      }
    }

    partial void UninitializeForPlatform( object sender, HandlerChangingEventArgs e )
    {
      var border = sender as Border;
      if( border != null )
      {
        var contentView = border.Handler?.PlatformView as ContentViewGroup;
        if( contentView != null )
        {
          contentView.Touch -= this.ContentView_Touch;
        }
      }
    }

    #endregion

    #region Event Handlers

    private void ContentView_Touch( object sender, Android.Views.View.TouchEventArgs e )
    {
      var actionMask = e.Event?.ActionMasked;
      if( actionMask != null )
      {
        if( actionMask == Android.Views.MotionEventActions.Down )
        {
          this.RaisePointerDownEvent( this, EventArgs.Empty );
        }
        else if( actionMask == Android.Views.MotionEventActions.Up )
        {
          this.RaisePointerUpEvent( this, EventArgs.Empty );
        }
      }
    }

    #endregion
  }
}
