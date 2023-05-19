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
  public enum SpinDirection
  {
    Increase,
    Decrease
  }

  public class SpinEventArgs : EventArgs
  {
    #region Constructors

    public SpinEventArgs( SpinDirection direction )
      : base()
    {
      this.Direction = direction;
    }

    #endregion

    #region Public Properties

    #region Direction

    public SpinDirection Direction
    {
      get;
      private set;
    }

    #endregion

    #endregion
  }
}