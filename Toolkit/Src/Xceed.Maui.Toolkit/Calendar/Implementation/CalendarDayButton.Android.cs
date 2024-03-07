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


namespace Xceed.Maui.Toolkit
{
  public partial class CalendarDayButton
  {
    #region Partial Methods

    partial void UpdateVisualState()
    {
      if( !this.IsEnabled )
      {
        VisualStateManager.GoToState( this, VisualStateManager.CommonStates.Disabled );
      }
      else if( this.IsBlackedOut )
      {
        VisualStateManager.GoToState( this, CalendarDayButton.VisualState_BlackoutDay );
      }
      else if( this.IsToday && m_calendar != null && m_calendar.IsTodayHighlighted )
      {
        VisualStateManager.GoToState( this, CalendarDayButton.VisualState_Today );
      }
      else if( this.IsSelected )
      {
        VisualStateManager.GoToState( this, VisualStateManager.CommonStates.Selected );
      }
      else if( this.IsInactive )
      {
        VisualStateManager.GoToState( this, CalendarDayButton.VisualState_Inactive );
      }
      else
      {
        VisualStateManager.GoToState( this, VisualStateManager.CommonStates.Normal );
      }
    }

    #endregion
  }
}
